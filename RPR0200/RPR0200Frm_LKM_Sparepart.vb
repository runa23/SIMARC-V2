Imports SC_Common
Imports SC_Win_FrontEnd
Imports System.ServiceModel
Imports RPR0200.RPR0200SvcRef
Public Class RPR0200Frm_LKM_Sparepart

    Public Function getList()
        LKM_SparepartDTOBindingSource.RemoveFilter()
        Return LKM_SparepartDTOBindingSource.List
    End Function

    Private Sub OKSC_Button_Click(sender As Object, e As EventArgs) Handles OKSC_Button.Click
        getList()
        Close()
    End Sub

    Private Sub CancelSC_Button_Click(sender As Object, e As EventArgs) Handles CancelSC_Button.Click
        LKM_SparepartDTOBindingSource.Clear()
        Close()
    End Sub

    Private Sub RPR0200Frm_LKM_Sparepart_SC_Init_From_Master(poParameter As Object) Handles Me.SC_Init_From_Master
        Dim loException As New SC_Exception
        Dim loService As RPR0200SvcClient
        'Dim loParam As RPR0200DTO01
        Dim loSparepart As New List(Of LKM_SparepartDTO)
        Dim poparam As New List(Of Object)
        Dim loKode As String
        Dim loCompanyOffice As String

        Try
            poparam = poParameter

            With poparam
                loKode = .Item(0)
                loCompanyOffice = .Item(1)
            End With

            If loCompanyOffice = Nothing Then
                loCompanyOffice = " "
            End If

            loService = New RPR0200SvcClient

            loSparepart = loService.getSparepart(loKode, loCompanyOffice)
            LKM_SparepartDTOBindingSource.DataSource = New SC_BindingListView(Of LKM_SparepartDTO)(loSparepart)

            SC_GridSearch1.Focus()

            loService.Close()

        Catch ex As FaultException(Of SC_ServiceExceptions)
            loException.ErrorList.AddRange(ex.Detail.Exceptions)
        Catch ex As FaultException
            loException.Add(ex)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        If loException.Haserror Then
            SC_DisplayException(loException)
        End If
    End Sub
End Class
