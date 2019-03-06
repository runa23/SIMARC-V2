Imports SC_BackEnd
Imports SC_Common
Imports RPR0200Back
Imports System.Data.Common
Imports System.Data.SqlClient

Public Class RPR0200Cls
    Inherits SC_BusinessObject(Of RPR0200DTO01)

    Protected Overrides Sub SC_Deleting(poEntity As RPR0200DTO01)
        Dim loExcption As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loConn As DbConnection

        Try
            loConn = loDb.GetConnection

            lcCmd = "EXEC RPR0200 'DELETE"
            lcCmd = lcCmd & "','" & poEntity.REPAIR_ID
            lcCmd = lcCmd & "','" & poEntity.COMPANY_ID
            lcCmd = lcCmd & "','" & poEntity.COMPANY_OFFICE_ID
            lcCmd = lcCmd & "','" & Format(poEntity.FROM_DATE, "yyyyMMdd")
            lcCmd = lcCmd & "','" & Format(poEntity.TO_DATE, "yyyyMMdd")
            lcCmd = lcCmd & "','" & poEntity.BARCODE
            lcCmd = lcCmd & "','" & poEntity.OUTLET_ID
            lcCmd = lcCmd & "','" & poEntity.CREA_BY
            lcCmd = lcCmd & "','" & poEntity.UPD_BY & "'"

            loDb.SqlExecNonQuery(lcCmd, loConn, True)

            lcCmd = "DELETE FROM T_REPAIL_DETAIL WHERE REPAIR_ID = '" & poEntity.REPAIR_ID & "'"

            loDb.SqlExecNonQuery(lcCmd, loConn, True)

        Catch ex As Exception
            loExcption.Add(ex)
        End Try
        loExcption.ThrowExceptionIfErrors()
    End Sub

    Protected Overrides Function SC_Display(poEntity As RPR0200DTO01, poCRUDMode As eCRUDMode, plWithLock As Boolean) As RPR0200DTO01
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As RPR0200DTO01

        Try
            lcCmd = "SELECT A.[REPAIR_ID]"
            lcCmd = lcCmd & ",A.[COMPANY_ID]"
            lcCmd = lcCmd & ",A.[COMPANY_OFFICE_ID]"
            lcCmd = lcCmd & ",A.[FROM_DATE]"
            lcCmd = lcCmd & ",A.[TO_DATE]"
            lcCmd = lcCmd & ",A.[BARCODE]"
            lcCmd = lcCmd & ",A.[OUTLET_ID]"
            lcCmd = lcCmd & ",B.OUTLET_NAME"
            lcCmd = lcCmd & ",A.[CREA_BY]"
            lcCmd = lcCmd & ",A.[CREA_DATE]"
            lcCmd = lcCmd & ",A.[UPD_BY]"
            lcCmd = lcCmd & ",A.[UPD_DATE] "
            lcCmd = lcCmd & "FROM [SIMARC].[dbo].[T_REPAIR] A (NOLOCK) "
            lcCmd = lcCmd & "JOIN M_OUTLET B ON A.OUTLET_ID = B.OUTLET_ID "
            lcCmd = lcCmd & "WHERE A.REPAIR_ID = '" & poEntity.REPAIR_ID & "'"

            loReturn = loDb.SQLExecObjectQuery(Of RPR0200DTO01)(lcCmd, loDb.GetConnection, True).FirstOrDefault
            Return loReturn

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Function

    Protected Overrides Sub SC_Saving(poNewEntity As RPR0200DTO01, poOldEntity As RPR0200DTO01, poCRUDMode As eCRUDMode)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loConn As DbConnection
        Dim loHelper As New SC_Helper
        Dim Kode As String

        Try
            loConn = loDb.GetConnection

            If poCRUDMode = eCRUDMode.AddMode Then

                lcCmd = "SELECT * FROM M_ASET WHERE BARCODE = '" & poNewEntity.BARCODE & "'"
                If loDb.SqlExecQuery(lcCmd, loConn, False).Rows.Count <= 0 Then
                    loException.Add("Validasi", "Barcode " & poNewEntity.BARCODE & " tidak ditemukan")
                    Exit Try
                End If

                Kode = Format(poNewEntity.FROM_DATE, "yyMM")
                Kode = "RPR" & Kode
                Kode = Kode & loHelper.SC_GenerateKey(Kode, 3, loConn)
                poNewEntity.REPAIR_ID = Kode

                lcCmd = "SELECT A.[REPAIR_ID]"
                lcCmd = lcCmd & ",A.[COMPANY_ID]"
                lcCmd = lcCmd & ",A.[COMPANY_OFFICE_ID]"
                lcCmd = lcCmd & ",A.[FROM_DATE]"
                lcCmd = lcCmd & ",A.[TO_DATE]"
                lcCmd = lcCmd & ",A.[BARCODE]"
                lcCmd = lcCmd & ",A.[OUTLET_ID]"
                lcCmd = lcCmd & ",B.OUTLET_NAME"
                lcCmd = lcCmd & ",A.[CREA_BY]"
                lcCmd = lcCmd & ",A.[CREA_DATE]"
                lcCmd = lcCmd & ",A.[UPD_BY]"
                lcCmd = lcCmd & ",A.[UPD_DATE] "
                lcCmd = lcCmd & "FROM [SIMARC].[dbo].[T_REPAIR] A (NOLOCK) "
                lcCmd = lcCmd & "JOIN M_OUTLET B ON A.OUTLET_ID = B.OUTLET_ID "
                lcCmd = lcCmd & "WHERE A.REPAIR_ID = '" & poNewEntity.REPAIR_ID & "'"

                If loDb.SqlExecQuery(lcCmd, loConn, False).Rows.Count > 0 Then
                    loException.Add("Validasi", "Data tidak dapat disimpan. Data Repair " & poNewEntity.REPAIR_ID & " sudah ada")
                    Exit Try
                End If

                lcCmd = "EXEC RPR0200 'INSERT"
                lcCmd = lcCmd & "','" & poNewEntity.REPAIR_ID
                lcCmd = lcCmd & "','" & poNewEntity.COMPANY_ID
                lcCmd = lcCmd & "','" & poNewEntity.COMPANY_OFFICE_ID
                lcCmd = lcCmd & "','" & Format(poNewEntity.FROM_DATE, "yyyyMMdd")
                lcCmd = lcCmd & "','" & Format(poNewEntity.TO_DATE, "yyyyMMdd")
                lcCmd = lcCmd & "','" & poNewEntity.BARCODE
                lcCmd = lcCmd & "','" & poNewEntity.OUTLET_ID
                lcCmd = lcCmd & "','" & poNewEntity.CREA_BY
                lcCmd = lcCmd & "','" & poNewEntity.UPD_BY & "'"

                loDb.SqlExecNonQuery(lcCmd, loConn, False)

                For Each row In poNewEntity.REPAIR_DETAIL
                    lcCmd = "EXEC RPR0210 'INSERT"
                    lcCmd = lcCmd & "','" & poNewEntity.REPAIR_ID
                    lcCmd = lcCmd & "','" & row.KD_PART
                    lcCmd = lcCmd & "'," & row.QTY_PART
                    lcCmd = lcCmd & "," & CLng(row.HARGA_PART)
                    lcCmd = lcCmd & ",'" & poNewEntity.CREA_BY
                    lcCmd = lcCmd & "','" & poNewEntity.UPD_BY & "'"

                    loDb.SqlExecNonQuery(lcCmd, loConn, False)

                    'Update sparepart yang digunakan

                    lcCmd = "UPDATE M_SPAREPART "
                    lcCmd = lcCmd & "SET STOCK_PART = STOCK_PART - " & row.QTY_PART & " "
                    lcCmd = lcCmd & "WHERE COMPANY_OFFICE_ID ='" & poNewEntity.COMPANY_OFFICE_ID & "' "
                    lcCmd = lcCmd & "AND KD_PART = '" & row.KD_PART & "'"

                    loDb.SqlExecNonQuery(lcCmd, loConn, False)

                    'Update sparepart_log

                    lcCmd = "EXEC RPR0110 '" & poNewEntity.COMPANY_OFFICE_ID
                    lcCmd = lcCmd & "','" & row.KD_PART
                    lcCmd = lcCmd & "'," & CLng(row.HARGA_PART)
                    lcCmd = lcCmd & ",'" & poNewEntity.REPAIR_ID
                    lcCmd = lcCmd & "','" & poNewEntity.CREA_BY
                    lcCmd = lcCmd & "','" & poNewEntity.UPD_BY & "'"

                    loDb.SqlExecNonQuery(lcCmd, loConn, True)

                Next

            Else

                lcCmd = "EXEC RPR0200 'UPDATE"
                lcCmd = lcCmd & "','" & poNewEntity.REPAIR_ID
                lcCmd = lcCmd & "','" & poNewEntity.COMPANY_ID
                lcCmd = lcCmd & "','" & poNewEntity.COMPANY_OFFICE_ID
                lcCmd = lcCmd & "','" & Format(poNewEntity.FROM_DATE, "yyyyMMdd")
                lcCmd = lcCmd & "','" & Format(poNewEntity.TO_DATE, "yyyyMMdd")
                lcCmd = lcCmd & "','" & poNewEntity.BARCODE
                lcCmd = lcCmd & "','" & poNewEntity.OUTLET_ID
                lcCmd = lcCmd & "','" & poNewEntity.CREA_BY
                lcCmd = lcCmd & "','" & poNewEntity.UPD_BY & "'"

                loDb.SqlExecNonQuery(lcCmd, loConn, False)

                If poNewEntity.REPAIR_DETAIL IsNot Nothing Then
                    If poNewEntity.REPAIR_DETAIL.Count <> 0 Then

                        lcCmd = "SELECT [REPAIR_ID]"
                        lcCmd = lcCmd & ",[KD_PART]"
                        lcCmd = lcCmd & ",[QTY_PART]"
                        lcCmd = lcCmd & ",[HARGA_PART]"
                        lcCmd = lcCmd & ",[CREA_BY]"
                        lcCmd = lcCmd & ",[CREA_DATE]"
                        lcCmd = lcCmd & ",[UPD_BY]"
                        lcCmd = lcCmd & ",[UPD_DATE] "
                        lcCmd = lcCmd & "INTO #TEMP_DETAIL "
                        lcCmd = lcCmd & "FROM [SIMARC].[dbo].[T_REPAIR_DETAIL] (NOLOCK)"

                        loDb.SqlExecQuery(lcCmd, loConn, False)

                        For Each row In poNewEntity.REPAIR_DETAIL
                            lcCmd = "INSERT INTO #TEMP_DETAIL ("
                            lcCmd = lcCmd & "REPAIR_ID,"
                            lcCmd = lcCmd & "KD_PART,"
                            lcCmd = lcCmd & "HARGA_PART,"
                            lcCmd = lcCmd & "CREA_BY,"
                            lcCmd = lcCmd & "CREA_DATE,"
                            lcCmd = lcCmd & "UPD_BY,"
                            lcCmd = lcCmd & "UPD_DATE) "
                            lcCmd = lcCmd & " VALUES ("
                            lcCmd = lcCmd & "'" & poNewEntity.REPAIR_ID & "'"
                            lcCmd = lcCmd & ",'" & row.KD_PART & ""
                            lcCmd = lcCmd & "," & CLng(row.HARGA_PART) & ""
                            lcCmd = lcCmd & ",'" & poNewEntity.CREA_BY.Trim & "'"
                            lcCmd = lcCmd & ", getdate() "
                            lcCmd = lcCmd & ",'" & poNewEntity.UPD_BY.Trim & "'"
                            lcCmd = lcCmd & ", getdate())"

                            loDb.SqlExecNonQuery(lcCmd, loConn, False)
                        Next

                        lcCmd = "MERGE T_REPAIR_DETAIL AS TARGET "
                        lcCmd = lcCmd & "USING #TEMP_DETAIL AS SOURCE "
                        lcCmd = lcCmd & "ON TARGET.REPAIR_ID = SOURCE.REPAIR_ID "
                        lcCmd = lcCmd & "AND TARGET.KD_PART = SOURCE.KD_PART "
                        lcCmd = lcCmd & "WHEN MATCHED THEN "
                        lcCmd = lcCmd & "UPDATE SET "
                        lcCmd = lcCmd & "TARGET.QTY_PART = SOURCE.QTY_PART, "
                        lcCmd = lcCmd & "TARGET.HARGA_PART = SOURCE.HARGA_PART, "
                        lcCmd = lcCmd & "TARGET.UPD_BY = SOURCE.UPD_BY, "
                        lcCmd = lcCmd & "TARGET.UPD_DATE = SOURCE.UPD_DATE "
                        lcCmd = lcCmd & "WHEN NOT MATCHED BY TARGET THEN "
                        lcCmd = lcCmd & "INSERT ("
                        lcCmd = lcCmd & "REPAIR_ID,"
                        lcCmd = lcCmd & "KD_PART,"
                        lcCmd = lcCmd & "QTY_PART,"
                        lcCmd = lcCmd & "HARGA_PART,"
                        lcCmd = lcCmd & "CREA_BY,"
                        lcCmd = lcCmd & "CREA_DATE,"
                        lcCmd = lcCmd & "UPD_BY,"
                        lcCmd = lcCmd & "UPD_DATE "
                        lcCmd = lcCmd & ") VALUES ( "
                        lcCmd = lcCmd & "SOURCE.REPAIR_ID,"
                        lcCmd = lcCmd & "SOURCE.KD_PART,"
                        lcCmd = lcCmd & "SOURCE.QTY_PART,"
                        lcCmd = lcCmd & "SOURCE.HARGA_PART,"
                        lcCmd = lcCmd & "SOURCE.CREA_BY,"
                        lcCmd = lcCmd & "GETDATE()"
                        lcCmd = lcCmd & "SOURCE.UPD_BY,"
                        lcCmd = lcCmd & "GETDATE()) "
                        lcCmd = lcCmd & "WHEN NOT MATCHED BY SOURCE AND TARGET.REPAIR_ID = " & poNewEntity.REPAIR_ID & "' "
                        lcCmd = lcCmd & "THEN DELETE;"

                        loDb.SqlExecQuery(lcCmd, loConn, False)
                    End If
                End If
            End If

            loConn.Close()

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Sub

    Function getCompany(poparam As List(Of Object)) As List(Of LKM_CompanyDTO)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As List(Of LKM_CompanyDTO)
        Dim loUser As String

        Try
            loUser = poparam.Item(0)

            lcCmd = "SELECT A.COMPANY_ID, A.COMPANY_NAME "
            lcCmd = lcCmd & "FROM M_COMPANY A (NOLOCK) "
            lcCmd = lcCmd & "JOIN SYS_USER B ON B.COMPANY_ID = A.COMPANY_ID "

            If loUser IsNot Nothing Then
                lcCmd = lcCmd & "WHERE B.USER_ID = '" & loUser & "'"
            End If

            loReturn = loDb.SQLExecObjectQuery(Of LKM_CompanyDTO)(lcCmd, loDb.GetConnection, True)

            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Function

    Function getList(poparam As List(Of Object)) As List(Of RPR0200DTO02)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As List(Of RPR0200DTO02)
        Dim limit As String
        Dim CompanyOffice As String
        Dim dari_tanggal As Date?
        Dim ke_tanggal As Date?

        Try
            With poparam
                limit = .Item(0)
                dari_tanggal = .Item(1)
                ke_tanggal = .Item(2)
                CompanyOffice = .Item(3)
            End With

            If limit IsNot Nothing Then
                lcCmd = "SELECT TOP " & limit & "A.[REPAIR_ID]"
            Else
                lcCmd = "SELECT A.[REPAIR_ID]"
            End If

            lcCmd = lcCmd & ",A.[COMPANY_ID]"
            lcCmd = lcCmd & ",A.[COMPANY_OFFICE_ID]"
            lcCmd = lcCmd & ",A.[FROM_DATE]"
            lcCmd = lcCmd & ",A.[TO_DATE]"
            lcCmd = lcCmd & ",A.[BARCODE]"
            lcCmd = lcCmd & ",A.[OUTLET_ID]"
            lcCmd = lcCmd & ",B.OUTLET_NAME"
            lcCmd = lcCmd & ",A.[CREA_BY]"
            lcCmd = lcCmd & ",A.[CREA_DATE]"
            lcCmd = lcCmd & ",A.[UPD_BY]"
            lcCmd = lcCmd & ",A.[UPD_DATE] "
            lcCmd = lcCmd & "FROM [SIMARC].[dbo].[T_REPAIR] A (NOLOCK) "
            lcCmd = lcCmd & "INNER JOIN M_OUTLET B ON A.OUTLET_ID = B.OUTLET_ID "
            lcCmd = lcCmd & "WHERE A.COMPANY_OFFICE_ID = '" & CompanyOffice & "'"

            If dari_tanggal IsNot Nothing Then
                lcCmd = lcCmd & "AND A.FROM_DATE BETWEEN '" & dari_tanggal.Value.ToString("yyyyMMdd") & "' "
                lcCmd = lcCmd & "AND '" & ke_tanggal.Value.ToString("yyyyMMdd") & "'"
            End If

            loReturn = loDb.SQLExecObjectQuery(Of RPR0200DTO02)(lcCmd, loDb.GetConnection, True)
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Function

    Function getList_Detail(poparam As RPR0200DTO01) As List(Of Repair_DetailDTO)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As List(Of Repair_DetailDTO)

        Try
            lcCmd = "SELECT A.[REPAIR_ID]"
            lcCmd = lcCmd & ",A.[KD_PART]"
            lcCmd = lcCmd & ",B.[NAMA_PART]"
            lcCmd = lcCmd & ",A.[QTY_PART]"
            lcCmd = lcCmd & ",A.[HARGA_PART]"
            lcCmd = lcCmd & ",B.[SATUAN_PART]"
            lcCmd = lcCmd & ",A.[CREA_BY]"
            lcCmd = lcCmd & ",A.[CREA_DATE]"
            lcCmd = lcCmd & ",A.[UPD_BY]"
            lcCmd = lcCmd & ",A.[UPD_DATE] "
            lcCmd = lcCmd & "FROM [SIMARC].[dbo].[T_REPAIR_DETAIL] A (NOLOCK) "
            lcCmd = lcCmd & "JOIN M_SPAREPART B ON A.KD_PART = B.KD_PART "

            If poparam.REPAIR_ID IsNot Nothing And poparam.REPAIR_ID <> "" Then
                lcCmd = lcCmd & "WHERE A.REPAIR_ID = '" & poparam.REPAIR_ID & "'"
            Else
                lcCmd = lcCmd & "WHERE A.REPAIR_ID = '" & poparam.REPAIR_ID & "'"
            End If

            loReturn = loDb.SQLExecObjectQuery(Of Repair_DetailDTO)(lcCmd, loDb.GetConnection, True)
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Function

    Function getOffice(poparam As List(Of Object)) As List(Of LKM_CompanyOfficeDTO)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As List(Of LKM_CompanyOfficeDTO)
        Dim loUser As String

        Try
            loUser = poparam.Item(0)

            lcCmd = "SELECT A.COMPANY_OFFICE_ID, A.COMPANY_OFFICE "
            lcCmd = lcCmd & "FROM M_COMPANY_OFFICE A (NOLOCK) "
            lcCmd = lcCmd & "JOIN M_COMPANY_OFFICE_MAP B (NOLOCK) ON A.COMPANY_OFFICE_ID = B.COMPANY_OFFICE_ID "
            lcCmd = lcCmd & "JOIN SYS_USER C (NOLOCK) ON B.COMPANY_OFFICE_MAP_ID = C.COMPANY_OFFICE_MAP_ID "

            If loUser IsNot Nothing Then
                lcCmd = lcCmd & "WHERE C.USER_ID = '" & loUser & "'"
            End If

            loReturn = loDb.SQLExecObjectQuery(Of LKM_CompanyOfficeDTO)(lcCmd, loDb.GetConnection, True)

            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Function

    Function getOutlet(poparam As List(Of Object)) As List(Of LKM_OutletDTO)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As List(Of LKM_OutletDTO)
        Dim loOutlet As String
        Dim loCompanyOffice As String

        Try
            loOutlet = poparam.Item(0)
            loCompanyOffice = poparam.Item(1)

            lcCmd = "SELECT OUTLET_ID, OUTLET_NAME FROM M_OUTLET (NOLOCK)"

            If loCompanyOffice IsNot Nothing Then
                lcCmd = lcCmd & " WHERE COMPANY_OFFICE_ID = '" & loCompanyOffice & "'"
            End If

            If loOutlet IsNot Nothing Then
                lcCmd = lcCmd & " AND OUTLET_ID = '" & loOutlet & "'"
            End If

            loReturn = loDb.SQLExecObjectQuery(Of LKM_OutletDTO)(lcCmd, loDb.GetConnection, True)
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Function

    Function getSparepart(KD_PART As String, CompanyOfficeID As String) As List(Of LKM_SparepartDTO)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As List(Of LKM_SparepartDTO)
        Dim loPart As String
        Dim loCompanyOffice As String

        Try
            loPart = KD_PART
            loCompanyOffice = CompanyOfficeID

            lcCmd = "SELECT [COMPANY_OFFICE_ID]"
            lcCmd = lcCmd & ",[KD_PART]"
            lcCmd = lcCmd & ",[NAMA_PART]"
            lcCmd = lcCmd & ",[HARGA_PART]"
            lcCmd = lcCmd & ",[STOCK_PART]"
            lcCmd = lcCmd & ",[SATUAN_PART] "
            lcCmd = lcCmd & "FROM [SIMARC].[dbo].[M_SPAREPART] (NOLOCK)"

            If loCompanyOffice IsNot Nothing Then
                lcCmd = lcCmd & " WHERE COMPANY_OFFICE_ID = '" & loCompanyOffice & "'"
            End If

            If loPart IsNot Nothing Then
                lcCmd = lcCmd & " AND KD_PART = " & loPart & " "
            End If

            loReturn = loDb.SQLExecObjectQuery(Of LKM_SparepartDTO)(lcCmd, loDb.GetConnection, True)
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Function

End Class
