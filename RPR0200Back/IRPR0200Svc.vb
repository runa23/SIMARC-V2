Imports System.ServiceModel
Imports SC_BackEnd
Imports SC_Common
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IRPR0200Svc" in both code and config file together.
<ServiceContract()>
Public Interface IRPR0200Svc
    Inherits SC_IServicebase(Of RPR0200DTO01)

    <OperationContract()>
        <FaultContract(GetType(SC_ServiceExceptions))>
    Function getList(ByVal poparam As List(Of Object)) As List(Of RPR0200DTO02)

    <OperationContract()>
        <FaultContract(GetType(SC_ServiceExceptions))>
    Function getList_Detail(ByVal poparam As RPR0200DTO01) As List(Of Repair_DetailDTO)

    <OperationContract()>
        <FaultContract(GetType(SC_ServiceExceptions))>
    Function getCompany(ByVal poparam As List(Of Object)) As List(Of LKM_CompanyDTO)

    <OperationContract()>
        <FaultContract(GetType(SC_ServiceExceptions))>
    Function getOffice(ByVal poparam As List(Of Object)) As List(Of LKM_CompanyOfficeDTO)

    <OperationContract()>
        <FaultContract(GetType(SC_ServiceExceptions))>
    Function getOutlet(ByVal poparam As List(Of Object)) As List(Of LKM_OutletDTO)

    <OperationContract()>
        <FaultContract(GetType(SC_ServiceExceptions))>
    Function getSparepart(ByVal KD_PART As String, CompanyOfficeID As String) As List(Of LKM_SparepartDTO)

End Interface
