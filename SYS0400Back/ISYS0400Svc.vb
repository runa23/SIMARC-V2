Imports System.ServiceModel
Imports SC_Common
Imports SC_BackEnd

<ServiceContract()>
Public Interface ISYS0400Svc
    Inherits SC_IServicebase(Of SYS0400DTO01)

    <OperationContract()>
        <FaultContract(GetType(SC_ServiceExceptions))>
    Function getList(ByVal poparam As List(Of Object)) As List(Of SYS0400DTO02)

End Interface
