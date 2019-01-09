Imports System.ServiceModel
Imports SC_Common
Imports SC_BackEnd

<ServiceContract()>
Public Interface ISYS0300Svc
    Inherits SC_IServicebase(Of SYS0300DTO01)

    <OperationContract()>
        <FaultContract(GetType(SC_ServiceExceptions))>
    Function getList(ByVal poparam As List(Of Object)) As List(Of SYS0300DTO02)

    <OperationContract()>
        <FaultContract(GetType(SC_ServiceExceptions))>
    Function getModule() As List(Of LKM_SysModuleDTO)

    <OperationContract()>
        <FaultContract(GetType(SC_ServiceExceptions))>
    Function getAppGroup() As List(Of LKM_SysAppGroupDTO)

    <OperationContract()>
        <FaultContract(GetType(SC_ServiceExceptions))>
    Function getAppType() As List(Of LKM_SysAppTypeDTO)

End Interface
