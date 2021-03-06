﻿Imports System.ServiceModel
Imports SC_BackEnd
Imports SC_Common
Imports SYS0500Back

<ServiceContract()>
Public Interface ISYS0500Svc
    Inherits SC_IServicebase(Of SYS0500DTO01)

    <OperationContract()>
        <FaultContract(GetType(SC_ServiceExceptions))>
    Function getList() As List(Of SYS0500DTO02)

    <OperationContract()>
        <FaultContract(GetType(SC_ServiceExceptions))>
    Function getRegional() As List(Of LKM_RegionalDTO)

    <OperationContract()>
        <FaultContract(GetType(SC_ServiceExceptions))>
    Function getCompany(ByVal poparam As List(Of Object)) As List(Of LKM_CompanyDTO)

    <OperationContract()>
        <FaultContract(GetType(SC_ServiceExceptions))>
    Function getCompanyOffice(ByVal poparam As List(Of Object)) As List(Of LKM_CompanyOfficeDTO)

    <OperationContract()>
        <FaultContract(GetType(SC_ServiceExceptions))>
    Function getCompanyOfficeMap(ByVal poparam As List(Of Object)) As List(Of LKM_Company_Office_MapDTO)

End Interface
