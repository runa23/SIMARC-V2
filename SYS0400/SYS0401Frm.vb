Imports SC_Common
Imports SC_Win_FrontEnd
Imports System.ServiceModel
Imports SYS0400.SYS0401SvcRef

Public Class SYS0401Frm

    Private _RoleID As String

    Private Sub SC_Conductor1_SC_AfterAdd(ByRef poEntity As Object) Handles SC_Conductor1.SC_AfterAdd
        TabControl1.SelectedTab = TabData
        APP_IDSC_TextBox.Focus()
    End Sub

    Private Sub SC_Conductor1_SC_BeforeEdit(poEntity As Object) Handles SC_Conductor1.SC_BeforeEdit
        TabControl1.SelectedTab = TabData
        APP_IDSC_TextBox.Focus()
    End Sub

    Private Sub SC_Conductor1_SC_ConvertParentGridEntity(poEntity As Object, ByRef poParentEntity As Object) Handles SC_Conductor1.SC_ConvertParentGridEntity
        poParentEntity = New SYS0401DTO02

        With CType(poEntity, SYS0401DTO01)
            poParentEntity.APP_ID = .APP_ID
            poParentEntity.APP_NAME = .APP_NAME
            poParentEntity.ROLE_ID = .ROLE_ID
            poParentEntity.ADD_PERMIT = .ADD_PERMIT
            poParentEntity.EDIT_PERMIT = .EDIT_PERMIT
            poParentEntity.DELETE_PERMIT = .DELETE_PERMIT
            poParentEntity.READ_PERMIT = .READ_PERMIT
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
    End Sub

    Private Sub SC_Conductor1_SC_Saving(ByRef poEntity As Object, peMode As SC_Conductor.e_Mode) Handles SC_Conductor1.SC_Saving
        With CType(poEntity, SYS0401DTO01)
            .ROLE_ID = _RoleID
            .CREA_BY = SC_GlobalVar.UserId
            .UPD_BY = SC_GlobalVar.UserId
        End With
    End Sub

    Private Sub SC_Conductor1_SC_ServiceDelete(poEntity As Object) Handles SC_Conductor1.SC_ServiceDelete
        Dim loException As New SC_Exception
        Dim loService As New SYS0401SvcClient

        Try
            loService = New SYS0401SvcClient
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
        Dim loService As SYS0401SvcClient
        Dim lokeyEntity As SYS0401DTO01

        Try
            lokeyEntity = New SYS0401DTO01
            With CType(poEntity, SYS0401DTO02)
                lokeyEntity.ROLE_ID = .ROLE_ID
                lokeyEntity.APP_ID = .APP_ID
            End With

            loService = New SYS0401SvcClient
            poEntityResult = loService.Svc_SC_GetRecord(lokeyEntity, eCRUDMode.NormalMode)
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

    Private Sub SC_Conductor1_SC_ServiceSave(poEntity As Object, peMode As SC_Conductor.e_Mode, ByRef poEntityResult As Object) Handles SC_Conductor1.SC_ServiceSave
        Dim loException As New SC_Exception
        Dim loService As SYS0401SvcClient

        Try
            loService = New SYS0401SvcClient
            poEntityResult = loService.Svc_SC_Save(poEntity, _
                                                   IIf(peMode = SC_Win_FrontEnd.SC_Conductor.e_Mode.AddMode, _
                                                                 eCRUDMode.AddMode, eCRUDMode.EditMode))
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
            If String.IsNullOrEmpty(APP_IDSC_TextBox.Text.Trim) Then
                lcErr = "App ID harus diisi"
                loException.Add("01", lcErr)
                SC_ErrorProvider1.SetError(APP_IDSC_TextBox, lcErr)
            End If

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Sub

    Private Sub SYS0401Frm_SC_Init_From_Master(poParameter As Object) Handles Me.SC_Init_From_Master
        Dim loException As New SC_Exception
        Dim loService As SYS0401SvcClient
        Dim loList As List(Of SYS0401DTO02)

        Try
            _RoleID = poParameter.ROLE_ID
            SYS0400DTO02BindingSource.DataSource = poParameter

            loService = New SYS0401SvcClient

            loList = loService.GetList(_RoleID)
            SYS0401DTO02BindingSource.DataSource = New SC_BindingListView(Of SYS0401DTO02)(loList)
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

    Private Sub AppSC_LookUp_SC_Before_Open_Form(ByRef poTargetForm As SC_FormBase, ByRef poParameter As Object) Handles AppSC_LookUp.SC_Before_Open_Form
        poTargetForm = New SYS0401FrmLkm_App
        poParameter = _RoleID
    End Sub

    Private Sub AppSC_LookUp_SC_Return_LookUp(poReturnObject As Object) Handles AppSC_LookUp.SC_Return_LookUp
        With CType(SYS0401DTO01BindingSource.Current, SYS0401DTO01)
            .APP_ID = poReturnObject.APP_ID
            .APP_NAME = poReturnObject.APP_NAME
        End With
    End Sub
End Class
