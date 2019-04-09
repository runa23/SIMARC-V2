Imports SC_BackEnd
Imports SC_Common
Imports RPR0100Back
Imports System.Data.Common
Imports System.Data.SqlClient

Public Class RPR0100Cls
    Inherits SC_BusinessObject(Of RPR0100DTO01)

    Function getList(poParam As List(Of Object)) As List(Of RPR0100DTO02)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As List(Of RPR0100DTO02)
        Dim CompanyOffice As String

        Try

            With poParam
                CompanyOffice = .Item(0)
            End With

            lcCmd = "SELECT [COMPANY_OFFICE_ID]"
            lcCmd = lcCmd & ",[KD_PART]"
            lcCmd = lcCmd & ",[NAMA_PART]"
            lcCmd = lcCmd & ",[HARGA_PART]"
            lcCmd = lcCmd & ",[STOCK_PART]"
            lcCmd = lcCmd & ",[SATUAN_PART]"
            lcCmd = lcCmd & ",[CREA_BY]"
            lcCmd = lcCmd & ",[CREA_DATE]"
            lcCmd = lcCmd & ",[UPD_BY]"
            lcCmd = lcCmd & ",[UPD_DATE] "
            lcCmd = lcCmd & "FROM [dbo].[M_SPAREPART] (NOLOCK) "
            lcCmd = lcCmd & "WHERE COMPANY_OFFICE_ID ='" & CompanyOffice & "'"

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

            lcCmd = "SELECT * FROM M_SPAREPART_LOG WHERE KD_PART = " & poEntity.KD_PART & " "
            lcCmd = lcCmd & " AND COMPANY_OFFICE_ID ='" & poEntity.COMPANY_OFFICE_ID & "'"
            lcCmd = lcCmd & " AND LOG_PART NOT IN ('INSERT','UPDATE','DELETE')"
            If loDb.SqlExecQuery(lcCmd, loConn, False).Rows.Count > 0 Then
                loException.Add("Validasi", "Data tidak dapat dihapus, karena sudah digunakan saat repair")
                Exit Try
            End If

            lcCmd = "EXEC RPR0100 'DELETE"
            lcCmd = lcCmd & "','" & poEntity.COMPANY_OFFICE_ID
            lcCmd = lcCmd & "'," & poEntity.KD_PART
            lcCmd = lcCmd & ",'" & poEntity.NAMA_PART
            lcCmd = lcCmd & "'," & Val(poEntity.HARGA_PART)
            lcCmd = lcCmd & "," & poEntity.STOCK_PART
            lcCmd = lcCmd & ",'" & poEntity.SATUAN_PART
            lcCmd = lcCmd & "','" & poEntity.CREA_BY.Trim
            lcCmd = lcCmd & "','" & poEntity.UPD_BY.Trim & "'"

            loDb.SqlExecNonQuery(lcCmd, loConn, True)

            lcCmd = "EXEC RPR0110 "
            lcCmd = lcCmd & "'" & poEntity.COMPANY_OFFICE_ID
            lcCmd = lcCmd & "'," & poEntity.KD_PART
            lcCmd = lcCmd & "," & Val(poEntity.HARGA_PART)
            lcCmd = lcCmd & ",'DELETE"
            lcCmd = lcCmd & "','" & poEntity.CREA_BY.Trim
            lcCmd = lcCmd & "','" & poEntity.UPD_BY.Trim & "'"

            loDb.SqlExecNonQuery(lcCmd, loConn, True)

        Catch ex As Exception
            loException.Add(ex)
        End Try
        'loException.ConvertAndThrowToServiceExceptionIfErrors()
        loException.ThrowExceptionIfErrors()
    End Sub

    Protected Overrides Function SC_Display(poEntity As RPR0100DTO01, poCRUDMode As eCRUDMode, plWithLock As Boolean) As RPR0100DTO01
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As RPR0100DTO01

        Try
            lcCmd = "SELECT [COMPANY_OFFICE_ID]"
            lcCmd = lcCmd & ",[KD_PART]"
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
            lcCmd = lcCmd & "AND COMPANY_OFFICE_ID = '" & poEntity.COMPANY_OFFICE_ID & "'"

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
        Dim Harga As Decimal
        Dim Stock As Decimal
        Dim loKode As DataTable
        Dim loHarga As DataTable

        Try
            loConn = loDb.GetConnection

            If poCRUDMode = eCRUDMode.AddMode Then

                lcCmd = "SELECT ISNULL(MAX(KD_PART),0) as KODE FROM M_SPAREPART"
                lcCmd = lcCmd & " WHERE COMPANY_OFFICE_ID ='" & poNewEntity.COMPANY_OFFICE_ID & "'"
                loKode = loDb.SqlExecQuery(lcCmd, loConn, False)
                Kode = loKode.Rows.Item(0)(0) + 1

                lcCmd = "SELECT * FROM M_SPAREPART WHERE KD_PART = " & Kode & " "
                lcCmd = lcCmd & " AND COMPANY_OFFICE_ID ='" & poNewEntity.COMPANY_OFFICE_ID & "'"
                If loDb.SqlExecQuery(lcCmd, loConn, False).Rows.Count > 0 Then
                    loException.Add("Validasi", "Data tidak dapat disimpan. Kode Spare Part " & Kode & " sudah ada")
                    Exit Try
                End If

                poNewEntity.KD_PART = Kode

                lcCmd = "EXEC RPR0100 'INSERT"
                lcCmd = lcCmd & "','" & poNewEntity.COMPANY_OFFICE_ID
                lcCmd = lcCmd & "'," & poNewEntity.KD_PART
                lcCmd = lcCmd & ",'" & poNewEntity.NAMA_PART
                lcCmd = lcCmd & "','" & Val(poNewEntity.HARGA_PART)
                lcCmd = lcCmd & "'," & poNewEntity.STOCK_PART
                lcCmd = lcCmd & ",'" & poNewEntity.SATUAN_PART
                lcCmd = lcCmd & "','" & poNewEntity.CREA_BY.Trim
                lcCmd = lcCmd & "','" & poNewEntity.UPD_BY.Trim & "'"

                loDb.SqlExecNonQuery(lcCmd, loConn, False)

                lcCmd = "EXEC RPR0110 "
                lcCmd = lcCmd & "'" & poNewEntity.COMPANY_OFFICE_ID
                lcCmd = lcCmd & "'," & poNewEntity.KD_PART
                lcCmd = lcCmd & "," & Val(poNewEntity.HARGA_PART)
                lcCmd = lcCmd & ",'INSERT"
                lcCmd = lcCmd & "','" & poNewEntity.CREA_BY.Trim
                lcCmd = lcCmd & "','" & poNewEntity.UPD_BY.Trim & "'"

                loDb.SqlExecNonQuery(lcCmd, loConn, True)
            Else

                lcCmd = "SELECT HARGA_PART, STOCK_PART FROM M_SPAREPART WHERE KD_PART = " & poNewEntity.KD_PART & " "
                lcCmd = lcCmd & " AND COMPANY_OFFICE_ID ='" & poNewEntity.COMPANY_OFFICE_ID & "'"
                loHarga = loDb.SqlExecQuery(lcCmd, loConn, False)
                Harga = loHarga.Rows.Item(0)(0)
                Stock = loHarga.Rows.Item(0)(1)

                If Stock <> 0 Then
                    If Harga <> poNewEntity.HARGA_PART Then
                        loException.Add("Validasi", "Data harga part tidak dapat disimpan jika stock belum habis atau 0 ")
                        Exit Try
                    End If
                End If

                lcCmd = "EXEC RPR0100 'UPDATE"
                lcCmd = lcCmd & "','" & poNewEntity.COMPANY_OFFICE_ID
                lcCmd = lcCmd & "'," & poNewEntity.KD_PART
                lcCmd = lcCmd & ",'" & poNewEntity.NAMA_PART
                lcCmd = lcCmd & "'," & Val(poNewEntity.HARGA_PART)
                lcCmd = lcCmd & "," & poNewEntity.STOCK_PART
                lcCmd = lcCmd & ",'" & poNewEntity.SATUAN_PART
                lcCmd = lcCmd & "','" & poNewEntity.CREA_BY.Trim
                lcCmd = lcCmd & "','" & poNewEntity.UPD_BY.Trim & "'"

                loDb.SqlExecNonQuery(lcCmd, loConn, False)

                lcCmd = "EXEC RPR0110 "
                lcCmd = lcCmd & "'" & poNewEntity.COMPANY_OFFICE_ID
                lcCmd = lcCmd & "'," & poNewEntity.KD_PART
                lcCmd = lcCmd & "," & Val(poNewEntity.HARGA_PART)
                lcCmd = lcCmd & ",'UPDATE"
                lcCmd = lcCmd & "','" & poNewEntity.CREA_BY.Trim
                lcCmd = lcCmd & "','" & poNewEntity.UPD_BY.Trim & "'"

                loDb.SqlExecNonQuery(lcCmd, loConn, True)

            End If


            loConn.Close()
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Sub
End Class
