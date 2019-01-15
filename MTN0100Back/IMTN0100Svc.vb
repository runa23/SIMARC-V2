Imports System.ServiceModel
Imports SC_BackEnd
Imports SC_Common

<ServiceContract()>
Public Interface IMTN0100Svc
    Inherits SC_IServicebase(Of MTN0100DTO01)

    <OperationContract()>
        <FaultContract(GetType(SC_ServiceExceptions))>
    Function getList(ByVal poParam As List(Of Object)) As List(Of MTN0100DTO02)

    <OperationContract()>
        <FaultContract(GetType(SC_ServiceExceptions))>
    Function getList_Detail(ByVal poParam As MTN0100DTO01) As List(Of Maintenance_DetailDTO)

    <OperationContract()>
        <FaultContract(GetType(SC_ServiceExceptions))>
    Function getCompany(ByVal poParam As List(Of Object)) As List(Of LKM_CompanyDTO)

    <OperationContract()>
        <FaultContract(GetType(SC_ServiceExceptions))>
    Function getOffice(ByVal poParam As List(Of Object)) As List(Of LKM_CompanyOfficeDTO)


End Interface
