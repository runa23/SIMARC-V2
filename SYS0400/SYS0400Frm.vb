Imports SC_Common
Imports SC_Win_FrontEnd
Imports SYS0400.SYS0400SvcRef
Imports System.ServiceModel

Public Class SYS0400Frm
    Public Const SysAppId As String = "SYS0400"
    Public Const SysAppVersion As String = "0.00.001"

    Private Sub SC_Conductor1_SC_AfterAdd(ByRef poEntity As Object) Handles SC_Conductor1.SC_AfterAdd
        Dim loException As New SC_Exception
        Dim loService As SYS0400SvcClient
        Dim poparam As New List(Of Object)

        TabControl1.SelectedTab = TabData

        With CType(poEntity, SYS0400DTO01)
            .ROLE_ID = ""
            .ROLE_NAME = ""
        End With

        ROLE_IDSC_TextBox.Focus()

        loService = New SYS0400SvcClient
        loService.Close()
    End Sub

    Private Sub SC_Conductor1_SC_AfterCancel(poEntity As Object) Handles SC_Conductor1.SC_AfterCancel
        Dim loException As New SC_Exception
        Dim loService As New SYS0400SvcClient

        Try
            loService = New SYS0400SvcClient
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
        ROLE_IDSC_TextBox.Focus()
    End Sub

    Private Sub SC_Conductor1_SC_ConvertParentGridEntity(poEntity As Object, ByRef poParentEntity As Object) Handles SC_Conductor1.SC_ConvertParentGridEntity
        Dim loEntity As SYS0400DTO01 = poEntity
        poParentEntity = New SYS0400DTO02

        With CType(poEntity, SYS0400DTO01)
            poParentEntity.ROLE_ID = .ROLE_ID
            poParentEntity.ROLE_NAME = .ROLE_NAME
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
        SC_ErrorProvider1.Clear()
    End Sub

    Private Sub SC_Conductor1_SC_Saving(ByRef poEntity As Object, peMode As SC_Conductor.e_Mode) Handles SC_Conductor1.SC_Saving
        With CType(poEntity, SYS0400DTO01)
            .CREA_BY = SC_GlobalVar.UserId
            .UPD_BY = SC_GlobalVar.UserId
        End With
    End Sub

    Private Sub SC_Conductor1_SC_ServiceDelete(poEntity As Object) Handles SC_Conductor1.SC_ServiceDelete
        Dim loException As New SC_Exception
        Dim loService As New SYS0400SvcClient

        Try
            loService = New SYS0400SvcClient
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
        Dim loService As SYS0400SvcClient
        Dim loKeyEntity As SYS0400DTO01

        Try
            loKeyEntity = New SYS0400DTO01
            With CType(poEntity, SYS0400DTO02)
                loKeyEntity.ROLE_ID = .ROLE_ID
            End With

            loService = New SYS0400SvcClient
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
        Dim loService As SYS0400SvcClient
        Dim loList As List(Of SYS0400DTO02)
        Dim loPar As New List(Of Object)
        Dim poparam As New List(Of Object)

        Try
            loService = New SYS0400SvcClient

            loList = loService.getList(poparam)
            SYS0400DTO02BindingSource.DataSource = New SC_BindingListView(Of SYS0400DTO02)(loList)
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
        Dim loService As SYS0400SvcClient

        Try
            loService = New SYS0400SvcClient
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

        If String.IsNullOrEmpty(ROLE_IDSC_TextBox.Text.Trim) Then
            lcErr = "ROLE ID harus diisi"
            loException.Add("Validasi", lcErr)
            SC_ErrorProvider1.SetError(ROLE_IDSC_TextBox, lcErr)
        End If

        If String.IsNullOrEmpty(ROLE_NAMESC_TextBox.Text.Trim) Then
            lcErr = "ROLE NAME harus diisi"
            loException.Add("Validasi", lcErr)
            SC_ErrorProvider1.SetError(ROLE_NAMESC_TextBox, lcErr)
        End If
    End Sub

    Private Sub SYS0400Frm_Load(sender As Object, e As EventArgs) Handles Me.Load
        VersionLabel.Text = SysAppId & " V. " & SysAppVersion
        SC_Conductor1.SC_SetRoleApp(SC_GlobalVar.RoleApp(SysAppId))

        Dim loException As New SC_Exception
        Dim loService As SYS0400SvcClient
        Dim poparam As New List(Of Object)

        Try
            loService = New SYS0400SvcClient
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

    Private Sub RoleAppSC_Detail_SC_Before_Open_Form(ByRef poTargetForm As SC_FormBase, ByRef poParameter As Object) Handles RoleAppSC_Detail.SC_Before_Open_Form
        poTargetForm = New SYS0401Frm
        poParameter = SYS0400DTO02BindingSource.Current
    End Sub
End Class
