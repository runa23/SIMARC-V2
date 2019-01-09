Imports SC_Common
Imports SCM0300.SCM0300SvcRef
Imports SC_Win_FrontEnd
Imports System.ServiceModel
Public Class SCM0300Frm
    Public Const SysAppId As String = "SCM0300"
    Public Const SysAppVersion As String = "0.00.001"

    Private Sub SC_Conductor1_SC_AfterAdd(ByRef poEntity As Object) Handles SC_Conductor1.SC_AfterAdd
        Dim loException As New SC_Exception
        Dim loService As SCM0300SvcClient
        Dim poparam As New List(Of Object)
        Dim loCompany As List(Of LKM_CompanyDTO)

        TabControl1.SelectedTab = TabData

        With CType(poEntity, SCM0300DTO01)
            .COMPANY_OFFICE_ID = ""
            .COMPANY_OFFICE = ""
            COMPANY_NAMESC_ComboBox.SelectedValue = 0
            .COMPANY_ID = COMPANY_NAMESC_ComboBox.SelectedValue
        End With

        loService = New SCM0300SvcClient
        loCompany = loService.getCompany()
        LKM_CompanyDTOBindingSource.DataSource = New SC_BindingListView(Of LKM_CompanyDTO)(loCompany)

        COMPANY_OFFICE_IDSC_TextBox.Focus()

        loService.Close()

        If loException.Haserror Then
            SC_DisplayException(loException)
        End If
    End Sub

    Private Sub SC_Conductor1_SC_AfterCancel(poEntity As Object) Handles SC_Conductor1.SC_AfterCancel
        Dim loException As New SC_Exception
        Dim loService As New SCM0300SvcClient

        Try
            loService = New SCM0300SvcClient
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
    End Sub

    Private Sub SC_Conductor1_SC_ConvertParentGridEntity(poEntity As Object, ByRef poParentEntity As Object) Handles SC_Conductor1.SC_ConvertParentGridEntity
        Dim loEntity As SCM0300DTO01 = poEntity
        poParentEntity = New SCM0300DTO02

        With CType(poEntity, SCM0300DTO01)
            poParentEntity.COMPANY_OFFICE_ID = .COMPANY_OFFICE_ID
            poParentEntity.COMPANY_OFFICE = .COMPANY_OFFICE
            poParentEntity.COMPANY_ID = .COMPANY_ID
            poParentEntity.PHONE = .PHONE
            poParentEntity.SEQUENCE = .SEQUENCE
            poParentEntity.COMPANY_OFFICE_INDEX = .COMPANY_OFFICE_INDEX
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
        With CType(poEntity, SCM0300DTO01)
            .CREA_BY = SC_GlobalVar.UserId
            .UPD_BY = SC_GlobalVar.UserId
        End With
    End Sub

    Private Sub SC_Conductor1_SC_ServiceDelete(poEntity As Object) Handles SC_Conductor1.SC_ServiceDelete
        Dim loException As New SC_Exception
        Dim loService As SCM0300SvcClient

        Try
            loService = New SCM0300SvcClient
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
        Dim loService As SCM0300SvcClient
        Dim loKeyEntity As SCM0300DTO01

        Try
            loKeyEntity = New SCM0300DTO01
            With CType(poEntity, SCM0300DTO02)
                loKeyEntity.COMPANY_OFFICE_ID = .COMPANY_OFFICE_ID
            End With

            loService = New SCM0300SvcClient
            poEntityResult = loService.Svc_SC_GetRecord(loKeyEntity, eCRUDMode.NormalMode)
            loService.Close() '

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
        Dim loService As New SCM0300SvcClient
        Dim loList As List(Of SCM0300DTO02)
        Dim poparam As New List(Of Object)
        Dim loCompany As List(Of LKM_CompanyDTO)

        Try
            loService = New SCM0300SvcClient

            loList = loService.getList(poparam)
            loCompany = loService.getCompany()
            LKM_CompanyDTOBindingSource.DataSource = New SC_BindingListView(Of LKM_CompanyDTO)(loCompany)
            SCM0300DTO02BindingSource.DataSource = New SC_BindingListView(Of SCM0300DTO02)(loList)

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
        Dim loService As SCM0300SvcClient

        Try
            loService = New SCM0300SvcClient
            poEntityResult = loService.Svc_SC_Save(poEntity, IIf(peMode = SC_Conductor.e_Mode.AddMode, eCRUDMode.AddMode, eCRUDMode.EditMode))
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

            If String.IsNullOrEmpty(COMPANY_OFFICE_IDSC_TextBox.Text) Then
                lcErr = "Company Office ID harus diisi"
                loException.Add("Validasi", lcErr)
                SC_ErrorProvider1.SetError(COMPANY_OFFICE_IDSC_TextBox, lcErr)
            End If

            If String.IsNullOrEmpty(COMPANY_OFFICESC_TextBox.Text) Then
                lcErr = "Company Office Name harus diisi"
                loException.Add("Validasi", lcErr)
                SC_ErrorProvider1.SetError(COMPANY_OFFICESC_TextBox, lcErr)
            End If

            If String.IsNullOrEmpty(COMPANY_NAMESC_ComboBox.Text) Then
                lcErr = "Company ID harus dipilih"
                loException.Add("Validasi", lcErr)
                SC_ErrorProvider1.SetError(COMPANY_NAMESC_ComboBox, lcErr)
            End If

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ThrowExceptionIfErrors()
    End Sub

    Private Sub SCM0300Frm_Load(sender As Object, e As EventArgs) Handles Me.Load
        VersionLabel.Text = SysAppId & " V. " & SysAppVersion

        Dim loException As New SC_Exception
        Dim loService As SCM0300SvcClient
        Dim poparam As New List(Of Object)
        Dim loCompany As List(Of LKM_CompanyDTO)

        Try

            loService = New SCM0300SvcClient
            loCompany = loService.getCompany()
            LKM_CompanyDTOBindingSource.DataSource = New SC_BindingListView(Of LKM_CompanyDTO)(loCompany)
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
