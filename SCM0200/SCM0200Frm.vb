Imports SC_Common
Imports SC_Win_FrontEnd
Imports SCM0200.SCM0200SvcRef
Imports System.ServiceModel
Imports System.Windows.Forms
Imports System.Drawing
Public Class SCM0200Frm
    Public Const SysAppId As String = "SCM0200"
    Public Const SysAppVersion As String = "0.00.001"

    Private Sub SC_Conductor1_SC_AfterAdd(ByRef poEntity As Object) Handles SC_Conductor1.SC_AfterAdd
        Dim loService As SCM0200SvcClient

        TabControl1.SelectedTab = TabData

        With CType(poEntity, SCM0200DTO01)
            .COMPANY_ID = ""
            .COMPANY_NAME = ""
        End With

        loService = New SCM0200SvcClient
        loService.Close()
    End Sub

    Private Sub SC_Conductor1_SC_AfterCancel(poEntity As Object) Handles SC_Conductor1.SC_AfterCancel
        Dim loException As New SC_Exception
        Dim loService As New SCM0200SvcClient

        Try
            loService = New SCM0200SvcClient
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
        COMPANY_IDSC_TextBox.Enabled = False
    End Sub

    Private Sub SC_Conductor1_SC_ConvertParentGridEntity(poEntity As Object, ByRef poParentEntity As Object) Handles SC_Conductor1.SC_ConvertParentGridEntity
        Dim loEntity As SCM0200DTO01 = poEntity
        poParentEntity = New SCM0200DTO02

        With CType(poEntity, SCM0200DTO01)
            poParentEntity.COMPANY_ID = .COMPANY_ID
            poParentEntity.COMPANY_NAME = .COMPANY_NAME
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
        COMPANY_IDSC_TextBox.Enabled = True
        SC_ErrorProvider1.Clear()
    End Sub

    Private Sub SC_Conductor1_SC_Saving(ByRef poEntity As Object, peMode As SC_Conductor.e_Mode) Handles SC_Conductor1.SC_Saving
        With CType(poEntity, SCM0200DTO01)
            .CREA_BY = SC_GlobalVar.UserId
            .UPD_BY = SC_GlobalVar.UserId
        End With
    End Sub

    Private Sub SC_Conductor1_SC_ServiceDelete(poEntity As Object) Handles SC_Conductor1.SC_ServiceDelete
        Dim loException As New SC_Exception
        Dim loService As New SCM0200SvcClient

        Try
            loService = New SCM0200SvcClient
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
        Dim loService As SCM0200SvcClient
        Dim loKeyEntity As SCM0200DTO01

        Try
            loKeyEntity = New SCM0200DTO01
            With CType(poEntity, SCM0200DTO02)
                loKeyEntity.COMPANY_ID = .COMPANY_ID
            End With

            loService = New SCM0200SvcClient
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
        Dim loService As SCM0200SvcClient
        Dim loList As List(Of SCM0200DTO02)
        Dim poparam As New List(Of Object)

        Try
            loService = New SCM0200SvcClient

            loList = loService.getList(poparam)
            SCM0200DTO02BindingSource.DataSource = New SC_BindingListView(Of SCM0200DTO02)(loList)
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
        Dim loService As SCM0200SvcClient

        Try
            loService = New SCM0200SvcClient
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

            If String.IsNullOrEmpty(COMPANY_IDSC_TextBox.Text) Then
                lcErr = "Company ID harus diisi"
                loException.Add("Validasi", lcErr)
                SC_ErrorProvider1.SetError(COMPANY_IDSC_TextBox, lcErr)
            End If

            If String.IsNullOrEmpty(COMPANY_NAMESC_TextBox.Text) Then
                lcErr = "Company Name harus diisi"
                loException.Add("Validasi", lcErr)
                SC_ErrorProvider1.SetError(COMPANY_NAMESC_TextBox, lcErr)
            End If

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ThrowExceptionIfErrors()
    End Sub

    Private Sub SCM0200Frm_Load(sender As Object, e As EventArgs) Handles Me.Load
        VersionLabel.Text = SysAppId & " V. " & SysAppVersion

        Dim loException As New SC_Exception
        Dim loService As SCM0200SvcClient
        Dim poparam As New List(Of Object)

        Try
            loService = New SCM0200SvcClient
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
