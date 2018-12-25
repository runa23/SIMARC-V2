Imports System.ServiceModel
Imports SC_Common


<ServiceContract()>
Public Interface ISCStartUpSvc

    <OperationContract()> _
   <FaultContract(GetType(SC_ServiceExceptions))> _
    Function GetListFileSupportVersion() As List(Of FIleSupportDTO)

    <OperationContract()> _
    <FaultContract(GetType(SC_ServiceExceptions))> _
    Function UpdateFile(ByVal pcFileSupportId As String, ByVal pcFileSupportName As String) As Byte()


End Interface
