Imports SC_BackEnd
Imports SC_Common
Imports RPR0100Back
Imports System.Data.Common
Imports System.Data.SqlClient

Public Class RPR0100Cls
    Inherits SC_BusinessObject(Of RPR0100DTO01)

    Function getList() As List(Of RPR0100DTO02)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As List(Of RPR0100DTO02)

        Try
            lcCmd = "SELECT [KD_PART]"
            lcCmd = lcCmd & ",[NAMA_PART]"
            lcCmd = lcCmd & ",[HARGA_PART]"
            lcCmd = lcCmd & ",[STOCK_PART]"
            lcCmd = lcCmd & ",[SATUAN_PART]"
            lcCmd = lcCmd & ",[CREA_BY]"
            lcCmd = lcCmd & ",[CREA_DATE]"
            lcCmd = lcCmd & ",[UPD_BY]"
            lcCmd = lcCmd & ",[UPD_DATE] "
            lcCmd = lcCmd & "FROM [dbo].[M_SPAREPART] (NOLOCK)"

            loReturn = loDb.SQLExecObjectQuery(Of RPR0100DTO02)(lcCmd, loDb.GetConnection, True)
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Function

    Protected Overrides Sub SC_Deleting(poEntity As RPR0100DTO01)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loConn As DbConnection

        Try
            loConn = loDb.GetConnection

            lcCmd = "EXEC RPR0100 'DELETE"
            lcCmd = lcCmd & "'," & poEntity.KD_PART
            lcCmd = lcCmd & ",'" & poEntity.NAMA_PART
            lcCmd = lcCmd & "'," & poEntity.HARGA_PART
            lcCmd = lcCmd & "," & poEntity.STOCK_PART
            lcCmd = lcCmd & ",'" & poEntity.SATUAN_PART
            lcCmd = lcCmd & "','" & poEntity.CREA_BY.Trim
            lcCmd = lcCmd & "','" & poEntity.UPD_BY.Trim & "'"

            loDb.SqlExecNonQuery(lcCmd, loConn, True)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Protected Overrides Function SC_Display(poEntity As RPR0100DTO01, poCRUDMode As eCRUDMode, plWithLock As Boolean) As RPR0100DTO01
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As RPR0100DTO01

        Try
            lcCmd = "SELECT [KD_PART]"
            lcCmd = lcCmd & ",[NAMA_PART]"
            lcCmd = lcCmd & ",[HARGA_PART]"
            lcCmd = lcCmd & ",[STOCK_PART]"
            lcCmd = lcCmd & ",[SATUAN_PART]"
            lcCmd = lcCmd & ",[CREA_BY]"
            lcCmd = lcCmd & ",[CREA_DATE]"
            lcCmd = lcCmd & ",[UPD_BY]"
            lcCmd = lcCmd & ",[UPD_DATE] "
            lcCmd = lcCmd & "FROM [dbo].[M_SPAREPART] (NOLOCK) "
            lcCmd = lcCmd & "WHERE KD_PART = " & poEntity.KD_PART & " "

            loReturn = loDb.SQLExecObjectQuery(Of RPR0100DTO01)(lcCmd, loDb.GetConnection, True).FirstOrDefault
            Return loReturn

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Function

    Protected Overrides Sub SC_Saving(poNewEntity As RPR0100DTO01, poOldEntity As RPR0100DTO01, poCRUDMode As eCRUDMode)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loConn As DbConnection
        Dim Kode As Integer
        Dim loKode As DataTable

        Try
            loConn = loDb.GetConnection

            If poCRUDMode = eCRUDMode.AddMode Then

                lcCmd = "SELECT ISNULL(MAX(KD_PART),0) as KODE FROM M_SPAREPART"
                loKode = loDb.SqlExecQuery(lcCmd, loConn, False)
                Kode = loKode.Rows.Item(0)(0) + 1

                lcCmd = "SELECT * FROM M_SPAREPART WHERE KD_PART = " & Kode & " "
                If loDb.SqlExecQuery(lcCmd, loConn, False).Rows.Count > 0 Then
                    loException.Add("Validasi", "Data tidak dapat disimpan. Kode Spare Part " & Kode & " sudah ada")
                    Exit Try
                End If

                poNewEntity.KD_PART = Kode

                lcCmd = "EXEC RPR0100 'INSERT"
                lcCmd = lcCmd & "'," & poNewEntity.KD_PART
                lcCmd = lcCmd & ",'" & poNewEntity.NAMA_PART
                lcCmd = lcCmd & "'," & poNewEntity.HARGA_PART
                lcCmd = lcCmd & "," & poNewEntity.STOCK_PART
                lcCmd = lcCmd & ",'" & poNewEntity.SATUAN_PART
                lcCmd = lcCmd & "','" & poNewEntity.CREA_BY.Trim
                lcCmd = lcCmd & "','" & poNewEntity.UPD_BY.Trim & "'"

            Else

                lcCmd = "EXEC RPR0100 'UPDATE"
                lcCmd = lcCmd & "'," & poNewEntity.KD_PART
                lcCmd = lcCmd & ",'" & poNewEntity.NAMA_PART
                lcCmd = lcCmd & "'," & poNewEntity.HARGA_PART
                lcCmd = lcCmd & "," & poNewEntity.STOCK_PART
                lcCmd = lcCmd & ",'" & poNewEntity.SATUAN_PART
                lcCmd = lcCmd & "','" & poNewEntity.CREA_BY.Trim
                lcCmd = lcCmd & "','" & poNewEntity.UPD_BY.Trim & "'"

            End If
            loDb.SqlExecNonQuery(lcCmd, loConn, True)

            loConn.Close()
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Sub
End Class
