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

Namespace SYS0100SvcRef
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="SC_DTOBase", [Namespace]:="http://schemas.datacontract.org/2004/07/SC_BackEnd"),  _
     System.SerializableAttribute(),  _
     System.Runtime.Serialization.KnownTypeAttribute(GetType(SYS0100SvcRef.SYS0100DTO01))>  _
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
     System.Runtime.Serialization.DataContractAttribute(Name:="SYS0100DTO01", [Namespace]:="http://schemas.datacontract.org/2004/07/SYS0100Back"),  _
     System.SerializableAttribute()>  _
    Partial Public Class SYS0100DTO01
        Inherits SYS0100SvcRef.SC_DTOBase
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private APP_GROUP_IDField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private APP_GROUP_NAMEField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private CREA_BYField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private CREA_DATEField As Date
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private UPD_BYField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private UPD_DATEField As Date
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property APP_GROUP_ID() As String
            Get
                Return Me.APP_GROUP_IDField
            End Get
            Set
                If (Object.ReferenceEquals(Me.APP_GROUP_IDField, value) <> true) Then
                    Me.APP_GROUP_IDField = value
                    Me.RaisePropertyChanged("APP_GROUP_ID")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property APP_GROUP_NAME() As String
            Get
                Return Me.APP_GROUP_NAMEField
            End Get
            Set
                If (Object.ReferenceEquals(Me.APP_GROUP_NAMEField, value) <> true) Then
                    Me.APP_GROUP_NAMEField = value
                    Me.RaisePropertyChanged("APP_GROUP_NAME")
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
     System.Runtime.Serialization.DataContractAttribute(Name:="SYS0100DTO02", [Namespace]:="http://schemas.datacontract.org/2004/07/SYS0100Back"),  _
     System.SerializableAttribute()>  _
    Partial Public Class SYS0100DTO02
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private APP_GROUP_IDField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private APP_GROUP_NAMEField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private CREA_BYField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private CREA_DATEField As Date
        
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
        Public Property APP_GROUP_ID() As String
            Get
                Return Me.APP_GROUP_IDField
            End Get
            Set
                If (Object.ReferenceEquals(Me.APP_GROUP_IDField, value) <> true) Then
                    Me.APP_GROUP_IDField = value
                    Me.RaisePropertyChanged("APP_GROUP_ID")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property APP_GROUP_NAME() As String
            Get
                Return Me.APP_GROUP_NAMEField
            End Get
            Set
                If (Object.ReferenceEquals(Me.APP_GROUP_NAMEField, value) <> true) Then
                    Me.APP_GROUP_NAMEField = value
                    Me.RaisePropertyChanged("APP_GROUP_NAME")
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
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="SYS0100SvcRef.ISYS0100Svc")>  _
    Public Interface ISYS0100Svc
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/SC_IServicebaseOf_SYS0100DTO01/Svc_SC_GetRecord", ReplyAction:="http://tempuri.org/SC_IServicebaseOf_SYS0100DTO01/Svc_SC_GetRecordResponse"),  _
         System.ServiceModel.FaultContractAttribute(GetType(SC_Common.SC_ServiceExceptions), Action:="http://tempuri.org/SC_IServicebaseOf_SYS0100DTO01/Svc_SC_GetRecordSC_ServiceExcep"& _ 
            "tionsFault", Name:="SC_ServiceExceptions", [Namespace]:="http://schemas.datacontract.org/2004/07/SC_Common")>  _
        Function Svc_SC_GetRecord(ByVal poEntity As SYS0100SvcRef.SYS0100DTO01, ByVal poCRUDMode As SYS0100SvcRef.eCRUDMode) As SYS0100SvcRef.SYS0100DTO01
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/SC_IServicebaseOf_SYS0100DTO01/Svc_SC_GetRecord", ReplyAction:="http://tempuri.org/SC_IServicebaseOf_SYS0100DTO01/Svc_SC_GetRecordResponse")>  _
        Function Svc_SC_GetRecordAsync(ByVal poEntity As SYS0100SvcRef.SYS0100DTO01, ByVal poCRUDMode As SYS0100SvcRef.eCRUDMode) As System.Threading.Tasks.Task(Of SYS0100SvcRef.SYS0100DTO01)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/SC_IServicebaseOf_SYS0100DTO01/Svc_SC_Save", ReplyAction:="http://tempuri.org/SC_IServicebaseOf_SYS0100DTO01/Svc_SC_SaveResponse"),  _
         System.ServiceModel.FaultContractAttribute(GetType(SC_Common.SC_ServiceExceptions), Action:="http://tempuri.org/SC_IServicebaseOf_SYS0100DTO01/Svc_SC_SaveSC_ServiceExceptions"& _ 
            "Fault", Name:="SC_ServiceExceptions", [Namespace]:="http://schemas.datacontract.org/2004/07/SC_Common")>  _
        Function Svc_SC_Save(ByVal poEntity As SYS0100SvcRef.SYS0100DTO01, ByVal poCRUDMode As SYS0100SvcRef.eCRUDMode) As SYS0100SvcRef.SYS0100DTO01
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/SC_IServicebaseOf_SYS0100DTO01/Svc_SC_Save", ReplyAction:="http://tempuri.org/SC_IServicebaseOf_SYS0100DTO01/Svc_SC_SaveResponse")>  _
        Function Svc_SC_SaveAsync(ByVal poEntity As SYS0100SvcRef.SYS0100DTO01, ByVal poCRUDMode As SYS0100SvcRef.eCRUDMode) As System.Threading.Tasks.Task(Of SYS0100SvcRef.SYS0100DTO01)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/SC_IServicebaseOf_SYS0100DTO01/Svc_SC_Delete", ReplyAction:="http://tempuri.org/SC_IServicebaseOf_SYS0100DTO01/Svc_SC_DeleteResponse"),  _
         System.ServiceModel.FaultContractAttribute(GetType(SC_Common.SC_ServiceExceptions), Action:="http://tempuri.org/SC_IServicebaseOf_SYS0100DTO01/Svc_SC_DeleteSC_ServiceExceptio"& _ 
            "nsFault", Name:="SC_ServiceExceptions", [Namespace]:="http://schemas.datacontract.org/2004/07/SC_Common")>  _
        Sub Svc_SC_Delete(ByVal poEntity As SYS0100SvcRef.SYS0100DTO01)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/SC_IServicebaseOf_SYS0100DTO01/Svc_SC_Delete", ReplyAction:="http://tempuri.org/SC_IServicebaseOf_SYS0100DTO01/Svc_SC_DeleteResponse")>  _
        Function Svc_SC_DeleteAsync(ByVal poEntity As SYS0100SvcRef.SYS0100DTO01) As System.Threading.Tasks.Task
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ISYS0100Svc/getList", ReplyAction:="http://tempuri.org/ISYS0100Svc/getListResponse"),  _
         System.ServiceModel.FaultContractAttribute(GetType(SC_Common.SC_ServiceExceptions), Action:="http://tempuri.org/ISYS0100Svc/getListSC_ServiceExceptionsFault", Name:="SC_ServiceExceptions", [Namespace]:="http://schemas.datacontract.org/2004/07/SC_Common"),  _
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(SYS0100SvcRef.SC_DTOBase)),  _
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(SYS0100SvcRef.eCRUDMode)),  _
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(SYS0100SvcRef.SYS0100DTO01)),  _
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(System.Collections.Generic.List(Of SYS0100SvcRef.SYS0100DTO02))),  _
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(SYS0100SvcRef.SYS0100DTO02)),  _
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(System.Collections.Generic.List(Of Object))),  _
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(SC_Common.SC_ServiceExceptions)),  _
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(System.Collections.Generic.List(Of SC_Common.SC_Error))),  _
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(SC_Common.SC_Error)),  _
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(System.Collections.Generic.List(Of SC_Common.SC_ErrorDetail))),  _
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(SC_Common.SC_ErrorDetail))>  _
        Function getList(ByVal poparam As System.Collections.Generic.List(Of Object)) As System.Collections.Generic.List(Of SYS0100SvcRef.SYS0100DTO02)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ISYS0100Svc/getList", ReplyAction:="http://tempuri.org/ISYS0100Svc/getListResponse")>  _
        Function getListAsync(ByVal poparam As System.Collections.Generic.List(Of Object)) As System.Threading.Tasks.Task(Of System.Collections.Generic.List(Of SYS0100SvcRef.SYS0100DTO02))
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface ISYS0100SvcChannel
        Inherits SYS0100SvcRef.ISYS0100Svc, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class SYS0100SvcClient
        Inherits System.ServiceModel.ClientBase(Of SYS0100SvcRef.ISYS0100Svc)
        Implements SYS0100SvcRef.ISYS0100Svc
        
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
        
        Public Function Svc_SC_GetRecord(ByVal poEntity As SYS0100SvcRef.SYS0100DTO01, ByVal poCRUDMode As SYS0100SvcRef.eCRUDMode) As SYS0100SvcRef.SYS0100DTO01 Implements SYS0100SvcRef.ISYS0100Svc.Svc_SC_GetRecord
            Return MyBase.Channel.Svc_SC_GetRecord(poEntity, poCRUDMode)
        End Function
        
        Public Function Svc_SC_GetRecordAsync(ByVal poEntity As SYS0100SvcRef.SYS0100DTO01, ByVal poCRUDMode As SYS0100SvcRef.eCRUDMode) As System.Threading.Tasks.Task(Of SYS0100SvcRef.SYS0100DTO01) Implements SYS0100SvcRef.ISYS0100Svc.Svc_SC_GetRecordAsync
            Return MyBase.Channel.Svc_SC_GetRecordAsync(poEntity, poCRUDMode)
        End Function
        
        Public Function Svc_SC_Save(ByVal poEntity As SYS0100SvcRef.SYS0100DTO01, ByVal poCRUDMode As SYS0100SvcRef.eCRUDMode) As SYS0100SvcRef.SYS0100DTO01 Implements SYS0100SvcRef.ISYS0100Svc.Svc_SC_Save
            Return MyBase.Channel.Svc_SC_Save(poEntity, poCRUDMode)
        End Function
        
        Public Function Svc_SC_SaveAsync(ByVal poEntity As SYS0100SvcRef.SYS0100DTO01, ByVal poCRUDMode As SYS0100SvcRef.eCRUDMode) As System.Threading.Tasks.Task(Of SYS0100SvcRef.SYS0100DTO01) Implements SYS0100SvcRef.ISYS0100Svc.Svc_SC_SaveAsync
            Return MyBase.Channel.Svc_SC_SaveAsync(poEntity, poCRUDMode)
        End Function
        
        Public Sub Svc_SC_Delete(ByVal poEntity As SYS0100SvcRef.SYS0100DTO01) Implements SYS0100SvcRef.ISYS0100Svc.Svc_SC_Delete
            MyBase.Channel.Svc_SC_Delete(poEntity)
        End Sub
        
        Public Function Svc_SC_DeleteAsync(ByVal poEntity As SYS0100SvcRef.SYS0100DTO01) As System.Threading.Tasks.Task Implements SYS0100SvcRef.ISYS0100Svc.Svc_SC_DeleteAsync
            Return MyBase.Channel.Svc_SC_DeleteAsync(poEntity)
        End Function
        
        Public Function getList(ByVal poparam As System.Collections.Generic.List(Of Object)) As System.Collections.Generic.List(Of SYS0100SvcRef.SYS0100DTO02) Implements SYS0100SvcRef.ISYS0100Svc.getList
            Return MyBase.Channel.getList(poparam)
        End Function
        
        Public Function getListAsync(ByVal poparam As System.Collections.Generic.List(Of Object)) As System.Threading.Tasks.Task(Of System.Collections.Generic.List(Of SYS0100SvcRef.SYS0100DTO02)) Implements SYS0100SvcRef.ISYS0100Svc.getListAsync
            Return MyBase.Channel.getListAsync(poparam)
        End Function
    End Class
End Namespace
