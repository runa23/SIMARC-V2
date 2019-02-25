Imports SC_BackEnd
Imports SC_Common
Imports RPR0200Back
Imports System.Data.Common
Imports System.Data.SqlClient

Public Class RPR0200Cls
    Inherits SC_BusinessObject(Of RPR0200DTO01)

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
            lcCmd = lcCmd & ",A.[QTY_PART]"
            lcCmd = lcCmd & ",A.[HARGA_PART]"
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

        Try
            loOutlet = poparam.Item(0)

            lcCmd = "SELECT OUTLET_ID, OUTLET_NAME FROM M_OUTLET (NOLOCK)"

            If loOutlet IsNot Nothing Then
                lcCmd = lcCmd & " WHERE OUTLET_ID = '" & loOutlet & "'"
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

    Protected Overrides Sub SC_Deleting(poEntity As RPR0200DTO01)

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

    End Sub
End Class
