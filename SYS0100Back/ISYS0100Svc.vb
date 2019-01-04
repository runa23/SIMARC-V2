Imports System.ServiceModel
Imports SC_Common
Imports SC_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the interface name "ISYS0100Svc" in both code and config file together.
<ServiceContract()>
Public Interface ISYS0100Svc
    Inherits SC_IServicebase(Of SYS0100DTO01)

    <OperationContract()>
        <FaultContract(GetType(SC_ServiceExceptions))>
    Function getList(ByVal poparam As List(Of Object)) As List(Of SYS0100DTO02)

End Interface
