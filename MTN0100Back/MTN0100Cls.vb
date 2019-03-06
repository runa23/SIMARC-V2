Imports SC_BackEnd
Imports SC_Common
Imports MTN0100Back
Imports System.Data.Common
Imports System.Data.SqlClient

Public Class MTN0100Cls
    Inherits SC_BusinessObject(Of MTN0100DTO01)

    Protected Overrides Sub SC_Deleting(poEntity As MTN0100DTO01)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loConn As DbConnection

        Try
            loConn = loDb.GetConnection

            lcCmd = "EXEC MTN0100 'DELETE"
            lcCmd = lcCmd & "','" & poEntity.MAINTENANCE_ID
            lcCmd = lcCmd & "','" & poEntity.COMPANY_ID
            lcCmd = lcCmd & "','" & poEntity.COMPANY_OFFICE_ID
            lcCmd = lcCmd & "','" & Format(poEntity.FROM_DATE, "yyyyMMdd")
            lcCmd = lcCmd & "','" & Format(poEntity.TO_DATE, "yyyyMMdd")
            lcCmd = lcCmd & "','" & poEntity.BARCODE
            lcCmd = lcCmd & "','" & poEntity.OUTLET_ID
            lcCmd = lcCmd & "','" & poEntity.CREA_BY.Trim
            lcCmd = lcCmd & "','" & poEntity.UPD_BY.Trim & "'"

            loDb.SqlExecNonQuery(lcCmd, loConn, False)

            lcCmd = "DELETE FROM T_MAINTENANCE_DETAIL WHERE MAINTENANCE_ID = '" & poEntity.MAINTENANCE_ID & "'"

            loDb.SqlExecNonQuery(lcCmd, loConn, True)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Protected Overrides Function SC_Display(poEntity As MTN0100DTO01, poCRUDMode As eCRUDMode, plWithLock As Boolean) As MTN0100DTO01
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As MTN0100DTO01

        Try
            lcCmd = "SELECT A.[MAINTENANCE_ID]"
            lcCmd = lcCmd & ",A.[COMPANY_ID]"
            lcCmd = lcCmd & ",A.[COMPANY_OFFICE_ID]"
            lcCmd = lcCmd & ",A.[FROM_DATE]"
            lcCmd = lcCmd & ",A.[TO_DATE]"
            lcCmd = lcCmd & ",A.[BARCODE]"
            lcCmd = lcCmd & ",B.[OUTLET_ID]"
            lcCmd = lcCmd & ",B.[OUTLET_NAME]"
            lcCmd = lcCmd & ",A.[CREA_BY]"
            lcCmd = lcCmd & ",A.[CREA_DATE]"
            lcCmd = lcCmd & ",A.[UPD_BY]"
            lcCmd = lcCmd & ",A.[UPD_DATE] "
            lcCmd = lcCmd & "FROM [SIMARC].[dbo].[T_MAINTENANCE] A (NOLOCK) "
            lcCmd = lcCmd & "INNER JOIN M_OUTLET B (NOLOCK) ON A.OUTLET_ID = B.OUTLET_ID"
            lcCmd = lcCmd & " WHERE A.MAINTENANCE_ID = '" & poEntity.MAINTENANCE_ID.Trim & "'"

            loReturn = loDb.SQLExecObjectQuery(Of MTN0100DTO01)(lcCmd, loDb.GetConnection, True).FirstOrDefault
            Return loReturn

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Function

    Protected Overrides Sub SC_Saving(poNewEntity As MTN0100DTO01, poOldEntity As MTN0100DTO01, poCRUDMode As eCRUDMode)
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
                Kode = "MTN" & Kode
                Kode = Kode & loHelper.SC_GenerateKey(Kode, 3, loConn)
                poNewEntity.MAINTENANCE_ID = Kode

                lcCmd = "SELECT A.[MAINTENANCE_ID]"
                lcCmd = lcCmd & ",A.[COMPANY_ID]"
                lcCmd = lcCmd & ",A.[COMPANY_OFFICE_ID]"
                lcCmd = lcCmd & ",A.[FROM_DATE]"
                lcCmd = lcCmd & ",A.[TO_DATE]"
                lcCmd = lcCmd & ",A.[BARCODE]"
                lcCmd = lcCmd & ",B.[OUTLET_ID]"
                lcCmd = lcCmd & ",B.[OUTLET_NAME]"
                lcCmd = lcCmd & ",A.[CREA_BY]"
                lcCmd = lcCmd & ",A.[CREA_DATE]"
                lcCmd = lcCmd & ",A.[UPD_BY]"
                lcCmd = lcCmd & ",A.[UPD_DATE] "
                lcCmd = lcCmd & "FROM [SIMARC].[dbo].[T_MAINTENANCE] A (NOLOCK) "
                lcCmd = lcCmd & "INNER JOIN M_OUTLET B (NOLOCK) ON A.OUTLET_ID = B.OUTLET_ID"
                lcCmd = lcCmd & " WHERE A.MAINTENANCE_ID = '" & poNewEntity.MAINTENANCE_ID.Trim & "'"

                If loDb.SqlExecQuery(lcCmd, loConn, False).Rows.Count > 0 Then
                    loException.Add("Validasi", "Data tidak dapat disimpan. Data Maintenance " & poNewEntity.MAINTENANCE_ID & " sudah ada")
                    Exit Try
                End If

                lcCmd = "EXEC MTN0100 'INSERT"
                lcCmd = lcCmd & "','" & poNewEntity.MAINTENANCE_ID
                lcCmd = lcCmd & "','" & poNewEntity.COMPANY_ID
                lcCmd = lcCmd & "','" & poNewEntity.COMPANY_OFFICE_ID
                lcCmd = lcCmd & "','" & Format(poNewEntity.FROM_DATE, "yyyyMMdd")
                lcCmd = lcCmd & "','" & Format(poNewEntity.TO_DATE, "yyyyMMdd")
                lcCmd = lcCmd & "','" & poNewEntity.BARCODE
                lcCmd = lcCmd & "','" & poNewEntity.OUTLET_ID
                lcCmd = lcCmd & "','" & poNewEntity.CREA_BY.Trim
                lcCmd = lcCmd & "','" & poNewEntity.UPD_BY.Trim & "'"

                loDb.SqlExecNonQuery(lcCmd, loConn, False)

                For Each row In poNewEntity.MAINTENANCE_DETAIL
                    lcCmd = "EXEC MTN0110 'INSERT"
                    lcCmd = lcCmd & "','" & poNewEntity.MAINTENANCE_ID
                    lcCmd = lcCmd & "'," & row.CASE_ID
                    lcCmd = lcCmd & "," & row.GOOD
                    lcCmd = lcCmd & "," & row.MINOR
                    lcCmd = lcCmd & "," & row.MAJOR
                    lcCmd = lcCmd & "," & row.DAMAGE
                    lcCmd = lcCmd & ",'" & poNewEntity.CREA_BY.Trim
                    lcCmd = lcCmd & "','" & poNewEntity.UPD_BY.Trim & "'"

                    loDb.SqlExecNonQuery(lcCmd, loConn, True)
                Next

            Else

                lcCmd = "EXEC MTN0100 'UPDATE"
                lcCmd = lcCmd & "','" & poNewEntity.MAINTENANCE_ID
                lcCmd = lcCmd & "','" & poNewEntity.COMPANY_ID
                lcCmd = lcCmd & "','" & poNewEntity.COMPANY_OFFICE_ID
                lcCmd = lcCmd & "','" & Format(poNewEntity.FROM_DATE, "yyyyMMdd")
                lcCmd = lcCmd & "','" & Format(poNewEntity.TO_DATE, "yyyyMMdd")
                lcCmd = lcCmd & "','" & poNewEntity.BARCODE
                lcCmd = lcCmd & "','" & poNewEntity.OUTLET_ID
                lcCmd = lcCmd & "','" & poNewEntity.CREA_BY.Trim
                lcCmd = lcCmd & "','" & poNewEntity.UPD_BY.Trim & "'"

                loDb.SqlExecNonQuery(lcCmd, loConn, False)

                If poNewEntity.MAINTENANCE_DETAIL IsNot Nothing Then
                    If poNewEntity.MAINTENANCE_DETAIL.Count <> 0 Then

                        lcCmd = "SELECT MAINTENANCE_ID,"
                        lcCmd = lcCmd & "CASE_ID,"
                        lcCmd = lcCmd & "GOOD,"
                        lcCmd = lcCmd & "MINOR,"
                        lcCmd = lcCmd & "MAJOR,"
                        lcCmd = lcCmd & "DAMAGE,"
                        lcCmd = lcCmd & "CREA_BY,"
                        lcCmd = lcCmd & "CREA_DATE,"
                        lcCmd = lcCmd & "UPD_BY,"
                        lcCmd = lcCmd & "UPD_DATE "
                        lcCmd = lcCmd & "INTO #TEMP_DETAIL "
                        lcCmd = lcCmd & "FROM T_MAINTENANCE_DETAIL (NOLOCK) WHERE 0 = 1 "
                        loDb.SqlExecQuery(lcCmd, loConn, False)

                        For Each row In poNewEntity.MAINTENANCE_DETAIL
                            lcCmd = "INSERT INTO #TEMP_DETAIL ("
                            lcCmd = lcCmd & "MAINTENANCE_ID,"
                            lcCmd = lcCmd & "CASE_ID,"
                            lcCmd = lcCmd & "GOOD,"
                            lcCmd = lcCmd & "MINOR,"
                            lcCmd = lcCmd & "MAJOR,"
                            lcCmd = lcCmd & "DAMAGE,"
                            lcCmd = lcCmd & "CREA_BY,"
                            lcCmd = lcCmd & "CREA_DATE,"
                            lcCmd = lcCmd & "UPD_BY,"
                            lcCmd = lcCmd & "UPD_DATE) "
                            lcCmd = lcCmd & "VALUES ("
                            lcCmd = lcCmd & "'" & poNewEntity.MAINTENANCE_ID & "'"
                            lcCmd = lcCmd & "," & row.CASE_ID & ""
                            lcCmd = lcCmd & ",'" & row.GOOD & "'"
                            lcCmd = lcCmd & ",'" & row.MINOR & "'"
                            lcCmd = lcCmd & ",'" & row.MAJOR & "'"
                            lcCmd = lcCmd & ",'" & row.DAMAGE & "'"
                            lcCmd = lcCmd & ",'" & poNewEntity.CREA_BY.Trim & "'"
                            lcCmd = lcCmd & ", getdate() "
                            lcCmd = lcCmd & ",'" & poNewEntity.UPD_BY.Trim & "'"
                            lcCmd = lcCmd & ", getdate())"
                            loDb.SqlExecNonQuery(lcCmd, loConn, False)
                        Next

                        lcCmd = "MERGE T_MAINTENANCE_DETAIL AS TARGET "
                        lcCmd = lcCmd & "USING #TEMP_DETAIL AS SOURCE "
                        lcCmd = lcCmd & "ON TARGET.MAINTENANCE_ID = SOURCE.MAINTENANCE_ID "
                        lcCmd = lcCmd & "AND TARGET.CASE_ID = SOURCE.CASE_ID "
                        lcCmd = lcCmd & "WHEN MATCHED THEN "
                        lcCmd = lcCmd & "UPDATE SET "
                        lcCmd = lcCmd & "TARGET.GOOD = SOURCE.GOOD, "
                        lcCmd = lcCmd & "TARGET.MINOR = SOURCE.MINOR, "
                        lcCmd = lcCmd & "TARGET.MAJOR = SOURCE.MAJOR, "
                        lcCmd = lcCmd & "TARGET.DAMAGE = SOURCE.DAMAGE, "
                        lcCmd = lcCmd & "TARGET.UPD_BY = SOURCE.UPD_BY, "
                        lcCmd = lcCmd & "TARGET.UPD_DATE = SOURCE.UPD_DATE "
                        lcCmd = lcCmd & "WHEN NOT MATCHED BY TARGET THEN "
                        lcCmd = lcCmd & "INSERT ("
                        lcCmd = lcCmd & "MAINTENANCE_ID,"
                        lcCmd = lcCmd & "CASE_ID,"
                        lcCmd = lcCmd & "GOOD,"
                        lcCmd = lcCmd & "MINOR,"
                        lcCmd = lcCmd & "MAJOR,"
                        lcCmd = lcCmd & "DAMAGE,"
                        lcCmd = lcCmd & "CREA_BY,"
                        lcCmd = lcCmd & "CREA_DATE,"
                        lcCmd = lcCmd & "UPD_BY,"
                        lcCmd = lcCmd & "UPD_DATE "
                        lcCmd = lcCmd & ") VALUES ( "
                        lcCmd = lcCmd & "SOURCE.MAINTENANCE_ID,"
                        lcCmd = lcCmd & "SOURCE.CASE_ID,"
                        lcCmd = lcCmd & "SOURCE.GOOD,"
                        lcCmd = lcCmd & "SOURCE.MINOR,"
                        lcCmd = lcCmd & "SOURCE.MAJOR,"
                        lcCmd = lcCmd & "SOURCE.DAMAGE,"
                        lcCmd = lcCmd & "SOURCE.CREA_BY,"
                        lcCmd = lcCmd & "GETDATE(),"
                        lcCmd = lcCmd & "SOURCE.UPD_BY,"
                        lcCmd = lcCmd & "GETDATE()) "
                        lcCmd = lcCmd & "WHEN NOT MATCHED BY SOURCE AND TARGET.MAINTENANCE_ID = '" & poNewEntity.MAINTENANCE_ID & "' "
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

    Function getCompany(poParam As List(Of Object)) As List(Of LKM_CompanyDTO)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As List(Of LKM_CompanyDTO)
        Dim loUser As String

        Try
            loUser = poParam.Item(0)

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

    Function getList(poParam As List(Of Object)) As List(Of MTN0100DTO02)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As List(Of MTN0100DTO02)
        Dim limit As String
        Dim CompanyOffice As String
        Dim dari_tanggal As Date?
        Dim ke_tanggal As Date?

        Try

            With poParam
                limit = .Item(0)
                dari_tanggal = .Item(1)
                ke_tanggal = .Item(2)
                CompanyOffice = .Item(3)
            End With

            If limit IsNot Nothing Then
                lcCmd = "SELECT TOP " & limit & "A.[MAINTENANCE_ID]"
            Else
                lcCmd = "SELECT A.[MAINTENANCE_ID]"
            End If

            lcCmd = lcCmd & ",A.[COMPANY_ID]"
            lcCmd = lcCmd & ",A.[COMPANY_OFFICE_ID]"
            lcCmd = lcCmd & ",A.[FROM_DATE]"
            lcCmd = lcCmd & ",A.[TO_DATE]"
            lcCmd = lcCmd & ",A.[BARCODE]"
            lcCmd = lcCmd & ",B.[OUTLET_ID]"
            lcCmd = lcCmd & ",B.[OUTLET_NAME]"
            lcCmd = lcCmd & ",A.[CREA_BY]"
            lcCmd = lcCmd & ",A.[CREA_DATE]"
            lcCmd = lcCmd & ",A.[UPD_BY]"
            lcCmd = lcCmd & ",A.[UPD_DATE] "
            lcCmd = lcCmd & "FROM [SIMARC].[dbo].[T_MAINTENANCE] A (NOLOCK) "
            lcCmd = lcCmd & "INNER JOIN M_OUTLET B (NOLOCK) ON A.OUTLET_ID = B.OUTLET_ID "
            lcCmd = lcCmd & "WHERE A.COMPANY_OFFICE_ID = '" & CompanyOffice & "'"

            If dari_tanggal IsNot Nothing Then
                lcCmd = lcCmd & "AND A.FROM_DATE BETWEEN '" & dari_tanggal.Value.ToString("yyyyMMdd") & "' "
                lcCmd = lcCmd & "AND '" & ke_tanggal.Value.ToString("yyyyMMdd") & "'"
            End If

            loReturn = loDb.SQLExecObjectQuery(Of MTN0100DTO02)(lcCmd, loDb.GetConnection, True)
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Function

    Function getList_Detail(poParam As MTN0100DTO01) As List(Of Maintenance_DetailDTO)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As List(Of Maintenance_DetailDTO)

        Try

            lcCmd = "SELECT MAINTENANCE_ID = ISNULL(A.[MAINTENANCE_ID], '')"
            lcCmd = lcCmd & ",CASE_ID = ISNULL(B.[CASE_ID],'')"
            lcCmd = lcCmd & ",CASE_NAME = ISNULL(B.[CASE_NAME],'')"
            lcCmd = lcCmd & ",GOOD = ISNULL(A.[GOOD],'')"
            lcCmd = lcCmd & ",MINOR = ISNULL(A.[MINOR],'')"
            lcCmd = lcCmd & ",MAJOR = ISNULL(A.[MAJOR],'')"
            lcCmd = lcCmd & ",DAMAGE = ISNULL(A.[DAMAGE],'')"
            lcCmd = lcCmd & ",CREA_BY = ISNULL(A.[CREA_BY],'')"
            lcCmd = lcCmd & ",CREA_DATE = ISNULL(A.[CREA_DATE],'')"
            lcCmd = lcCmd & ",UPD_BY = ISNULL(A.[UPD_BY],'')"
            lcCmd = lcCmd & ",UPD_DATE = ISNULL(A.[UPD_DATE],'')"
            lcCmd = lcCmd & " FROM [SIMARC].[dbo].[T_MAINTENANCE_DETAIL] A(NOLOCK)"
            lcCmd = lcCmd & " RIGHT JOIN M_CASE B ON A.CASE_ID = B.CASE_ID "

            If poParam.MAINTENANCE_ID IsNot Nothing And poParam.MAINTENANCE_ID <> "" Then
                lcCmd = lcCmd & "WHERE A.MAINTENANCE_ID = '" & poParam.MAINTENANCE_ID & "'"
            Else
                lcCmd = lcCmd & "WHERE A.MAINTENANCE_ID = '" & poParam.MAINTENANCE_ID & "'"
            End If

            loReturn = loDb.SQLExecObjectQuery(Of Maintenance_DetailDTO)(lcCmd, loDb.GetConnection, True)
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Function

    Function getOffice(poParam As List(Of Object)) As List(Of LKM_CompanyOfficeDTO)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As List(Of LKM_CompanyOfficeDTO)
        Dim loUser As String

        Try
            loUser = poParam.Item(0)

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

    Function getOutlet(poParam As List(Of Object)) As List(Of LKM_OutletDTO)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As List(Of LKM_OutletDTO)
        Dim loOutlet As String
        Dim loCompanyOffice As String

        Try
            loOutlet = poParam.Item(0)
            loCompanyOffice = poParam.Item(1)

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

End Class
