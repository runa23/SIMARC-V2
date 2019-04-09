Imports System.ServiceModel
Imports SC_BackEnd
Imports SC_Common

<ServiceContract()>
Public Interface IOTL0100Svc

    <OperationContract()>
        <FaultContract(GetType(SC_ServiceExceptions))>
    Function getCompany(ByVal poparam As List(Of Object)) As List(Of LKM_CompanyOfficeDTO)

    <OperationContract()>
        <FaultContract(GetType(SC_ServiceExceptions))>
    Sub Import(ByVal DataTable As DataSet, ByVal company_office As String, ByVal user As String)

    <OperationContract()>
        <FaultContract(GetType(SC_ServiceExceptions))>
    Function getParamDoc(ByVal param As String) As List(Of LKM_ParamDTO)
End Interface
