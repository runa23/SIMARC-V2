Imports System.ServiceModel
Imports SC_BackEnd
Imports SC_Common

<ServiceContract()>
Public Interface ISYS0401Svc
    Inherits SC_IServicebase(Of SYS0401DTO01)

    <OperationContract()> _
    <FaultContract(GetType(SC_ServiceExceptions))> _
    Function GetList(ByVal RoleID As String) As List(Of SYS0401DTO02)

    <OperationContract()> _
    <FaultContract(GetType(SC_ServiceExceptions))> _
    Function GetList_App(ByVal RoleID As String) As List(Of LKMSys_AppDTO)

End Interface
