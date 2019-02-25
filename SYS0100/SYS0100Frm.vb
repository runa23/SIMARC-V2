Imports SC_Common
Imports SYS0100.SYS0100SvcRef
Imports SC_Win_FrontEnd
Imports System.ServiceModel
Public Class SYS0100Frm
    Public Const SysAppId As String = "SYS0100"
    Public Const SysAppVersion As String = "0.00.001"

    Private Sub SC_Conductor1_SC_AfterAdd(ByRef poEntity As Object) Handles SC_Conductor1.SC_AfterAdd
        Dim loException As New SC_Exception
        Dim loService As SYS0100SvcClient
        Dim poparam As New List(Of Object)

        TabControl1.SelectedTab = TabData

        With CType(poEntity, SYS0100DTO01)
            .APP_GROUP_ID = ""
            .APP_GROUP_NAME = ""
        End With

        loService = New SYS0100SvcClient
        loService.Close()
    End Sub

    Private Sub SC_Conductor1_SC_AfterCancel(poEntity As Object) Handles SC_Conductor1.SC_AfterCancel
        Dim loException As New SC_Exception
        Dim loService As New SYS0100SvcClient

        Try
            loService = New SYS0100SvcClient
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

    Private Sub SC_Conductor1_SC_AfterEdit(ByRef poEntity As Object) Handles SC_Conductor1.SC_AfterEdit
        TabControl1.SelectedTab = TabData
        APP_GROUP_IDSC_TextBox.Enabled = False
    End Sub

    Private Sub SC_Conductor1_SC_ConvertParentGridEntity(poEntity As Object, ByRef poParentEntity As Object) Handles SC_Conductor1.SC_ConvertParentGridEntity
        Dim loEntity As SYS0100DTO01 = poEntity
        poParentEntity = New SYS0100DTO02

        With CType(poEntity, SYS0100DTO01)
            poParentEntity.APP_GROUP_ID = .APP_GROUP_ID
            poParentEntity.APP_GROUP_NAME = .APP_GROUP_NAME
            poParentEntity.CREA_BY = .CREA_BY
            poParentEntity.CREA_DATE = .CREA_DATE
            poParentEntity.UPD_BY = .UPD_BY
            poParentEntity.UPD_DATE = .UPD_DATE
        End With
    End Sub

    Private Sub SC_Conductor1_SC_Display(poEntity As Object, peMode As SC_Conductor.e_Mode) Handles SC_Conductor1.SC_Display
        If peMode = SC_Conductor.e_Mode.NormalMode Then
            TabControl1.SelectedTab = TabList
        End If
        APP_GROUP_IDSC_TextBox.Enabled = True
        SC_ErrorProvider1.Clear()
    End Sub

    Private Sub SC_Conductor1_SC_Saving(ByRef poEntity As Object, peMode As SC_Conductor.e_Mode) Handles SC_Conductor1.SC_Saving
        With CType(poEntity, SYS0100DTO01)
            .CREA_BY = SC_GlobalVar.UserId
            .UPD_BY = SC_GlobalVar.UserId
        End With
    End Sub

    Private Sub SC_Conductor1_SC_ServiceDelete(poEntity As Object) Handles SC_Conductor1.SC_ServiceDelete
        Dim loException As New SC_Exception
        Dim loService As New SYS0100SvcClient

        Try
            loService = New SYS0100SvcClient
            loService.Svc_SC_Delete(poEntity)
            loService.Close()

        Catch ex As FaultException(Of SC_ServiceExceptions)
            loException.ErrorList.AddRange(ex.Detail.Exceptions)
        Catch ex As FaultException
            loException.Add(ex)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Sub

    Private Sub SC_Conductor1_SC_ServiceGetRecord(poEntity As Object, ByRef poEntityResult As Object) Handles SC_Conductor1.SC_ServiceGetRecord
        Dim loException As New SC_Exception
        Dim loService As SYS0100SvcClient
        Dim loKeyEntity As SYS0100DTO01

        Try
            loKeyEntity = New SYS0100DTO01
            With CType(poEntity, SYS0100DTO02)
                loKeyEntity.APP_GROUP_ID = .APP_GROUP_ID
            End With

            loService = New SYS0100SvcClient
            poEntityResult = loService.Svc_SC_GetRecord(loKeyEntity, eCRUDMode.NormalMode)

            loService.Close()

        Catch ex As FaultException(Of SC_ServiceExceptions)
            loException.ErrorList.AddRange(ex.Detail.Exceptions)
        Catch ex As FaultException
            loException.Add(ex)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Sub

    Private Sub SC_Conductor1_SC_ServiceRefreshList() Handles SC_Conductor1.SC_ServiceRefreshList
        Dim loException As New SC_Exception
        Dim loService As SYS0100SvcClient
        Dim loList As List(Of SYS0100DTO02)
        Dim loPar As New List(Of Object)
        Dim poparam As New List(Of Object)

        Try
            loService = New SYS0100SvcClient

            loList = loService.getList(poparam)
            SYS0100DTO02BindingSource.DataSource = New SC_BindingListView(Of SYS0100DTO02)(loList)
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

    Private Sub SC_Conductor1_SC_ServiceSave(poEntity As Object, peMode As SC_Conductor.e_Mode, ByRef poEntityResult As Object) Handles SC_Conductor1.SC_ServiceSave
        Dim loException As New SC_Exception
        Dim loService As SYS0100SvcClient

        Try
            loService = New SYS0100SvcClient
            poEntityResult = loService.Svc_SC_Save(poEntity, IIf(peMode = SC_Win_FrontEnd.SC_Conductor.e_Mode.AddMode, eCRUDMode.AddMode, eCRUDMode.EditMode))
            loService.Close()

        Catch ex As FaultException(Of SC_ServiceExceptions)
            loException.ErrorList.AddRange(ex.Detail.Exceptions)
        Catch ex As FaultException
            loException.Add(ex)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ThrowExceptionIfErrors()
    End Sub

    Private Sub SC_Conductor1_SC_Validation(poEntity As Object, peMode As SC_Conductor.e_Mode) Handles SC_Conductor1.SC_Validation
        Dim loException As New SC_Exception
        Dim lcErr As String

        Try
            SC_ErrorProvider1.Clear()

            If String.IsNullOrEmpty(APP_GROUP_IDSC_TextBox.Text) Then
                lcErr = "Group App ID harus diisi"
                loException.Add("Validasi", lcErr)
                SC_ErrorProvider1.SetError(APP_GROUP_IDSC_TextBox, lcErr)
            End If
            If String.IsNullOrEmpty(APP_GROUP_NAMESC_TextBox.Text) Then
                lcErr = "Group App Name harus diisi"
                loException.Add("Validasi", lcErr)
                SC_ErrorProvider1.SetError(APP_GROUP_NAMESC_TextBox, lcErr)
            End If
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ThrowExceptionIfErrors()
    End Sub

    Private Sub SYS0100Frm_Load(sender As Object, e As EventArgs) Handles Me.Load
        VersionLabel.Text = SysAppId & " V. " & SysAppVersion

        Dim loException As New SC_Exception
        Dim loService As SYS0100SvcClient
        Dim poparam As New List(Of Object)

        Try
            loService = New SYS0100SvcClient
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
