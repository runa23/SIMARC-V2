Imports System.ServiceModel
Imports SC_BackEnd
Imports SC_Common

<ServiceContract()>
Public Interface IRPR0100Svc
    Inherits SC_IServicebase(Of RPR0100DTO01)

    <OperationContract()>
        <FaultContract(GetType(SC_ServiceExceptions))>
    Function getList(ByVal poParam As List(Of Object)) As List(Of RPR0100DTO02)

End Interface
