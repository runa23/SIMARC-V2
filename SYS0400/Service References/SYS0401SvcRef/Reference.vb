﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Runtime.Serialization

Namespace SYS0401SvcRef
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="SC_DTOBase", [Namespace]:="http://schemas.datacontract.org/2004/07/SC_BackEnd"),  _
     System.SerializableAttribute(),  _
     System.Runtime.Serialization.KnownTypeAttribute(GetType(SYS0401SvcRef.SYS0401DTO01))>  _
    Partial Public Class SC_DTOBase
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="SYS0401DTO01", [Namespace]:="http://schemas.datacontract.org/2004/07/SYS0400Back"),  _
     System.SerializableAttribute()>  _
    Partial Public Class SYS0401DTO01
        Inherits SYS0401SvcRef.SC_DTOBase
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private ADD_PERMITField As Boolean
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private APP_IDField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private APP_NAMEField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private CREA_BYField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private CREA_DATEField As Date
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private DELETE_PERMITField As Boolean
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private EDIT_PERMITField As Boolean
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private READ_PERMITField As Boolean
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private ROLE_IDField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private UPD_BYField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private UPD_DATEField As Date
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property ADD_PERMIT() As Boolean
            Get
                Return Me.ADD_PERMITField
            End Get
            Set
                If (Me.ADD_PERMITField.Equals(value) <> true) Then
                    Me.ADD_PERMITField = value
                    Me.RaisePropertyChanged("ADD_PERMIT")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property APP_ID() As String
            Get
                Return Me.APP_IDField
            End Get
            Set
                If (Object.ReferenceEquals(Me.APP_IDField, value) <> true) Then
                    Me.APP_IDField = value
                    Me.RaisePropertyChanged("APP_ID")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property APP_NAME() As String
            Get
                Return Me.APP_NAMEField
            End Get
            Set
                If (Object.ReferenceEquals(Me.APP_NAMEField, value) <> true) Then
                    Me.APP_NAMEField = value
                    Me.RaisePropertyChanged("APP_NAME")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property CREA_BY() As String
            Get
                Return Me.CREA_BYField
            End Get
            Set
                If (Object.ReferenceEquals(Me.CREA_BYField, value) <> true) Then
                    Me.CREA_BYField = value
                    Me.RaisePropertyChanged("CREA_BY")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property CREA_DATE() As Date
            Get
                Return Me.CREA_DATEField
            End Get
            Set
                If (Me.CREA_DATEField.Equals(value) <> true) Then
                    Me.CREA_DATEField = value
                    Me.RaisePropertyChanged("CREA_DATE")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property DELETE_PERMIT() As Boolean
            Get
                Return Me.DELETE_PERMITField
            End Get
            Set
                If (Me.DELETE_PERMITField.Equals(value) <> true) Then
                    Me.DELETE_PERMITField = value
                    Me.RaisePropertyChanged("DELETE_PERMIT")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property EDIT_PERMIT() As Boolean
            Get
                Return Me.EDIT_PERMITField
            End Get
            Set
                If (Me.EDIT_PERMITField.Equals(value) <> true) Then
                    Me.EDIT_PERMITField = value
                    Me.RaisePropertyChanged("EDIT_PERMIT")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property READ_PERMIT() As Boolean
            Get
                Return Me.READ_PERMITField
            End Get
            Set
                If (Me.READ_PERMITField.Equals(value) <> true) Then
                    Me.READ_PERMITField = value
                    Me.RaisePropertyChanged("READ_PERMIT")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property ROLE_ID() As String
            Get
                Return Me.ROLE_IDField
            End Get
            Set
                If (Object.ReferenceEquals(Me.ROLE_IDField, value) <> true) Then
                    Me.ROLE_IDField = value
                    Me.RaisePropertyChanged("ROLE_ID")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property UPD_BY() As String
            Get
                Return Me.UPD_BYField
            End Get
            Set
                If (Object.ReferenceEquals(Me.UPD_BYField, value) <> true) Then
                    Me.UPD_BYField = value
                    Me.RaisePropertyChanged("UPD_BY")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property UPD_DATE() As Date
            Get
                Return Me.UPD_DATEField
            End Get
            Set
                If (Me.UPD_DATEField.Equals(value) <> true) Then
                    Me.UPD_DATEField = value
                    Me.RaisePropertyChanged("UPD_DATE")
                End If
            End Set
        End Property
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="eCRUDMode", [Namespace]:="http://schemas.datacontract.org/2004/07/SC_BackEnd")>  _
    Public Enum eCRUDMode As Integer
        
        <System.Runtime.Serialization.EnumMemberAttribute()>  _
        NormalMode = 0
        
        <System.Runtime.Serialization.EnumMemberAttribute()>  _
        AddMode = 1
        
        <System.Runtime.Serialization.EnumMemberAttribute()>  _
        EditMode = 2
        
        <System.Runtime.Serialization.EnumMemberAttribute()>  _
        DeleteMode = 3
    End Enum
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="SYS0401DTO02", [Namespace]:="http://schemas.datacontract.org/2004/07/SYS0400Back"),  _
     System.SerializableAttribute()>  _
    Partial Public Class SYS0401DTO02
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private ADD_PERMITField As Boolean
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private APP_IDField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private APP_NAMEField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private CREA_BYField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private CREA_DATEField As Date
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private DELETE_PERMITField As Boolean
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private EDIT_PERMITField As Boolean
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private READ_PERMITField As Boolean
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private ROLE_IDField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private UPD_BYField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private UPD_DATEField As Date
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property ADD_PERMIT() As Boolean
            Get
                Return Me.ADD_PERMITField
            End Get
            Set
                If (Me.ADD_PERMITField.Equals(value) <> true) Then
                    Me.ADD_PERMITField = value
                    Me.RaisePropertyChanged("ADD_PERMIT")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property APP_ID() As String
            Get
                Return Me.APP_IDField
            End Get
            Set
                If (Object.ReferenceEquals(Me.APP_IDField, value) <> true) Then
                    Me.APP_IDField = value
                    Me.RaisePropertyChanged("APP_ID")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property APP_NAME() As String
            Get
                Return Me.APP_NAMEField
            End Get
            Set
                If (Object.ReferenceEquals(Me.APP_NAMEField, value) <> true) Then
                    Me.APP_NAMEField = value
                    Me.RaisePropertyChanged("APP_NAME")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property CREA_BY() As String
            Get
                Return Me.CREA_BYField
            End Get
            Set
                If (Object.ReferenceEquals(Me.CREA_BYField, value) <> true) Then
                    Me.CREA_BYField = value
                    Me.RaisePropertyChanged("CREA_BY")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property CREA_DATE() As Date
            Get
                Return Me.CREA_DATEField
            End Get
            Set
                If (Me.CREA_DATEField.Equals(value) <> true) Then
                    Me.CREA_DATEField = value
                    Me.RaisePropertyChanged("CREA_DATE")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property DELETE_PERMIT() As Boolean
            Get
                Return Me.DELETE_PERMITField
            End Get
            Set
                If (Me.DELETE_PERMITField.Equals(value) <> true) Then
                    Me.DELETE_PERMITField = value
                    Me.RaisePropertyChanged("DELETE_PERMIT")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property EDIT_PERMIT() As Boolean
            Get
                Return Me.EDIT_PERMITField
            End Get
            Set
                If (Me.EDIT_PERMITField.Equals(value) <> true) Then
                    Me.EDIT_PERMITField = value
                    Me.RaisePropertyChanged("EDIT_PERMIT")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property READ_PERMIT() As Boolean
            Get
                Return Me.READ_PERMITField
            End Get
            Set
                If (Me.READ_PERMITField.Equals(value) <> true) Then
                    Me.READ_PERMITField = value
                    Me.RaisePropertyChanged("READ_PERMIT")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property ROLE_ID() As String
            Get
                Return Me.ROLE_IDField
            End Get
            Set
                If (Object.ReferenceEquals(Me.ROLE_IDField, value) <> true) Then
                    Me.ROLE_IDField = value
                    Me.RaisePropertyChanged("ROLE_ID")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property UPD_BY() As String
            Get
                Return Me.UPD_BYField
            End Get
            Set
                If (Object.ReferenceEquals(Me.UPD_BYField, value) <> true) Then
                    Me.UPD_BYField = value
                    Me.RaisePropertyChanged("UPD_BY")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property UPD_DATE() As Date
            Get
                Return Me.UPD_DATEField
            End Get
            Set
                If (Me.UPD_DATEField.Equals(value) <> true) Then
                    Me.UPD_DATEField = value
                    Me.RaisePropertyChanged("UPD_DATE")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="LKMSys_AppDTO", [Namespace]:="http://schemas.datacontract.org/2004/07/SYS0400Back"),  _
     System.SerializableAttribute()>  _
    Partial Public Class LKMSys_AppDTO
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private APP_DESCField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private APP_IDField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private APP_NAMEField As String
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property APP_DESC() As String
            Get
                Return Me.APP_DESCField
            End Get
            Set
                If (Object.ReferenceEquals(Me.APP_DESCField, value) <> true) Then
                    Me.APP_DESCField = value
                    Me.RaisePropertyChanged("APP_DESC")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property APP_ID() As String
            Get
                Return Me.APP_IDField
            End Get
            Set
                If (Object.ReferenceEquals(Me.APP_IDField, value) <> true) Then
                    Me.APP_IDField = value
                    Me.RaisePropertyChanged("APP_ID")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property APP_NAME() As String
            Get
                Return Me.APP_NAMEField
            End Get
            Set
                If (Object.ReferenceEquals(Me.APP_NAMEField, value) <> true) Then
                    Me.APP_NAMEField = value
                    Me.RaisePropertyChanged("APP_NAME")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="SYS0401SvcRef.ISYS0401Svc")>  _
    Public Interface ISYS0401Svc
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/SC_IServicebaseOf_SYS0401DTO01/Svc_SC_GetRecord", ReplyAction:="http://tempuri.org/SC_IServicebaseOf_SYS0401DTO01/Svc_SC_GetRecordResponse"),  _
         System.ServiceModel.FaultContractAttribute(GetType(SC_Common.SC_ServiceExceptions), Action:="http://tempuri.org/SC_IServicebaseOf_SYS0401DTO01/Svc_SC_GetRecordSC_ServiceExcep"& _ 
            "tionsFault", Name:="SC_ServiceExceptions", [Namespace]:="http://schemas.datacontract.org/2004/07/SC_Common")>  _
        Function Svc_SC_GetRecord(ByVal poEntity As SYS0401SvcRef.SYS0401DTO01, ByVal poCRUDMode As SYS0401SvcRef.eCRUDMode) As SYS0401SvcRef.SYS0401DTO01
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/SC_IServicebaseOf_SYS0401DTO01/Svc_SC_GetRecord", ReplyAction:="http://tempuri.org/SC_IServicebaseOf_SYS0401DTO01/Svc_SC_GetRecordResponse")>  _
        Function Svc_SC_GetRecordAsync(ByVal poEntity As SYS0401SvcRef.SYS0401DTO01, ByVal poCRUDMode As SYS0401SvcRef.eCRUDMode) As System.Threading.Tasks.Task(Of SYS0401SvcRef.SYS0401DTO01)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/SC_IServicebaseOf_SYS0401DTO01/Svc_SC_Save", ReplyAction:="http://tempuri.org/SC_IServicebaseOf_SYS0401DTO01/Svc_SC_SaveResponse"),  _
         System.ServiceModel.FaultContractAttribute(GetType(SC_Common.SC_ServiceExceptions), Action:="http://tempuri.org/SC_IServicebaseOf_SYS0401DTO01/Svc_SC_SaveSC_ServiceExceptions"& _ 
            "Fault", Name:="SC_ServiceExceptions", [Namespace]:="http://schemas.datacontract.org/2004/07/SC_Common")>  _
        Function Svc_SC_Save(ByVal poEntity As SYS0401SvcRef.SYS0401DTO01, ByVal poCRUDMode As SYS0401SvcRef.eCRUDMode) As SYS0401SvcRef.SYS0401DTO01
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/SC_IServicebaseOf_SYS0401DTO01/Svc_SC_Save", ReplyAction:="http://tempuri.org/SC_IServicebaseOf_SYS0401DTO01/Svc_SC_SaveResponse")>  _
        Function Svc_SC_SaveAsync(ByVal poEntity As SYS0401SvcRef.SYS0401DTO01, ByVal poCRUDMode As SYS0401SvcRef.eCRUDMode) As System.Threading.Tasks.Task(Of SYS0401SvcRef.SYS0401DTO01)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/SC_IServicebaseOf_SYS0401DTO01/Svc_SC_Delete", ReplyAction:="http://tempuri.org/SC_IServicebaseOf_SYS0401DTO01/Svc_SC_DeleteResponse"),  _
         System.ServiceModel.FaultContractAttribute(GetType(SC_Common.SC_ServiceExceptions), Action:="http://tempuri.org/SC_IServicebaseOf_SYS0401DTO01/Svc_SC_DeleteSC_ServiceExceptio"& _ 
            "nsFault", Name:="SC_ServiceExceptions", [Namespace]:="http://schemas.datacontract.org/2004/07/SC_Common")>  _
        Sub Svc_SC_Delete(ByVal poEntity As SYS0401SvcRef.SYS0401DTO01)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/SC_IServicebaseOf_SYS0401DTO01/Svc_SC_Delete", ReplyAction:="http://tempuri.org/SC_IServicebaseOf_SYS0401DTO01/Svc_SC_DeleteResponse")>  _
        Function Svc_SC_DeleteAsync(ByVal poEntity As SYS0401SvcRef.SYS0401DTO01) As System.Threading.Tasks.Task
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ISYS0401Svc/GetList", ReplyAction:="http://tempuri.org/ISYS0401Svc/GetListResponse"),  _
         System.ServiceModel.FaultContractAttribute(GetType(SC_Common.SC_ServiceExceptions), Action:="http://tempuri.org/ISYS0401Svc/GetListSC_ServiceExceptionsFault", Name:="SC_ServiceExceptions", [Namespace]:="http://schemas.datacontract.org/2004/07/SC_Common")>  _
        Function GetList(ByVal RoleID As String) As System.Collections.Generic.List(Of SYS0401SvcRef.SYS0401DTO02)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ISYS0401Svc/GetList", ReplyAction:="http://tempuri.org/ISYS0401Svc/GetListResponse")>  _
        Function GetListAsync(ByVal RoleID As String) As System.Threading.Tasks.Task(Of System.Collections.Generic.List(Of SYS0401SvcRef.SYS0401DTO02))
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ISYS0401Svc/GetList_App", ReplyAction:="http://tempuri.org/ISYS0401Svc/GetList_AppResponse"),  _
         System.ServiceModel.FaultContractAttribute(GetType(SC_Common.SC_ServiceExceptions), Action:="http://tempuri.org/ISYS0401Svc/GetList_AppSC_ServiceExceptionsFault", Name:="SC_ServiceExceptions", [Namespace]:="http://schemas.datacontract.org/2004/07/SC_Common")>  _
        Function GetList_App(ByVal RoleID As String) As System.Collections.Generic.List(Of SYS0401SvcRef.LKMSys_AppDTO)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ISYS0401Svc/GetList_App", ReplyAction:="http://tempuri.org/ISYS0401Svc/GetList_AppResponse")>  _
        Function GetList_AppAsync(ByVal RoleID As String) As System.Threading.Tasks.Task(Of System.Collections.Generic.List(Of SYS0401SvcRef.LKMSys_AppDTO))
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface ISYS0401SvcChannel
        Inherits SYS0401SvcRef.ISYS0401Svc, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class SYS0401SvcClient
        Inherits System.ServiceModel.ClientBase(Of SYS0401SvcRef.ISYS0401Svc)
        Implements SYS0401SvcRef.ISYS0401Svc
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function Svc_SC_GetRecord(ByVal poEntity As SYS0401SvcRef.SYS0401DTO01, ByVal poCRUDMode As SYS0401SvcRef.eCRUDMode) As SYS0401SvcRef.SYS0401DTO01 Implements SYS0401SvcRef.ISYS0401Svc.Svc_SC_GetRecord
            Return MyBase.Channel.Svc_SC_GetRecord(poEntity, poCRUDMode)
        End Function
        
        Public Function Svc_SC_GetRecordAsync(ByVal poEntity As SYS0401SvcRef.SYS0401DTO01, ByVal poCRUDMode As SYS0401SvcRef.eCRUDMode) As System.Threading.Tasks.Task(Of SYS0401SvcRef.SYS0401DTO01) Implements SYS0401SvcRef.ISYS0401Svc.Svc_SC_GetRecordAsync
            Return MyBase.Channel.Svc_SC_GetRecordAsync(poEntity, poCRUDMode)
        End Function
        
        Public Function Svc_SC_Save(ByVal poEntity As SYS0401SvcRef.SYS0401DTO01, ByVal poCRUDMode As SYS0401SvcRef.eCRUDMode) As SYS0401SvcRef.SYS0401DTO01 Implements SYS0401SvcRef.ISYS0401Svc.Svc_SC_Save
            Return MyBase.Channel.Svc_SC_Save(poEntity, poCRUDMode)
        End Function
        
        Public Function Svc_SC_SaveAsync(ByVal poEntity As SYS0401SvcRef.SYS0401DTO01, ByVal poCRUDMode As SYS0401SvcRef.eCRUDMode) As System.Threading.Tasks.Task(Of SYS0401SvcRef.SYS0401DTO01) Implements SYS0401SvcRef.ISYS0401Svc.Svc_SC_SaveAsync
            Return MyBase.Channel.Svc_SC_SaveAsync(poEntity, poCRUDMode)
        End Function
        
        Public Sub Svc_SC_Delete(ByVal poEntity As SYS0401SvcRef.SYS0401DTO01) Implements SYS0401SvcRef.ISYS0401Svc.Svc_SC_Delete
            MyBase.Channel.Svc_SC_Delete(poEntity)
        End Sub
        
        Public Function Svc_SC_DeleteAsync(ByVal poEntity As SYS0401SvcRef.SYS0401DTO01) As System.Threading.Tasks.Task Implements SYS0401SvcRef.ISYS0401Svc.Svc_SC_DeleteAsync
            Return MyBase.Channel.Svc_SC_DeleteAsync(poEntity)
        End Function
        
        Public Function GetList(ByVal RoleID As String) As System.Collections.Generic.List(Of SYS0401SvcRef.SYS0401DTO02) Implements SYS0401SvcRef.ISYS0401Svc.GetList
            Return MyBase.Channel.GetList(RoleID)
        End Function
        
        Public Function GetListAsync(ByVal RoleID As String) As System.Threading.Tasks.Task(Of System.Collections.Generic.List(Of SYS0401SvcRef.SYS0401DTO02)) Implements SYS0401SvcRef.ISYS0401Svc.GetListAsync
            Return MyBase.Channel.GetListAsync(RoleID)
        End Function
        
        Public Function GetList_App(ByVal RoleID As String) As System.Collections.Generic.List(Of SYS0401SvcRef.LKMSys_AppDTO) Implements SYS0401SvcRef.ISYS0401Svc.GetList_App
            Return MyBase.Channel.GetList_App(RoleID)
        End Function
        
        Public Function GetList_AppAsync(ByVal RoleID As String) As System.Threading.Tasks.Task(Of System.Collections.Generic.List(Of SYS0401SvcRef.LKMSys_AppDTO)) Implements SYS0401SvcRef.ISYS0401Svc.GetList_AppAsync
            Return MyBase.Channel.GetList_AppAsync(RoleID)
        End Function
    End Class
End Namespace