Imports SC_Common
Imports SC_Win_FrontEnd
Imports SYS0400.SYS0401SvcRef
Imports System.ServiceModel
Public Class SYS0401FrmLkm_App

    Private Sub SYS0401FrmLkm_App_SC_Init_From_Master(poParameter As Object) Handles Me.SC_Init_From_Master
        Dim loException As New SC_Exception
        Dim loService As SYS0401SvcClient
        Dim loList As List(Of LKMSys_AppDTO)
        Dim RoleID As String

        Try
            RoleID = poParameter
            loService = New SYS0401SvcClient

            loList = loService.GetList_App(RoleID)
            LKMSys_AppDTOBindingSource.DataSource = New SC_BindingListView(Of LKMSys_AppDTO)(loList)
            loService.Close()

        Catch ex As FaultException(Of SC_ServiceExceptions)
            loException.ErrorList.AddRange(ex.Detail.Exceptions)
        Catch ex As FaultException
            loException.Add(ex)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        If loException.Haserror Then
            Me.SC_DisplayException(loException)
        End If
    End Sub
End Class
