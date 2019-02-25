Imports SC_Common
Imports SC_Win_FrontEnd
Imports RPR0100.RPR0100SvcRef
Imports System.ServiceModel
Public Class RPR0100Frm
    Public Const SysAppId As String = "RPR0100"
    Public Const SysAppVersion As String = "0.00.002"

    Private Sub RPR0100Frm_Load(sender As Object, e As EventArgs) Handles Me.Load
        VersionLabel.Text = SysAppId & " V. " & SysAppVersion

        Dim loException As New SC_Exception
        Dim loService As New RPR0100SvcClient

        Try
            loService = New RPR0100SvcClient
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
        Dim loService As RPR0100SvcClient

        TabControl1.SelectedTab = TabData

        With CType(poEntity, RPR0100DTO01)
            .KD_PART = ""
            .NAMA_PART = ""
            .HARGA_PART = 0
            .STOCK_PART = 0
            .SATUAN_PART = ""
            .COMPANY_OFFICE_ID = ""
        End With

        loService = New RPR0100SvcClient
        loService.Close()
    End Sub

    Private Sub SC_Conductor1_SC_AfterCancel(poEntity As Object) Handles SC_Conductor1.SC_AfterCancel
        Dim loException As New SC_Exception
        Dim loService As New RPR0100SvcClient

        Try
            loService = New RPR0100SvcClient
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
        Dim loEntity As RPR0100DTO01 = poEntity
        poParentEntity = New RPR0100DTO02

        With CType(poEntity, RPR0100DTO01)
            poParentEntity.COMPANY_OFFICE_ID = .COMPANY_OFFICE_ID
            poParentEntity.KD_PART = .KD_PART
            poParentEntity.NAMA_PART = .NAMA_PART
            poParentEntity.HARGA_PART = .HARGA_PART
            poParentEntity.STOCK_PART = .STOCK_PART
            poParentEntity.SATUAN_PART = .SATUAN_PART
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
        With CType(poEntity, RPR0100DTO01)
            .CREA_BY = SC_GlobalVar.UserId
            .UPD_BY = SC_GlobalVar.UserId
            .COMPANY_OFFICE_ID = SC_GlobalVar.CompanyOfficeId
        End With
    End Sub

    Private Sub SC_Conductor1_SC_ServiceDelete(poEntity As Object) Handles SC_Conductor1.SC_ServiceDelete
        Dim loException As New SC_Exception
        Dim loService As New RPR0100SvcClient

        Try
            loService = New RPR0100SvcClient
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
        Dim loService As RPR0100SvcClient
        Dim loKeyEntity As RPR0100DTO01

        Try
            loKeyEntity = New RPR0100DTO01
            With CType(poEntity, RPR0100DTO02)
                loKeyEntity.KD_PART = .KD_PART
                loKeyEntity.COMPANY_OFFICE_ID = .COMPANY_OFFICE_ID
            End With

            loService = New RPR0100SvcClient
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
        Dim loService As RPR0100SvcClient
        Dim loList As List(Of RPR0100DTO02)
        Dim poparam As New List(Of Object)

        Try
            poparam.Add(SC_GlobalVar.CompanyOfficeId)

            loService = New RPR0100SvcClient

            loList = loService.getList(poparam)
            RPR0100DTO02BindingSource.DataSource = New SC_BindingListView(Of RPR0100DTO02)(loList)
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
        Dim loService As RPR0100SvcClient

        Try
            loService = New RPR0100SvcClient
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

            If String.IsNullOrEmpty(NAMA_PARTSC_TextBox.Text) Then
                lcErr = "Nama Sparepart harus diisi"
                loException.Add("Validasi", lcErr)
                SC_ErrorProvider1.SetError(NAMA_PARTSC_TextBox, lcErr)
            End If

            If String.IsNullOrEmpty(HARGA_PARTSC_TextBox.Text) Then
                lcErr = "Harga harus diisi"
                loException.Add("Validasi", lcErr)
                SC_ErrorProvider1.SetError(HARGA_PARTSC_TextBox, lcErr)
            End If

            If String.IsNullOrEmpty(STOCK_PARTSC_TextBox.Text) Then
                lcErr = "Stock harus diisi"
                loException.Add("Validasi", lcErr)
                SC_ErrorProvider1.SetError(STOCK_PARTSC_TextBox, lcErr)
            End If

            If String.IsNullOrEmpty(SATUAN_PARTSC_TextBox.Text) Then
                lcErr = "Satuan harus diisi"
                loException.Add("Validasi", lcErr)
                SC_ErrorProvider1.SetError(SATUAN_PARTSC_TextBox, lcErr)
            End If
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ThrowExceptionIfErrors()
    End Sub
End Class
