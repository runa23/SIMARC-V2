Imports System.ServiceModel
Imports SC_BackEnd
Imports SC_Common

<ServiceContract()>
Public Interface ISCM0200Svc
    Inherits SC_IServicebase(Of SCM0200DTO01)

    <OperationContract()>
        <FaultContract(GetType(SC_ServiceExceptions))>
    Function getList(ByVal poparam As List(Of Object)) As List(Of SCM0200DTO02)

End Interface
