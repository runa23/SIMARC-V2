Imports System.ServiceModel
Imports SC_BackEnd
Imports SC_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ISCMenuSvc" in both code and config file together.
<ServiceContract()>
Public Interface ISCMenuSvc

    <OperationContract()>
    <FaultContract(GetType(SC_ServiceExceptions))>
    Function GetListApp(ByVal pcUserId As String) As List(Of sys_appDTO)

    <OperationContract()>
    <FaultContract(GetType(SC_ServiceExceptions))>
    Function Login(ByVal pcUserId As String, ByVal pcPassword As String) As loginDTO

    <OperationContract()> _
    <FaultContract(GetType(SC_ServiceExceptions))> _
    Function GetRoleApp(ByVal pcUserId As String) As List(Of RoleAppDTO)

    <OperationContract()> _
    <FaultContract(GetType(SC_ServiceExceptions))> _
    Sub ChangePassword(ByVal pcUserId As String, ByVal pcOldPassword As String, ByVal pcNewPassword As String)

    <OperationContract()> _
    <FaultContract(GetType(SC_ServiceExceptions))> _
    Function UpdateAppDll(ByVal pcAppId As String) As Byte()

    <OperationContract()> _
    <FaultContract(GetType(SC_ServiceExceptions))> _
    Function AppDllLatestVersion(ByVal pcAppId As String) As String
End Interface
