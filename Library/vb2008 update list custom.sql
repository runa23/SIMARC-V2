DECLARE @TableName AS varchar(50)

SELECT @TableName = 'T_FIN_PAYMENTREQDETAIL'
SELECT name, id
FROM sys.sysobjects
WHERE xtype = 'U'
AND name = @TableName
--------------------
SELECT 
	----------
	col.xtype,
	----------
	table_field = @TableName + '.' + RTRIM(col.name),
	----------
	fields = RTRIM(col.name) ,
	----------
	fieldsInsert = 
		case 
		WHEN col.name IN ('CREA_DATE','UPD_DATE') THEN 'GetDate()'
		WHEN col.name IN ('CREA_BY','UPD_BY') THEN '@GLOBARVAR_USERID'
		else '@' + RTRIM(col.name) 
		END + ',',
		
	----------
	fieldsUpdate = 
		case 
		WHEN col.name IN ('CREA_BY','CREA_DATE') THEN ''
		WHEN col.name IN ('UPD_DATE') THEN RTRIM(col.name) + '=GetDate()'+ ','
		WHEN col.name IN ('UPD_BY') THEN RTRIM(col.name) + '=@GLOBARVAR_USERID'+ ','
		else RTRIM(col.name) + '=@' + RTRIM(col.name) + ','
		END ,
	----------
	DTO_String = 'Public ' + RTRIM(col.name) + ' As ' + 
	CASE WHEN col.xtype IN (167,175,231) THEN 'String' 
	WHEN col.xtype IN (108,106) THEN 'Decimal' 
	WHEN col.xtype IN (61,40) THEN 'Date'
	WHEN col.xtype IN (104) THEN 'Boolean'
	WHEN col.xtype IN (48) THEN 'Byte'
	WHEN col.xtype IN (52) THEN 'Int16'
	WHEN col.xtype IN (56) THEN 'Integer'
	WHEN col.xtype IN (34) THEN 'Byte()'
	ELSE 'Object' END,
	----------
	Insert_String1 = 'lcCmd = lcCmd + "' + RTRIM(col.name) + ',"',
	----------
	Insert_String2 = 'lcCmd = lcCmd + "' +
	CASE 
	WHEN col.xtype IN (167,175,231) THEN '''"' + ' + poNewEntity.' + RTRIM(col.name) + '.Trim + "'',"'
	WHEN col.xtype IN (108,106) THEN '"' + ' + poNewEntity.' + RTRIM(col.name) + ' + ","'
	WHEN col.xtype IN (61,40) AND col.name NOT IN ('CREA_DATE','UPD_DATE') THEN '''"' + ' + poNewEntity.' + RTRIM(col.name) + '.Tostring("yyyyMMdd") + "'',"'
	WHEN col.xtype IN (104) THEN '"' + ' + poNewEntity.' + RTRIM(col.name) + ' + ","'
	WHEN col.xtype IN (48) THEN '"' + ' + poNewEntity.' + RTRIM(col.name) + ' + ","'
	WHEN col.xtype IN (52) THEN '"' + ' + poNewEntity.' + RTRIM(col.name) + ' + ","'
	WHEN col.xtype IN (56) THEN '"' + ' + poNewEntity.' + RTRIM(col.name) + ' + ","'
	WHEN col.xtype IN (34) THEN '"' + ' + poNewEntity.' + RTRIM(col.name) + ' + ","'
	WHEN col.name IN ('CREA_DATE','UPD_DATE') THEN 'GetDate(),"'
	ELSE RTRIM(col.name) + ',"' END,
----------------------------	
	Update_string = 'lcCmd = lcCmd + "' + col.name + ' = ' +
	CASE 
	WHEN col.xtype IN (167,175,231) THEN '''"' + ' + poNewEntity.' + RTRIM(col.name) + '.Trim + "'',"'
	WHEN col.xtype IN (108,106) THEN '"' + ' + poNewEntity.' + RTRIM(col.name) + ' + ","'
	WHEN col.xtype IN (61,40) AND col.name NOT IN ('CREA_DATE','UPD_DATE') THEN '''"' + ' + poNewEntity.' + RTRIM(col.name) + '.Tostring("yyyyMMdd") + "'',"'
	WHEN col.xtype IN (104) THEN '"' + ' + poNewEntity.' + RTRIM(col.name) + ' + ","'
	WHEN col.xtype IN (48) THEN '"' + ' + poNewEntity.' + RTRIM(col.name) + ' + ","'
	WHEN col.xtype IN (52) THEN '"' + ' + poNewEntity.' + RTRIM(col.name) + ' + ","'
	WHEN col.xtype IN (56) THEN '"' + ' + poNewEntity.' + RTRIM(col.name) + ' + ","'
	WHEN col.xtype IN (34) THEN '"' + ' + poNewEntity.' + RTRIM(col.name) + ' + ","'
	WHEN col.name IN ('CREA_DATE','UPD_DATE') THEN 'GetDate(),"'
	ELSE RTRIM(col.name) + ',"' END,
------------------------------
	ConvertParentGridEntity = 'poParentEntity.' + col.name + ' = .' + col.name ,
-----------------
	Update_String_if = 'lcCmd = lcCmd + "' + col.name + ' = ' +
	CASE WHEN col.xtype IN (48,52,108,61,104,56) THEN 
	'" + IIf(poNewEntity.' + col.name + ' IsNot Nothing, " ''" + poNewEntity.' + col.name + '.ToString + "''", "NULL") + ","'
	WHEN col.xtype IN (34) THEN
	'@' + col.name + ' ,"'
	ELSE '" + IIf(poNewEntity.' + col.name + ' IsNot Nothing, " ''" + poNewEntity.' + col.name + ' + "''", "NULL") + ","'
	END ,
	insertif = 'lcCmd = lcCmd + ' +
	CASE WHEN col.xtype IN (48,52,108,61,104,56) THEN 
	'IIf(poNewEntity.' + col.name + ' IsNot Nothing, " ''" + poNewEntity.' + col.name + '.ToString + "''", "NULL") + ","'
	WHEN col.xtype IN (34) THEN
	'"@' + col.name + ' ,"'
	ELSE ' IIf(poNewEntity.' + col.name + ' IsNot Nothing, " ''" + poNewEntity.' + col.name + ' + "''", "NULL") + ","'
	END,
-------------------
	CT_TextBox_MaxLength = col.name + 'CT_TextBox.MaxLength = ' + convert(varchar,col.length),
-------------------
	CT_VALIDATION = 'Dim loException As New CT_Exception' + CHAR(13) + 'Try' + CHAR(13) +
	case when isnullable = 0 then 
		'If ' + col.name +'CT_TextBox.Text = "" Then' + CHAR(13) +
			'loException.Add("CTV", "' + col.name +' tidak boleh kosong")' + CHAR(13) +
			'End If'
	end +
	'Catch ex As Exception' + CHAR(13) +
    'loException.Add(ex)' + CHAR(13) +
    'End Try' + CHAR(13) +
    'loException.ThrowExceptionIfErrors()'
FROM sys.syscolumns col, sys.sysobjects obj
WHERE obj.name = @TableName
and col.id = obj.id

-----------------------

SELECT 
	CT_VALIDATION =
		'If string.isnullorempty(' + col.name +'CT_TextBox.Text.trim) Then' + CHAR(13) +
			'lcErr = "' + col.name +' harus diisi"' + CHAR(13) +
			'loException.Add("01", lcErr)' + CHAR(13) +
			'loException.Add("01", lcErr)' + CHAR(13) +
		'End If'
	
FROM sys.syscolumns col, sys.sysobjects obj
WHERE obj.name = @TableName
and col.id = obj.id