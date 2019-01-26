Imports SC_Common
Imports SC_Win_FrontEnd
Imports MTN0100.MTN0100SvcRef
Imports System.ServiceModel

Public Class MTN0100Frm
    Public Const SysAppId As String = "MTN0100"
    Public Const SysAppVersion As String = "0.00.001"

    Private Sub MTN0100Frm_Load(sender As Object, e As EventArgs) Handles Me.Load
        VersionLabel.Text = SysAppId & " V. " & SysAppVersion

        Dim loException As New SC_Exception
        Dim loService As MTN0100SvcClient
        Dim poparam As New List(Of Object)
        Dim loCompany As New List(Of LKM_CompanyDTO)
        Dim loCompanyOffice As New List(Of LKM_CompanyOfficeDTO)
        Try

            poparam.Clear()
            With poparam
                .Add(SC_GlobalVar.UserId)
            End With

            loService = New MTN0100SvcClient

            loCompany = loService.getCompany(poparam)
            LKM_CompanyDTOBindingSource.DataSource = New SC_BindingListView(Of LKM_CompanyDTO)(loCompany)

            loCompanyOffice = loService.getOffice(poparam)
            LKM_CompanyOfficeDTOBindingSource.DataSource = New SC_BindingListView(Of LKM_CompanyOfficeDTO)(loCompanyOffice)

            SC_Conductor1.CollectADD(Maintenance_DetailDTOSC_DataGridView)
            SC_Conductor1.CollectEDIT(Maintenance_DetailDTOSC_DataGridView)

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

    Private Sub SC_Conductor1_SC_AfterAdd(ByRef poEntity As Object) Handles SC_Conductor1.SC_AfterAdd
        Dim loException As New SC_Exception
        Dim loService As MTN0100SvcClient
        Dim poparam As New List(Of Object)
        Dim poDetail As New List(Of Object)
        Dim loListCompany As New List(Of LKM_CompanyDTO)
        Dim loListCompanyOffice As New List(Of LKM_CompanyOfficeDTO)
        Dim loListDetail As New List(Of Maintenance_DetailDTO)

        Try
            TabControl1.SelectedTab = TabData
            With CType(poEntity, MTN0100DTO01)
                .MAINTENANCE_ID = ""
                .BARCODE = ""
                .COMPANY_ID = ""
                .COMPANY_OFFICE_ID = ""
                .OUTLET_ID = ""
                .OUTLET_NAME = ""
                .FROM_DATE = Now
                .TO_DATE = Now
            End With

            poparam.Add(SC_GlobalVar.UserId)
            poDetail.Add(Nothing)

            loService = New MTN0100SvcClient

            loListCompany = loService.getCompany(poparam)
            LKM_CompanyDTOBindingSource.DataSource = loListCompany

            loListCompanyOffice = loService.getOffice(poparam)
            LKM_CompanyOfficeDTOBindingSource.DataSource = loListCompanyOffice

            loListDetail = loService.getList_Detail(poEntity)
            Maintenance_DetailDTOBindingSource.DataSource = New SC_BindingListView(Of Maintenance_DetailDTO)(loListDetail)
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

    Private Sub SC_Conductor1_SC_AfterCancel(poEntity As Object) Handles SC_Conductor1.SC_AfterCancel
        Dim loException As New SC_Exception
        Dim loService As MTN0100SvcClient

        Try
            loService = New MTN0100SvcClient
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

    Private Sub SC_Conductor1_SC_AfterEdit(ByRef poEntity As Object) Handles SC_Conductor1.SC_AfterEdit
        TabControl1.SelectedTab = TabData
    End Sub

    Private Sub SC_Conductor1_SC_ConvertParentGridEntity(poEntity As Object, ByRef poParentEntity As Object) Handles SC_Conductor1.SC_ConvertParentGridEntity
        Dim loEntity As MTN0100DTO01 = poEntity
        poParentEntity = New MTN0100DTO02

        With CType(poEntity, MTN0100DTO01)
            poParentEntity.MAINTENANCE_ID = .MAINTENANCE_ID
            poParentEntity.COMPANY_ID = .COMPANY_ID
            poParentEntity.COMPANY_OFFICE_ID = .COMPANY_OFFICE_ID
            poParentEntity.FROM_DATE = .FROM_DATE
            poParentEntity.TO_DATE = .TO_DATE
            poParentEntity.BARCODE = .BARCODE
            poParentEntity.OUTLET_ID = .OUTLET_ID
            poParentEntity.OUTLET_NAME = .OUTLET_NAME
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
        With CType(poEntity, MTN0100DTO01)
            .CREA_BY = SC_GlobalVar.UserId
            .UPD_BY = SC_GlobalVar.UserId
        End With
    End Sub

    Private Sub SC_Conductor1_SC_ServiceDelete(poEntity As Object) Handles SC_Conductor1.SC_ServiceDelete
        Dim loException As New SC_Exception
        Dim loService As MTN0100SvcClient

        Try
            loService = New MTN0100SvcClient
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
        Dim loService As MTN0100SvcClient
        Dim loKeyEntity As MTN0100DTO01
        Dim loListDetail As List(Of Maintenance_DetailDTO)

        Try
            loKeyEntity = New MTN0100DTO01
            With CType(poEntity, MTN0100DTO02)
                loKeyEntity.MAINTENANCE_ID = .MAINTENANCE_ID
            End With

            loService = New MTN0100SvcClient

            loListDetail = loService.getList_Detail(loKeyEntity)
            Maintenance_DetailDTOBindingSource.DataSource = New SC_BindingListView(Of Maintenance_DetailDTO)(loListDetail)

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
        Dim loService As MTN0100SvcClient
        Dim loList As List(Of MTN0100DTO02)
        Dim poparam As New List(Of Object)

        Try
            If CheckLimit.CheckState = Windows.Forms.CheckState.Checked Then
                poparam.Add(TxtLimit.Text)
            Else
                poparam.Add(Nothing)
            End If

            If TanggalSC_CheckBox.CheckState = Windows.Forms.CheckState.Checked Then
                poparam.Add(DariSC_DateTimePicker.Value)
                poparam.Add(KeSC_DateTimePicker.Value)
            Else
                poparam.Add(Nothing)
                poparam.Add(Nothing)
            End If

            loService = New MTN0100SvcClient
            loList = loService.getList(poparam)
            MTN0100DTO02BindingSource.DataSource = New SC_BindingListView(Of MTN0100DTO02)(loList)
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
        Dim loService As MTN0100SvcClient
        Dim loDetail As New List(Of Maintenance_DetailDTO)

        Try
            loDetail.AddRange(Maintenance_DetailDTOBindingSource.List)

            With CType(poEntity, MTN0100DTO01)
                .MAINTENANCE_DETAIL = New List(Of Maintenance_DetailDTO)
                .MAINTENANCE_DETAIL.AddRange(loDetail)
            End With

            loService = New MTN0100SvcClient
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

            If String.IsNullOrEmpty(BARCODESC_TextBox.Text) Then
                lcErr = "Barcode Aset harus diisi"
                loException.Add("Validasi", lcErr)
                SC_ErrorProvider1.SetError(BARCODESC_TextBox, lcErr)
            End If
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Sub

    Private Sub GoodSC_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles GoodSC_CheckBox.CheckedChanged
        If GoodSC_CheckBox.Checked = True Then
            For Each row As Maintenance_DetailDTO In Maintenance_DetailDTOBindingSource
                row.GOOD = GoodSC_CheckBox.Checked
            Next
            Maintenance_DetailDTOSC_DataGridView.Refresh()
        Else
            For Each row As Maintenance_DetailDTO In Maintenance_DetailDTOBindingSource
                row.GOOD = GoodSC_CheckBox.Checked
            Next
            Maintenance_DetailDTOSC_DataGridView.Refresh()
        End If
        
    End Sub

    Private Sub OutletSC_LookUp_SC_Before_Open_Form(ByRef poTargetForm As SC_FormBase, ByRef poParameter As Object) Handles OutletSC_LookUp.SC_Before_Open_Form
        Dim poParam As New List(Of Object)

        poParam.Add(Nothing)
        poParameter = poParam
        poTargetForm = New MTN0100Frm_LKM_Outlet
    End Sub

    Private Sub OutletSC_LookUp_SC_Return_LookUp(poReturnObject As Object) Handles OutletSC_LookUp.SC_Return_LookUp
        MTN0100DTO01BindingSource.Current.OUTLET_ID = poReturnObject.OUTLET_ID
        MTN0100DTO01BindingSource.Current.OUTLET_NAME = poReturnObject.OUTLET_NAME
    End Sub

    Private Sub OUTLET_IDSC_TextBox_Validated(sender As Object, e As EventArgs) Handles OUTLET_IDSC_TextBox.Validated
        Dim loException As New SC_Exception
        Dim poparam As New List(Of Object)
        Dim loService As MTN0100SvcClient
        Dim loOutlet As LKM_OutletDTO

        Try
           
            poparam.Add(OUTLET_IDSC_TextBox.Text)

            loService = New MTN0100SvcClient
            loOutlet = loService.getOutlet(poparam).FirstOrDefault

            If loOutlet IsNot Nothing Then
                MTN0100DTO01BindingSource.Current.OUTLET_ID = loOutlet.OUTLET_ID
                MTN0100DTO01BindingSource.Current.OUTLET_NAME = loOutlet.OUTLET_NAME
            Else
                MTN0100DTO01BindingSource.Current.OUTLET_ID = Nothing
                MTN0100DTO01BindingSource.Current.OUTLET_NAME = Nothing
            End If
            
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

    Private Sub CheckLimit_CheckedChanged(sender As Object, e As EventArgs) Handles CheckLimit.CheckedChanged
        If CheckLimit.Checked = True Then
            TxtLimit.Enabled = True
        Else
            TxtLimit.Enabled = False
        End If
    End Sub

    Private Sub CheckLimit_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles CheckLimit.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CheckLimit_TextChanged(sender As Object, e As EventArgs) Handles CheckLimit.TextChanged
        If TxtLimit.Text = "" Then
            TxtLimit.Text = 0
        End If
    End Sub

    Private Sub TanggalSC_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles TanggalSC_CheckBox.CheckedChanged
        If TanggalSC_CheckBox.Checked = True Then
            DariSC_DateTimePicker.Enabled = True
            KeSC_DateTimePicker.Enabled = True
        Else
            DariSC_DateTimePicker.Enabled = False
            KeSC_DateTimePicker.Enabled = False
        End If
    End Sub
End Class
