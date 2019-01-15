Imports System.ServiceModel
Imports SC_BackEnd
Imports SC_Common
Imports SYS0500Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "ISYS0501Svc" in both code and config file together.
<ServiceContract()>
Public Interface ISYS0501Svc
    Inherits SC_IServicebase(Of SYS0501DTO01)

    <OperationContract()>
        <FaultContract(GetType(SC_ServiceExceptions))>
    Function getList(poparam As String) As List(Of SYS0501DTO02)

    <OperationContract()>
        <FaultContract(GetType(SC_ServiceExceptions))>
    Function getRole() As List(Of LKM_RoleDTO)



End Interface
