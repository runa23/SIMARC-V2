Imports SC_BackEnd
Imports SC_Common
Imports SYS0500Back
Imports System.Data.Common
Imports System.Data.SqlClient
Public Class SYS0500Cls
    Inherits SC_BusinessObject(Of SYS0500DTO01)
    Protected Overrides Sub SC_Deleting(poEntity As SYS0500DTO01)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loConn As DbConnection

        Try
            loConn = loDb.GetConnection

            lcCmd = "EXEC SYS0500 'DELETE"
            lcCmd = lcCmd & "','" & poEntity.USER_ID
            lcCmd = lcCmd & "','" & poEntity.PASSWORD
            lcCmd = lcCmd & "','" & poEntity.REGIONAL
            lcCmd = lcCmd & "','" & poEntity.COMPANY_ID
            lcCmd = lcCmd & "','" & poEntity.COMPANY_OFFICE_ID
            lcCmd = lcCmd & "','" & poEntity.COMPANY_OFFICE_MAP_ID
            lcCmd = lcCmd & "','" & poEntity.VALID_FROM.ToString("yyyyMMdd")
            lcCmd = lcCmd & "','" & poEntity.VALID_TO.ToString("yyyyMMdd")
            lcCmd = lcCmd & "','" & poEntity.DEFAULT_APP
            lcCmd = lcCmd & "','" & poEntity.CREA_BY.Trim
            lcCmd = lcCmd & "','" & poEntity.UPD_BY.Trim & "'"

            loDb.SqlExecNonQuery(lcCmd, loConn, True)

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Protected Overrides Function SC_Display(poEntity As SYS0500DTO01, poCRUDMode As eCRUDMode, plWithLock As Boolean) As SYS0500DTO01
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As SYS0500DTO01

        Try
            lcCmd = "SELECT [USER_ID]"
            lcCmd = lcCmd & ",[REGIONAL]"
            lcCmd = lcCmd & ",[COMPANY_ID]"
            lcCmd = lcCmd & ",[COMPANY_OFFICE_ID]"
            lcCmd = lcCmd & ",[COMPANY_OFFICE_MAP_ID]"
            lcCmd = lcCmd & ",[VALID_FROM]"
            lcCmd = lcCmd & ",[VALID_TO]"
            lcCmd = lcCmd & ",[DEFAULT_APP]"
            lcCmd = lcCmd & ",[CREA_BY]"
            lcCmd = lcCmd & ",[CREA_DATE]"
            lcCmd = lcCmd & ",[UPD_BY]"
            lcCmd = lcCmd & ",[UPD_DATE]"
            lcCmd = lcCmd & " FROM [SIMARC].[dbo].[SYS_USER] (NOLOCK)"
            lcCmd = lcCmd & " WHERE USER_ID = '" & poEntity.USER_ID & "'"

            loReturn = loDb.SQLExecObjectQuery(Of SYS0500DTO01)(lcCmd, loDb.GetConnection, True).FirstOrDefault
            Return loReturn

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Function

    Protected Overrides Sub SC_Saving(poNewEntity As SYS0500DTO01, poOldEntity As SYS0500DTO01, poCRUDMode As eCRUDMode)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loConn As DbConnection

        Try
            loConn = loDb.GetConnection

            If poCRUDMode = eCRUDMode.AddMode Then
                lcCmd = "SELECT [USER_ID]"
                lcCmd = lcCmd & ",[REGIONAL]"
                lcCmd = lcCmd & ",[COMPANY_ID]"
                lcCmd = lcCmd & ",[COMPANY_OFFICE_ID]"
                lcCmd = lcCmd & ",[COMPANY_OFFICE_MAP_ID]"
                lcCmd = lcCmd & ",[VALID_FROM]"
                lcCmd = lcCmd & ",[VALID_TO]"
                lcCmd = lcCmd & ",[DEFAULT_APP]"
                lcCmd = lcCmd & ",[CREA_BY]"
                lcCmd = lcCmd & ",[CREA_DATE]"
                lcCmd = lcCmd & ",[UPD_BY]"
                lcCmd = lcCmd & ",[UPD_DATE]"
                lcCmd = lcCmd & " FROM [SIMARC].[dbo].[SYS_USER] (NOLOCK)"
                lcCmd = lcCmd & " WHERE USER_ID = '" & poNewEntity.USER_ID & "'"

                If loDb.SqlExecQuery(lcCmd, loConn, False).Rows.Count > 0 Then
                    loException.Add("Validasi", "Data tidak dapat disimpan. Data User " & poNewEntity.USER_ID & " sudah ada")
                    Exit Try
                End If

                lcCmd = "EXEC SYS0500 'INSERT"
                lcCmd = lcCmd & "','" & poNewEntity.USER_ID
                lcCmd = lcCmd & "','" & SC_Utility.Encrypt(poNewEntity.USER_ID.Trim, poNewEntity.PASSWORD.Trim)
                lcCmd = lcCmd & "','" & poNewEntity.REGIONAL
                lcCmd = lcCmd & "','" & poNewEntity.COMPANY_ID
                lcCmd = lcCmd & "','" & poNewEntity.COMPANY_OFFICE_ID
                lcCmd = lcCmd & "','" & poNewEntity.COMPANY_OFFICE_MAP_ID
                lcCmd = lcCmd & "','" & poNewEntity.VALID_FROM.ToString("yyyyMMdd")
                lcCmd = lcCmd & "','" & poNewEntity.VALID_TO.ToString("yyyyMMdd")
                lcCmd = lcCmd & "','" & poNewEntity.DEFAULT_APP
                lcCmd = lcCmd & "','" & poNewEntity.CREA_BY.Trim
                lcCmd = lcCmd & "','" & poNewEntity.UPD_BY.Trim & "'"

            Else

                lcCmd = "UPDATE SYS_USER SET "
                lcCmd = lcCmd & "REGIONAL = '" & poNewEntity.REGIONAL.Trim & "',"
                lcCmd = lcCmd & "COMPANY_ID = '" & poNewEntity.COMPANY_ID.Trim & "',"
                lcCmd = lcCmd & "COMPANY_OFFICE_ID = '" & poNewEntity.COMPANY_OFFICE_ID.Trim & "',"
                lcCmd = lcCmd & "COMPANY_OFFICE_MAP_ID = '" & poNewEntity.COMPANY_OFFICE_MAP_ID.Trim & "',"
                lcCmd = lcCmd & "VALID_FROM = '" & poNewEntity.VALID_FROM.ToString("yyyyMMdd") & "',"
                lcCmd = lcCmd & "VALID_TO = '" & poNewEntity.VALID_TO.ToString("yyyyMMdd") & "'"

                If poNewEntity.INPUT_PASS = True Then
                    lcCmd = lcCmd & ",PASSWORD = '" & SC_Utility.Encrypt(poNewEntity.USER_ID.Trim, poNewEntity.PASSWORD.Trim) & "'"
                End If

                lcCmd = lcCmd & " WHERE USER_ID = '" & poNewEntity.USER_ID & "'"

            End If

            loDb.SqlExecNonQuery(lcCmd, loConn, True)

            loConn.Close()
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Sub

    Function getRegional() As List(Of LKM_RegionalDTO)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As List(Of LKM_RegionalDTO)

        Try
            lcCmd = "SELECT REGIONAL_ID,"
            lcCmd = lcCmd & "REGIONAL_NAME"
            lcCmd = lcCmd & " FROM M_REGIONAL (NOLOCK)"

            loReturn = loDb.SQLExecObjectQuery(Of LKM_RegionalDTO)(lcCmd, loDb.GetConnection, True)
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Function

    Function getCompany(poparam As List(Of Object)) As List(Of LKM_CompanyDTO)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As List(Of LKM_CompanyDTO)
        Dim loRegional As String

        Try

            loRegional = poparam.Item(0)

            lcCmd = "SELECT COMPANY_ID,"
            lcCmd = lcCmd & "COMPANY_NAME"
            lcCmd = lcCmd & " FROM M_COMPANY (NOLOCK)"

            'If loRegional Is Nothing Then
            '    lcCmd = lcCmd & " WHERE REGIONAL_ID = ''"
            'Else
            If loRegional IsNot Nothing Then
                lcCmd = lcCmd & " WHERE REGIONAL_ID = '" & loRegional & "'"
            End If

            loReturn = loDb.SQLExecObjectQuery(Of LKM_CompanyDTO)(lcCmd, loDb.GetConnection, True)
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Function

    Function getCompanyOffice(poparam As List(Of Object)) As List(Of LKM_CompanyOfficeDTO)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As List(Of LKM_CompanyOfficeDTO)
        Dim loCompany As String

        Try

            loCompany = poparam.Item(0)

            lcCmd = "SELECT COMPANY_OFFICE_ID,"
            lcCmd = lcCmd & "COMPANY_OFFICE"
            lcCmd = lcCmd & " FROM M_COMPANY_OFFICE (NOLOCK)"

            'If loCompany Is Nothing Then
            '    lcCmd = lcCmd & " WHERE COMPANY_ID = ''"
            'Else
            If loCompany IsNot Nothing Then
                lcCmd = lcCmd & " WHERE COMPANY_ID = '" & loCompany & "'"
            End If

            loReturn = loDb.SQLExecObjectQuery(Of LKM_CompanyOfficeDTO)(lcCmd, loDb.GetConnection, True)
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Function

    Function getCompanyOfficeMap(poparam As List(Of Object)) As List(Of LKM_Company_Office_MapDTO)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As List(Of LKM_Company_Office_MapDTO)
        Dim loRegional As String
        Dim loCompanyOffice As String

        Try
            loRegional = poparam.Item(0)
            loCompanyOffice = poparam.Item(1)

            lcCmd = "SELECT DISTINCT COMPANY_OFFICE_MAP_ID FROM M_COMPANY_OFFICE_MAP"

            'If loRegional Is Nothing Or loCompanyOffice Is Nothing Then
            '    lcCmd = lcCmd & " WHERE REGIONAL_ID = ''"
            '    lcCmd = lcCmd & " AND COMPANY_OFFICE_ID = ''"
            'Else
            If loRegional IsNot Nothing Or loCompanyOffice IsNot Nothing Then
                lcCmd = lcCmd & " WHERE REGIONAL_ID = '" & loRegional & "'"
                lcCmd = lcCmd & " AND COMPANY_OFFICE_ID = '" & loCompanyOffice & "'"
            End If

            loReturn = loDb.SQLExecObjectQuery(Of LKM_Company_Office_MapDTO)(lcCmd, loDb.GetConnection, True)
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Function

    Function getList() As List(Of SYS0500DTO02)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As List(Of SYS0500DTO02)

        Try
            lcCmd = "SELECT [USER_ID]"
            'lcCmd = lcCmd & ",[PASSWORD]"
            lcCmd = lcCmd & ",[REGIONAL]"
            lcCmd = lcCmd & ",[COMPANY_ID]"
            lcCmd = lcCmd & ",[COMPANY_OFFICE_ID]"
            lcCmd = lcCmd & ",[COMPANY_OFFICE_MAP_ID]"
            lcCmd = lcCmd & ",[VALID_FROM]"
            lcCmd = lcCmd & ",[VALID_TO]"
            lcCmd = lcCmd & ",[DEFAULT_APP]"
            lcCmd = lcCmd & ",[CREA_BY]"
            lcCmd = lcCmd & ",[CREA_DATE]"
            lcCmd = lcCmd & ",[UPD_BY]"
            lcCmd = lcCmd & ",[UPD_DATE]"
            lcCmd = lcCmd & " FROM [SIMARC].[dbo].[SYS_USER] (NOLOCK)"

            loReturn = loDb.SQLExecObjectQuery(Of SYS0500DTO02)(lcCmd, loDb.GetConnection, True)
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Function


End Class
