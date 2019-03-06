Imports SC_Common
Imports SC_Win_FrontEnd
Imports System.ServiceModel
Imports RPR0200.RPR0200SvcRef
Public Class RPR0200Frm_LKM_Outlet

    Private Sub RPR0200Frm_LKM_Outlet_SC_Init_From_Master(poParameter As Object) Handles Me.SC_Init_From_Master
        Dim loException As New SC_Exception
        Dim loService As RPR0200SvcClient
        Dim loList As List(Of LKM_OutletDTO)

        Try
            loService = New RPR0200SvcClient
            loList = loService.getOutlet(poParameter)
            LKM_OutletDTOBindingSource.DataSource = New SC_BindingListView(Of LKM_OutletDTO)(loList)
            loService.Close()

            LKM_OutletDTOSC_DataGridView.Sort(LKM_OutletDTOSC_DataGridView.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
            SC_GridSearch1.Focus()

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
