Imports System.ServiceModel
Imports SC_BackEnd
Imports SC_Common

<ServiceContract()>
Public Interface ISCM0300Svc
    Inherits SC_IServicebase(Of SCM0300DTO01)

    <OperationContract()>
        <FaultContract(GetType(SC_ServiceExceptions))>
    Function getList(ByVal poparam As List(Of Object)) As List(Of SCM0300DTO02)

    <OperationContract()>
        <FaultContract(GetType(SC_ServiceExceptions))>
    Function getCompany() As List(Of LKM_CompanyDTO)


End Interface
