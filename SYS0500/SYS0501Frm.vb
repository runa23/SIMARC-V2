Imports SC_Common
Imports SC_Win_FrontEnd
Imports System.ServiceModel
Imports SYS0500.SYS0501SvcRef

Public Class SYS0501Frm
    Private _UserID As String
    Private Sub SC_Conductor1_SC_AfterAdd(ByRef poEntity As Object) Handles SC_Conductor1.SC_AfterAdd
        TabControl1.SelectedTab = TabData
        With CType(poEntity, SYS0501DTO01)
            .CREA_DATE = Now
            .UPD_DATE = Now
        End With
    End Sub

    Private Sub SC_Conductor1_SC_BeforeEdit(poEntity As Object) Handles SC_Conductor1.SC_BeforeEdit
        TabControl1.SelectedTab = TabData
    End Sub

    Private Sub SC_Conductor1_SC_ConvertParentGridEntity(poEntity As Object, ByRef poParentEntity As Object) Handles SC_Conductor1.SC_ConvertParentGridEntity
        poParentEntity = New SYS0501DTO02

        With CType(poEntity, SYS0501DTO01)
            poParentEntity.USER_ID = .USER_ID
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
    End Sub

    Private Sub SC_Conductor1_SC_Saving(ByRef poEntity As Object, peMode As SC_Conductor.e_Mode) Handles SC_Conductor1.SC_Saving
        With CType(poEntity, SYS0501DTO01)
            .USER_ID = _UserID
            .CREA_BY = SC_GlobalVar.UserId
            .UPD_BY = SC_GlobalVar.UserId
        End With
    End Sub

    Private Sub SC_Conductor1_SC_ServiceDelete(poEntity As Object) Handles SC_Conductor1.SC_ServiceDelete
        Dim loException As New SC_Exception
        Dim loService As New SYS0501SvcClient

        Try
            loService = New SYS0501SvcClient
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
        Dim loService As SYS0501SvcClient
        Dim lokeyEntity As SYS0501DTO01

        Try
            lokeyEntity = New SYS0501DTO01
            With CType(poEntity, SYS0501DTO02)
                lokeyEntity.USER_ID = .USER_ID
                lokeyEntity.ROLE_ID = .ROLE_ID
            End With

            loService = New SYS0501SvcClient
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
        Dim loService As SYS0501SvcClient

        Try
            loService = New SYS0501SvcClient
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
            If String.IsNullOrEmpty(ROLE_NAMESC_ComboBox.SelectedValue.ToString.Trim) Then
                lcErr = "Role Harus dipilih"
                loException.Add("Validasi", lcErr)
                SC_ErrorProvider1.SetError(ROLE_NAMESC_ComboBox, lcErr)
            End If

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Sub

    Private Sub SYS0501Frm_SC_Init_From_Master(poParameter As Object) Handles Me.SC_Init_From_Master
        Dim loException As New SC_Exception
        Dim loService As SYS0501SvcClient
        Dim loList As List(Of SYS0501DTO02)
        Dim loRole As List(Of LKM_RoleDTO)

        Try

            loService = New SYS0501SvcClient

            _UserID = poParameter.USER_ID
            USER_IDSC_TextBox.Text = _UserID
            'SYS0500DTO02BindingSource.DataSource = poParameter

            loRole = loService.getRole()
            LKM_RoleDTOBindingSource.DataSource = New SC_BindingListView(Of LKM_RoleDTO)(loRole)

            loList = loService.getList(_UserID)
            SYS0501DTO02BindingSource.DataSource = New SC_BindingListView(Of SYS0501DTO02)(loList)

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