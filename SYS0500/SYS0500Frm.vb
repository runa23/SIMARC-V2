Imports SC_Common
Imports SC_Win_FrontEnd
Imports SYS0500.SYS0500SvcRef
Imports System.ServiceModel

Public Class SYS0500Frm
    Public Const SysAppId As String = "SYS0500"
    Public Const SysAppVersion As String = "0.00.002"

    Private Sub SC_Conductor1_SC_AfterAdd(ByRef poEntity As Object) Handles SC_Conductor1.SC_AfterAdd
        Dim loException As New SC_Exception
        Dim loService As New SYS0500SvcClient
        Dim validto As String = "2099/12/31"
        Dim loRegional As List(Of LKM_RegionalDTO)
        Dim loCompany As List(Of LKM_CompanyDTO)
        Dim loCompanyOffice As List(Of LKM_CompanyOfficeDTO)
        Dim loCompanyOfficeMap As List(Of LKM_Company_Office_MapDTO)
        Dim paramOffice As New List(Of Object)
        Dim paramMap As New List(Of Object)
        Dim paramCompany As New List(Of Object)

        Try
            TabControl1.SelectedTab = TabData

            With CType(poEntity, SYS0500DTO01)
                .REGIONAL = REGIONAL_NAMESC_ComboBox.SelectedValue
                .COMPANY_ID = COMPANY_NAMESC_ComboBox.SelectedValue
                .COMPANY_OFFICE_ID = COMPANY_OFFICE_IDSC_ComboBox.SelectedValue
                .COMPANY_OFFICE_MAP_ID = COMPANY_OFFICE_MAP_IDSC_ComboBox.SelectedValue
                .VALID_FROM = Now
                .VALID_TO = validto
            End With

            loService = New SYS0500SvcClient

            paramOffice.Add(Nothing)
            paramMap.Add(Nothing)
            paramCompany.Add(Nothing)

            loRegional = loService.getRegional()
            LKM_RegionalDTOBindingSource.DataSource = loRegional

            loCompany = loService.getCompany(paramCompany)
            LKM_CompanyDTOBindingSource.DataSource = loCompany

            loCompanyOffice = loService.getCompanyOffice(paramOffice)
            LKM_CompanyOfficeDTOBindingSource.DataSource = loCompanyOffice

            loCompanyOfficeMap = loService.getCompanyOfficeMap(paramMap)
            LKM_Company_Office_MapDTOBindingSource.DataSource = loCompanyOfficeMap

            loService.Close()

            Input_SC_CheckBox.CheckState = Windows.Forms.CheckState.Unchecked

        Catch ex As FaultException(Of SC_ServiceExceptions)
            loException.ErrorList.AddRange(ex.Detail.Exceptions)
        Catch ex As FaultException
            loException.Add(ex)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ThrowExceptionIfErrors()
    End Sub

    Private Sub SC_Conductor1_SC_AfterEdit(ByRef poEntity As Object) Handles SC_Conductor1.SC_AfterEdit
        Input_SC_CheckBox.CheckState = Windows.Forms.CheckState.Unchecked
    End Sub

    Private Sub SC_Conductor1_SC_BeforeEdit(poEntity As Object) Handles SC_Conductor1.SC_BeforeEdit
        TabControl1.SelectedTab = TabData
    End Sub

    Private Sub SC_Conductor1_SC_ConvertParentGridEntity(poEntity As Object, ByRef poParentEntity As Object) Handles SC_Conductor1.SC_ConvertParentGridEntity
        Dim loEntity As SYS0500DTO01 = poEntity
        poParentEntity = New SYS0500DTO02

        With CType(poEntity, SYS0500DTO01)
            poParentEntity.USER_ID = .USER_ID
            poParentEntity.PASSWORD = .PASSWORD
            poParentEntity.REGIONAL = .REGIONAL
            poParentEntity.COMPANY_ID = .COMPANY_ID
            poParentEntity.COMPANY_OFFICE_ID = .COMPANY_OFFICE_ID
            poParentEntity.COMPANY_OFFICE_MAP_ID = .COMPANY_OFFICE_MAP_ID
            poParentEntity.VALID_FROM = .VALID_FROM
            poParentEntity.VALID_TO = .VALID_TO
            poParentEntity.DEFAULT_APP = .DEFAULT_APP
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
        With CType(poEntity, SYS0500DTO01)
            .CREA_BY = SC_GlobalVar.UserId
            .UPD_BY = SC_GlobalVar.UserId
            .INPUT_PASS = Input_SC_CheckBox.Checked
        End With
    End Sub

    Private Sub SC_Conductor1_SC_ServiceDelete(poEntity As Object) Handles SC_Conductor1.SC_ServiceDelete
        Dim loException As New SC_Exception
        Dim loService As New SYS0500SvcClient

        Try
            loService = New SYS0500SvcClient
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
        Dim loService As SYS0500SvcClient
        Dim loKeyEntity As SYS0500DTO01

        Try
            loKeyEntity = New SYS0500DTO01
            With CType(poEntity, SYS0500DTO02)
                loKeyEntity.USER_ID = .USER_ID
            End With

            loService = New SYS0500SvcClient
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
        Dim loService As New SYS0500SvcClient
        Dim loList As List(Of SYS0500DTO02)
        Dim poparam As New List(Of Object)
        Dim loRegional As List(Of LKM_RegionalDTO)
        Dim loCompany As List(Of LKM_CompanyDTO)
        Dim loCompanyOffice As List(Of LKM_CompanyOfficeDTO)
        Dim loCompanyOfficeMap As List(Of LKM_Company_Office_MapDTO)
        Dim paramOffice As New List(Of Object)
        Dim paramMap As New List(Of Object)
        Dim paramCompany As New List(Of Object)

        Try
            loService = New SYS0500SvcClient

            paramOffice.Add(Nothing)
            paramMap.Add(Nothing)
            paramCompany.Add(Nothing)

            loRegional = loService.getRegional()
            LKM_RegionalDTOBindingSource.DataSource = loRegional

            loCompany = loService.getCompany(paramCompany)
            LKM_CompanyDTOBindingSource.DataSource = loCompany

            loCompanyOffice = loService.getCompanyOffice(paramOffice)
            LKM_CompanyOfficeDTOBindingSource.DataSource = loCompanyOffice

            loCompanyOfficeMap = loService.getCompanyOfficeMap(paramMap)
            LKM_Company_Office_MapDTOBindingSource.DataSource = loCompanyOfficeMap

            loList = loService.getList()
            SYS0500DTO02BindingSource.DataSource = New SC_BindingListView(Of SYS0500DTO02)(loList)
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
        Dim loService As SYS0500SvcClient

        Try
            loService = New SYS0500SvcClient
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

    Private Sub Input_SC_CheckBox_CheckStateChanged(sender As Object, e As EventArgs) Handles Input_SC_CheckBox.CheckStateChanged
        If Input_SC_CheckBox.CheckState = Windows.Forms.CheckState.Checked Then
            PASSWORDSC_TextBox.ReadOnly = False
            Confirm_SC_TextBox.ReadOnly = False
        Else
            PASSWORDSC_TextBox.ReadOnly = True
            Confirm_SC_TextBox.ReadOnly = True
        End If
    End Sub

    Private Sub SC_Conductor1_SC_Validation(poEntity As Object, peMode As SC_Conductor.e_Mode) Handles SC_Conductor1.SC_Validation
        Dim loException As New SC_Exception
        Dim lcErr As String = ""

        Try
            SC_ErrorProvider1.Clear()
            If peMode = SC_Conductor.e_Mode.EditMode Then
                If Input_SC_CheckBox.CheckState = Windows.Forms.CheckState.Checked Then
                    If PASSWORDSC_TextBox.Text <> Confirm_SC_TextBox.Text Then
                        lcErr = "Password dan Confirm tidak sama"
                        loException.Add("Validasi", lcErr)
                        SC_ErrorProvider1.SetError(PASSWORDSC_TextBox, lcErr)
                        SC_ErrorProvider1.SetError(Confirm_SC_TextBox, lcErr)
                    End If
                End If
                
            End If
            

            If peMode = SC_Conductor.e_Mode.AddMode Then
                If Input_SC_CheckBox.CheckState = Windows.Forms.CheckState.Unchecked Then
                    lcErr = "Password harus diisi"
                    loException.Add("Validasi", lcErr)
                    SC_ErrorProvider1.SetError(PASSWORDSC_TextBox, lcErr)

                    lcErr = "Confirm Password harus diisi"
                    loException.Add("Validasi", lcErr)
                    SC_ErrorProvider1.SetError(Confirm_SC_TextBox, lcErr)
                End If

                If PASSWORDSC_TextBox.Text <> Confirm_SC_TextBox.Text Then
                    lcErr = "Password dan Confirm tidak sama"
                    loException.Add("Validasi", lcErr)
                    SC_ErrorProvider1.SetError(PASSWORDSC_TextBox, lcErr)
                    SC_ErrorProvider1.SetError(Confirm_SC_TextBox, lcErr)
                End If
            End If

            

            If String.IsNullOrEmpty(PASSWORDSC_TextBox.Text.Trim) = True And Input_SC_CheckBox.CheckState = Windows.Forms.CheckState.Checked Then
                lcErr = "Password harus diisi"
                loException.Add("Validasi", lcErr)
                SC_ErrorProvider1.SetError(PASSWORDSC_TextBox, lcErr)
            End If

            If String.IsNullOrEmpty(Confirm_SC_TextBox.Text.Trim) = True And Input_SC_CheckBox.CheckState = Windows.Forms.CheckState.Checked Then
                lcErr = "Confirm Password harus diisi"
                loException.Add("Validasi", lcErr)
                SC_ErrorProvider1.SetError(Confirm_SC_TextBox, lcErr)
            End If

            If String.IsNullOrEmpty(USER_IDSC_TextBox.Text) Then
                lcErr = "User ID harus diisi"
                loException.Add("Validasi", lcErr)
                SC_ErrorProvider1.SetError(USER_IDSC_TextBox, lcErr)
            End If

            If String.IsNullOrEmpty(REGIONAL_NAMESC_ComboBox.SelectedValue) Then
                lcErr = "Regional harus dipilih"
                loException.Add("Validasi", lcErr)
                SC_ErrorProvider1.SetError(REGIONAL_NAMESC_ComboBox, lcErr)
            End If

            If String.IsNullOrEmpty(COMPANY_NAMESC_ComboBox.SelectedValue) Then
                lcErr = "Company harus dipilih"
                loException.Add("Validasi", lcErr)
                SC_ErrorProvider1.SetError(COMPANY_NAMESC_ComboBox, lcErr)
            End If

            If String.IsNullOrEmpty(COMPANY_OFFICE_IDSC_ComboBox.SelectedValue) Then
                lcErr = "Company Office harus dipilih"
                loException.Add("Validasi", lcErr)
                SC_ErrorProvider1.SetError(COMPANY_OFFICE_IDSC_ComboBox, lcErr)
            End If

            If String.IsNullOrEmpty(COMPANY_OFFICE_MAP_IDSC_ComboBox.SelectedValue) Then
                lcErr = "Company Office Map harus dipilih"
                loException.Add("Validasi", lcErr)
                SC_ErrorProvider1.SetError(COMPANY_OFFICE_MAP_IDSC_ComboBox, lcErr)
            End If

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ThrowExceptionIfErrors()
    End Sub

    Private Sub SYS0500Frm_Load(sender As Object, e As EventArgs) Handles Me.Load
        VersionLabel.Text = SysAppId & " V. " & SysAppVersion

        Dim loException As New SC_Exception
        Dim loService As SYS0500SvcClient
        Dim loRegional As List(Of LKM_RegionalDTO)
        Dim loCompany As List(Of LKM_CompanyDTO)
        Dim loCompanyOffice As List(Of LKM_CompanyOfficeDTO)
        Dim loCompanyOfficeMap As List(Of LKM_Company_Office_MapDTO)
        Dim paramOffice As New List(Of Object)
        Dim paramMap As New List(Of Object)
        Dim paramCompany As New List(Of Object)

        Try
            loService = New SYS0500SvcClient

            paramOffice.Add(Nothing)
            paramMap.Add(Nothing)
            paramCompany.Add(Nothing)

            loRegional = loService.getRegional()
            LKM_RegionalDTOBindingSource.DataSource = loRegional

            loCompany = loService.getCompany(paramCompany)
            LKM_CompanyDTOBindingSource.DataSource = loCompany

            loCompanyOffice = loService.getCompanyOffice(paramOffice)
            LKM_CompanyOfficeDTOBindingSource.DataSource = loCompanyOffice

            loCompanyOfficeMap = loService.getCompanyOfficeMap(paramMap)
            LKM_Company_Office_MapDTOBindingSource.DataSource = loCompanyOfficeMap

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

    Private Sub RoleSC_Detail_SC_Before_Open_Form(ByRef poTargetForm As SC_FormBase, ByRef poParameter As Object) Handles RoleSC_Detail.SC_Before_Open_Form
        poTargetForm = New SYS0501Frm
        poParameter = SYS0500DTO02BindingSource.Current
    End Sub
    Private Sub REGIONAL_NAMESC_ComboBox_Validating(sender As Object, e As ComponentModel.CancelEventArgs) Handles REGIONAL_NAMESC_ComboBox.Validating
        Dim loException As New SC_Exception
        Dim loService As SYS0500SvcClient
        Dim loCompany As List(Of LKM_CompanyDTO)
        Dim param As New List(Of Object)

        Try
            loService = New SYS0500SvcClient

            If Not String.IsNullOrEmpty(REGIONAL_NAMESC_ComboBox.SelectedValue.ToString) Then
                param.Add(REGIONAL_NAMESC_ComboBox.SelectedValue.ToString)
            Else
                param.Add(Nothing)
            End If

            loCompany = loService.getCompany(param)
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

    Private Sub COMPANY_NAMESC_ComboBox_Validating(sender As Object, e As ComponentModel.CancelEventArgs) Handles COMPANY_NAMESC_ComboBox.Validating
        Dim loException As New SC_Exception
        Dim loService As SYS0500SvcClient
        Dim loCompanyOffice As List(Of LKM_CompanyOfficeDTO)
        Dim param As New List(Of Object)

        Try
            loService = New SYS0500SvcClient

            If Not String.IsNullOrEmpty(COMPANY_NAMESC_ComboBox.SelectedValue.ToString) Then
                param.Add(COMPANY_NAMESC_ComboBox.SelectedValue.ToString)
            Else
                param.Add(Nothing)
            End If

            loCompanyOffice = loService.getCompanyOffice(param)
            LKM_CompanyOfficeDTOBindingSource.DataSource = New SC_BindingListView(Of LKM_CompanyOfficeDTO)(loCompanyOffice)

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

    Private Sub COMPANY_OFFICE_IDSC_ComboBox_Validating(sender As Object, e As ComponentModel.CancelEventArgs) Handles COMPANY_OFFICE_IDSC_ComboBox.Validating
        Dim loException As New SC_Exception
        Dim loService As SYS0500SvcClient
        Dim loCompanyOfficeMap As List(Of LKM_Company_Office_MapDTO)
        Dim param As New List(Of Object)

        Try
            loService = New SYS0500SvcClient

            If Not String.IsNullOrEmpty(REGIONAL_NAMESC_ComboBox.SelectedValue.ToString) Then
                param.Add(REGIONAL_NAMESC_ComboBox.SelectedValue.ToString)
            Else
                param.Add(Nothing)
            End If

            If Not String.IsNullOrEmpty(COMPANY_OFFICE_IDSC_ComboBox.SelectedValue.ToString) Then
                param.Add(COMPANY_OFFICE_IDSC_ComboBox.SelectedValue.ToString)
            Else
                param.Add(Nothing)
            End If

            loCompanyOfficeMap = loService.getCompanyOfficeMap(param)
            LKM_Company_Office_MapDTOBindingSource.DataSource = New SC_BindingListView(Of LKM_Company_Office_MapDTO)(loCompanyOfficeMap)

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
