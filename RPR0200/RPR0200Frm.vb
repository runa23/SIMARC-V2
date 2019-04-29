Imports SC_Common
Imports SC_Win_FrontEnd
Imports RPR0200.RPR0200SvcRef
Imports System.ServiceModel

Public Class RPR0200Frm
    Public Const SysAppId As String = "RPR0200"
    Public Const SysAppVersion As String = "0.00.004"

    Private Sub RPR0200Frm_Load(sender As Object, e As EventArgs) Handles Me.Load
        VersionLabel.Text = SysAppId & " V. " & SysAppVersion

        Dim loException As New SC_Exception
        Dim loService As New RPR0200SvcClient
        Dim poparam As New List(Of Object)
        Dim loCompany As New List(Of LKM_CompanyDTO)
        Dim loCompanyOffice As New List(Of LKM_CompanyOfficeDTO)

        Try

            poparam.Clear()

            With poparam
                .Add(SC_GlobalVar.UserId)
            End With

            loService = New RPR0200SvcClient

            loCompany = loService.getCompany(poparam)
            LKM_CompanyDTOBindingSource.DataSource = New SC_BindingListView(Of LKM_CompanyDTO)(loCompany)

            loCompanyOffice = loService.getOffice(poparam)
            LKM_CompanyOfficeDTOBindingSource.DataSource = New SC_BindingListView(Of LKM_CompanyOfficeDTO)(loCompanyOffice)

            SC_Conductor1.CollectADD(Repair_DetailDTOSC_DataGridView)
            SC_Conductor1.CollectEDIT(Repair_DetailDTOSC_DataGridView)

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
        Dim loService As RPR0200SvcClient
        Dim poparam As New List(Of Object)
        Dim poDetail As New List(Of Object)
        Dim loListCompany As New List(Of LKM_CompanyDTO)
        Dim loListOutlet As New List(Of LKM_OutletDTO)
        Dim loListCompanyOffice As New List(Of LKM_CompanyOfficeDTO)
        Dim loListDetail As New List(Of Repair_DetailDTO)

        Try
            TabControl1.SelectedTab = TabData
            With CType(poEntity, RPR0200DTO01)
                .REPAIR_ID = ""
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

            loService = New RPR0200SvcClient

            loListCompany = loService.getCompany(poparam)
            LKM_CompanyDTOBindingSource.DataSource = loListCompany

            loListCompanyOffice = loService.getOffice(poparam)
            LKM_CompanyOfficeDTOBindingSource.DataSource = loListCompanyOffice

            loListDetail = loService.getList_Detail(poEntity)
            Repair_DetailDTOBindingSource.DataSource = New SC_BindingListView(Of Repair_DetailDTO)(loListDetail)

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
        Dim loService As RPR0200SvcClient

        Try
            loService = New RPR0200SvcClient
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
        Dim loEntity As RPR0200DTO01 = poEntity
        poParentEntity = New RPR0200DTO02

        With CType(poEntity, RPR0200DTO01)
            poParentEntity.REPAIR_ID = .REPAIR_ID
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
        With CType(poEntity, RPR0200DTO01)
            .CREA_BY = SC_GlobalVar.UserId
            .UPD_BY = SC_GlobalVar.UserId
            .COMPANY_OFFICE_ID = SC_GlobalVar.CompanyOfficeId
        End With
    End Sub

    Private Sub SC_Conductor1_SC_ServiceDelete(poEntity As Object) Handles SC_Conductor1.SC_ServiceDelete
        Dim loException As New SC_Exception
        Dim loService As RPR0200SvcClient

        Try
            loService = New RPR0200SvcClient
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
        Dim loService As RPR0200SvcClient
        Dim loKeyEntity As RPR0200DTO01
        Dim loListDetail As List(Of Repair_DetailDTO)

        Try
            loKeyEntity = New RPR0200DTO01
            With CType(poEntity, RPR0200DTO02)
                loKeyEntity.REPAIR_ID = .REPAIR_ID
                loKeyEntity.COMPANY_OFFICE_ID = .COMPANY_OFFICE_ID
            End With

            loService = New RPR0200SvcClient

            poEntityResult = loService.Svc_SC_GetRecord(loKeyEntity, eCRUDMode.NormalMode)

            loListDetail = loService.getList_Detail(loKeyEntity)
            Repair_DetailDTOBindingSource.DataSource = New SC_BindingListView(Of Repair_DetailDTO)(loListDetail)

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
        Dim loService As RPR0200SvcClient
        Dim loList As List(Of RPR0200DTO02)
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

            poparam.Add(SC_GlobalVar.CompanyOfficeId)

            loService = New RPR0200SvcClient
            loList = loService.getList(poparam)
            RPR0200DTO02BindingSource.DataSource = New SC_BindingListView(Of RPR0200DTO02)(loList)
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
        Dim loService As RPR0200SvcClient
        Dim loDetail As New List(Of Repair_DetailDTO)

        Try
            loDetail.AddRange(Repair_DetailDTOBindingSource.List)

            With CType(poEntity, RPR0200DTO01)
                .REPAIR_DETAIL = New List(Of Repair_DetailDTO)
                .REPAIR_DETAIL.AddRange(loDetail)
            End With

            loService = New RPR0200SvcClient
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

    Private Sub OutletSC_LookUp_SC_Before_Open_Form(ByRef poTargetForm As SC_FormBase, ByRef poParameter As Object) Handles OutletSC_LookUp.SC_Before_Open_Form
        Dim poParam As New List(Of Object)

        poParam.Add(Nothing)
        poParam.Add(COMPANY_OFFICE_IDSC_ComboBox.SelectedValue)
        poParameter = poParam
        poTargetForm = New RPR0200Frm_LKM_Outlet
    End Sub

    Private Sub OutletSC_LookUp_SC_Return_LookUp(poReturnObject As Object) Handles OutletSC_LookUp.SC_Return_LookUp
        RPR0200DTO01BindingSource.Current.OUTLET_ID = poReturnObject.OUTLET_ID
        RPR0200DTO01BindingSource.Current.OUTLET_NAME = poReturnObject.OUTLET_NAME
    End Sub

    Private Sub OUTLET_IDSC_TextBox_Validated(sender As Object, e As EventArgs) Handles OUTLET_IDSC_TextBox.Validated
        Dim loException As New SC_Exception
        Dim poparam As New List(Of Object)
        Dim loService As RPR0200SvcClient
        Dim loOutlet As LKM_OutletDTO

        Try
            poparam.Add(OUTLET_IDSC_TextBox.Text)
            poparam.Add(COMPANY_OFFICE_IDSC_ComboBox.SelectedValue)

            loService = New RPR0200SvcClient
            loOutlet = loService.getOutlet(poparam).FirstOrDefault

            If loOutlet IsNot Nothing Then
                RPR0200DTO01BindingSource.Current.OUTLET_ID = loOutlet.OUTLET_ID
                RPR0200DTO01BindingSource.Current.OUTLET_NAME = loOutlet.OUTLET_NAME
            Else
                RPR0200DTO01BindingSource.Current.OUTLET_ID = Nothing
                RPR0200DTO01BindingSource.Current.OUTLET_NAME = Nothing
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

    Private Sub SparepartSC_Detail_SC_Before_Open_Form(ByRef poTargetForm As SC_FormBase, ByRef poParameter As Object) Handles SparepartSC_Detail.SC_Before_Open_Form
        Dim poParam As New List(Of Object)

        poParam.Add(Nothing)
        poParam.Add(COMPANY_OFFICE_IDSC_ComboBox.SelectedValue)

        poParameter = poParam
        poTargetForm = New RPR0200Frm_LKM_Sparepart
    End Sub

    Private Sub RPR0200Frm_SC_Return_From_Detail(poOwnedForm As Windows.Forms.Form, pcButtonName As String) Handles Me.SC_Return_From_Detail
        Dim loList As New List(Of LKM_SparepartDTO)
        Dim loEntity As Repair_DetailDTO

        If pcButtonName = "SparepartSC_Detail" Then
            loList.AddRange(CType(poOwnedForm, RPR0200Frm_LKM_Sparepart).getList)

            For Each row As LKM_SparepartDTO In loList
                If row.PILIH = True Then
                    Dim loPartID As String = row.KD_PART
                    Dim loCek = (From A As Repair_DetailDTO In Repair_DetailDTOBindingSource.List Where A.KD_PART = loPartID).Count

                    If loCek <= 0 Then
                        loEntity = New Repair_DetailDTO
                        loEntity.KD_PART = row.KD_PART
                        loEntity.NAMA_PART = row.NAMA_PART
                        loEntity.HARGA_PART = row.HARGA_PART
                        loEntity.QTY_PART = 0
                        loEntity.SATUAN_PART = row.SATUAN_PART
                        Repair_DetailDTOBindingSource.Add(loEntity)
                    End If
                End If
            Next
        End If

    End Sub
End Class
