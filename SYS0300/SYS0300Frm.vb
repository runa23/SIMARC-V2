Imports SC_Common
Imports SC_Win_FrontEnd
Imports SYS0300.SYS0300SvcRef
Imports System.ServiceModel
Imports System.Text
Imports System.IO
Imports System.Reflection
Imports System.Security.Policy

Public Class SYS0300Frm
    Public Const SysAppId As String = "SYS0300"
    Public Const SysAppVersion As String = "0.00.001"

    Private Sub SC_Conductor1_SC_AfterAdd(ByRef poEntity As Object) Handles SC_Conductor1.SC_AfterAdd
        Dim loException As New SC_Exception
        Dim loService As SYS0300SvcClient
        Dim poparam As New List(Of Object)
        'Dim loAppGroup As List(Of LKM_SysAppGroupDTO)
        'Dim loAppType As List(Of LKM_SysAppTypeDTO)
        'Dim loModule As List(Of LKM_SysModuleDTO)

        TabControl1.SelectedTab = TabData

        With CType(poEntity, SYS0300DTO01)
            .APP_ID = ""
            .APP_NAME = ""
            .APP_DESC = ""
            .VERSION = "0"
            APP_GROUP_IDSC_ComboBox.SelectedValue = 0
            .APP_GROUP_ID = APP_GROUP_IDSC_ComboBox.SelectedValue
            APP_TYPESC_ComboBox.SelectedValue = 0
            .APP_TYPE = APP_TYPESC_ComboBox.SelectedValue
            MODULE_IDSC_ComboBox.SelectedValue = 0
            .MODULE_ID = MODULE_IDSC_ComboBox.SelectedValue
            .UPDATE_DLL_FILE = False
        End With

        loService = New SYS0300SvcClient

        'loAppGroup = loService.getAppGroup()
        'LKM_SysAppGroupDTOBindingSource.DataSource = New SC_BindingListView(Of LKM_SysAppGroupDTO)(loAppGroup)
        'loAppType = loService.getAppType()
        'LKM_SysAppTypeDTOBindingSource.DataSource = New SC_BindingListView(Of LKM_SysAppTypeDTO)(loAppType)
        'loModule = loService.getModule()
        'LKM_SysModuleDTOBindingSource.DataSource = New SC_BindingListView(Of LKM_SysModuleDTO)(loModule)

        APP_IDSC_TextBox.Focus()

        loService.Close()

        If loException.Haserror Then
            SC_DisplayException(loException)
        End If
    End Sub

    Private Sub SC_Conductor1_SC_AfterCancel(poEntity As Object) Handles SC_Conductor1.SC_AfterCancel
        Dim loException As New SC_Exception
        Dim loService As New SYS0300SvcClient

        Try
            loService = New SYS0300SvcClient
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

    End Sub

    Private Sub SC_Conductor1_SC_BeforeEdit(poEntity As Object) Handles SC_Conductor1.SC_BeforeEdit
        TabControl1.SelectedTab = TabData
    End Sub

    Private Sub SC_Conductor1_SC_ConvertParentGridEntity(poEntity As Object, ByRef poParentEntity As Object) Handles SC_Conductor1.SC_ConvertParentGridEntity
        Dim loEntity As SYS0300DTO01 = poEntity
        poParentEntity = New SYS0300DTO02

        With CType(poEntity, SYS0300DTO01)
            poParentEntity.APP_ID = .APP_ID
            poParentEntity.APP_GROUP_ID = .APP_GROUP_ID
            poParentEntity.MODULE_ID = .MODULE_ID
            poParentEntity.VERSION = .VERSION
            poParentEntity.APP_NAME = .APP_NAME
            poParentEntity.APP_DESC = .APP_DESC
            poParentEntity.APP_TYPE = .APP_TYPE
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

        With CType(poEntity, SYS0300DTO01)
            .UPDATE_DLL_FILE = False
        End With

        DLL_FILESC_TextBox.Text = ""
    End Sub

    Private Sub SC_Conductor1_SC_Saving(ByRef poEntity As Object, peMode As SC_Conductor.e_Mode) Handles SC_Conductor1.SC_Saving
        With CType(poEntity, SYS0300DTO01)
            .CREA_BY = SC_GlobalVar.UserId
            .UPD_BY = SC_GlobalVar.UserId
        End With
    End Sub

    Private Sub SC_Conductor1_SC_ServiceDelete(poEntity As Object) Handles SC_Conductor1.SC_ServiceDelete
        Dim loException As New SC_Exception
        Dim loService As SYS0300SvcClient

        Try
            loService = New SYS0300SvcClient
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
        Dim loService As SYS0300SvcClient
        Dim loKeyEntity As SYS0300DTO01

        Try
            loKeyEntity = New SYS0300DTO01
            With CType(poEntity, SYS0300DTO02)
                loKeyEntity.APP_ID = .APP_ID
            End With

            loService = New SYS0300SvcClient
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
        Dim loService As SYS0300SvcClient
        Dim poparam As New List(Of Object)
        Dim loList As List(Of SYS0300DTO02)

        Try
            APP_NAMESC_TextBox.CharacterCasing = Windows.Forms.CharacterCasing.Normal
            APP_DESCSC_TextBox.CharacterCasing = Windows.Forms.CharacterCasing.Normal

            loService = New SYS0300SvcClient

            loList = loService.getList(poparam)
            SYS0300DTO02BindingSource.DataSource = New SC_BindingListView(Of SYS0300DTO02)(loList)
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
        Dim loService As SYS0300SvcClient

        Try
            loService = New SYS0300SvcClient
            poEntityResult = loService.Svc_SC_Save(poEntity, _
                                                   IIf(peMode = SC_Conductor.e_Mode.AddMode, _
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
            SC_ErrorProvider1.Clear()

            If String.IsNullOrEmpty(APP_DESCSC_TextBox.Text.Trim) Then
                lcErr = "APP DESC harus diisi"
                loException.Add("Validasi", lcErr)
                SC_ErrorProvider1.SetError(APP_DESCSC_TextBox, lcErr)
            End If

            If String.IsNullOrEmpty(APP_GROUP_IDSC_ComboBox.SelectedValue) Then
                lcErr = "APP GROUP harus diisi"
                loException.Add("Validasi", lcErr)
                SC_ErrorProvider1.SetError(APP_GROUP_IDSC_ComboBox, lcErr)
            End If

            If String.IsNullOrEmpty(APP_IDSC_TextBox.Text) Then
                lcErr = "APP ID harus diisi"
                loException.Add("Validasi", lcErr)
                SC_ErrorProvider1.SetError(APP_IDSC_TextBox, lcErr)
            End If

            If String.IsNullOrEmpty(APP_NAMESC_TextBox.Text) Then
                lcErr = "APP NAME harus diisi"
                loException.Add("Validasi", lcErr)
                SC_ErrorProvider1.SetError(APP_NAMESC_TextBox, lcErr)
            End If

            If String.IsNullOrEmpty(APP_TYPESC_ComboBox.SelectedValue) Then
                lcErr = "APP TYPE harus diisi"
                loException.Add("Validasi", lcErr)
                SC_ErrorProvider1.SetError(APP_TYPESC_ComboBox, lcErr)
            End If

            If String.IsNullOrEmpty(VERSIONSC_TextBox.Text.Trim) Then
                lcErr = "VERSION harus diisi"
                loException.Add("Validasi", lcErr)
                SC_ErrorProvider1.SetError(VERSIONSC_TextBox, lcErr)
            End If

            If String.IsNullOrEmpty(MODULE_IDSC_ComboBox.SelectedValue) Then
                lcErr = "MODULE harus diisi"
                loException.Add("Validasi", lcErr)
                SC_ErrorProvider1.SetError(MODULE_IDSC_ComboBox, lcErr)
            End If

            If CType(poEntity, SYS0300DTO01).UPDATE_DLL_FILE AndAlso VERSIONSC_TextBox.Text >= DLL_FILE_VERSIONSC_TextBox.Text Then
                lcErr = "DLL File Version harus lebh besar dari version saat ini"
                loException.Add("Validasi", lcErr)
                SC_ErrorProvider1.SetError(VERSIONSC_TextBox, lcErr)
                SC_ErrorProvider1.SetError(DLL_FILE_VERSIONSC_TextBox, lcErr)
            End If

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Sub

    Private Sub SYS0300Frm_Load(sender As Object, e As EventArgs) Handles Me.Load
        VersionLabel.Text = SysAppId & " V. " & SysAppVersion

        Dim loException As New SC_Exception
        Dim loService As SYS0300SvcClient
        Dim poparam As New List(Of Object)
        Dim loAppGroup As List(Of LKM_SysAppGroupDTO)
        Dim loAppType As List(Of LKM_SysAppTypeDTO)
        Dim loModule As List(Of LKM_SysModuleDTO)

        Try
            APP_NAMESC_TextBox.CharacterCasing = Windows.Forms.CharacterCasing.Normal
            APP_DESCSC_TextBox.CharacterCasing = Windows.Forms.CharacterCasing.Normal

            loService = New SYS0300SvcClient

            loAppGroup = loService.getAppGroup()
            LKM_SysAppGroupDTOBindingSource.DataSource = loAppGroup
            loAppType = loService.getAppType()
            LKM_SysAppTypeDTOBindingSource.DataSource = loAppType
            loModule = loService.getModule()
            LKM_SysModuleDTOBindingSource.DataSource = loModule

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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If Label1.Text = "Query>>" Then
            Label1.Text = "<<Hide"
            Panel1.Height = 200
        Else
            Label1.Text = "Querry>>"
            Panel1.Height = 20
        End If
    End Sub

    Private Sub DllFileBrowseSC_Button_Click(sender As Object, e As EventArgs) Handles DllFileBrowseSC_Button.Click
        Dim loException As New SC_Exception
        Dim lcErr As String

        Try
            If String.IsNullOrEmpty(APP_IDSC_TextBox.Text) Then
                lcErr = "App ID harus diisi"
                Exit Try
            End If
            OpenFileDialog1.Title = "App Dll File"
            OpenFileDialog1.Filter = "*.dll;*.exe|*.dll;*.exe;"

            OpenFileDialog1.ShowDialog()
        Catch ex As Exception
            loException.Add(ex)
        End Try

        If loException.Haserror Then
            SC_DisplayException(loException)
        End If
    End Sub

    Private Function ReadDll(ByVal ObjectName As String, ByVal pcFileDll As String, Optional ByVal args() As Object = Nothing) As Form
        Dim loAsm As Assembly
        Dim lcPath As String
        Dim loType As Type
        Dim returnObj As Object = Nothing
        Dim lcNameSpace As String = Me.GetType().Namespace()
        'Dim domain As System.AppDomain

        lcPath = pcFileDll

        loType = Assembly.GetExecutingAssembly().GetType(lcNameSpace.Trim + "." + ObjectName)

        'domain = System.AppDomain.CreateDomain(objectName)

        Dim reader As System.IO.StreamReader
        reader = New System.IO.StreamReader(lcPath, System.Text.Encoding.GetEncoding(1252), False)

        Dim b(reader.BaseStream.Length) As Byte
        reader.BaseStream.Read(b, 0, System.Convert.ToInt32(reader.BaseStream.Length))

        If loType Is Nothing Then

            If File.Exists(lcPath) Then
                'loAsm = domain.Load(b)
                loAsm = Assembly.Load(b)
                loType = loAsm.GetType(ObjectName.Trim + "." + ObjectName.Trim + "Frm", False, True)
                If loType Is Nothing Then
                    Throw New Exception("Type " + ObjectName.Trim + "." + ObjectName.Trim + " - not found")
                End If
            Else
                Throw New Exception(lcPath.Trim + " - not found")
            End If
        End If
        returnObj = Activator.CreateInstance(loType, args)

        reader.Close()
        ' AppDomain.Unload(domain)

        Return returnObj
    End Function

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim loexception As New SC_Exception
        Dim lcFile As String
        Dim loForm As Object

        Try

            SYS0300DTO01BindingSource.Current.DLL_FILE = Nothing
            SYS0300DTO01BindingSource.Current.DLL_FILE_VERSION = ""

            lcFile = OpenFileDialog1.FileName.ToString()
            DLL_FILESC_TextBox.Text = lcFile

            loForm = ReadDll(APP_IDSC_TextBox.Text.Trim, lcFile)

            If loForm.SysAppId Is Nothing Then
                loexception.Add("01", "SysAppId tidak ditemukan di file DLL")
            Else
                If APP_IDSC_TextBox.Text <> loForm.SysAppId Then
                    loexception.Add("01", "App Id tidak sesuai SysAppId di file DLL")
                    Exit Try
                End If
            End If

            If loForm.SysAppVersion Is Nothing Then
                loexception.Add("01", "SysAppVersion tidak ditemukan di file DLL")
                Exit Try
            Else
                SYS0300DTO01BindingSource.Current.DLL_FILE = GetByteFromFile(lcFile)
                SYS0300DTO01BindingSource.Current.DLL_FILE_VERSION = loForm.SysAppVersion
            End If



        Catch ex As Exception
            loexception.Add(ex)
        End Try

        If loexception.Haserror Then
            SC_DisplayException(loexception)
        End If
    End Sub

    Public Shared Function GetByteFromFile(ByVal pcFile As String) As Byte()
        Dim loRtn As Byte()
        Dim loFs As FileStream
        Dim loBr As BinaryReader

        Try
            loFs = New FileStream(pcFile, FileMode.Open)
            loBr = New BinaryReader(loFs)
            loRtn = New Byte(loFs.Length - 1) {}
            loBr.Read(loRtn, 0, System.Convert.ToInt32(loFs.Length))


        Finally
            If loBr IsNot Nothing Then
                loBr.Close()
            End If
            If loFs IsNot Nothing Then
                loFs.Close()
            End If
        End Try

        Return loRtn
    End Function

    Private Sub UPDATE_DLL_FILESC_CheckBox_CheckStateChanged(sender As Object, e As EventArgs) Handles UPDATE_DLL_FILESC_CheckBox.CheckStateChanged
        DllFileBrowseSC_Button.Enabled = UPDATE_DLL_FILESC_CheckBox.Checked
        DLL_FILESC_TextBox.Enabled = UPDATE_DLL_FILESC_CheckBox.Checked
        DLL_FILE_VERSIONSC_TextBox.Enabled = UPDATE_DLL_FILESC_CheckBox.Checked
    End Sub
End Class
