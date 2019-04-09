Imports SC_Common
Imports SC_BackEnd
Imports OTL0100Back
Imports System.ServiceModel
Public Class OTL0100Svc
    Implements IOTL0100Svc

    Public Function getCompany(poparam As List(Of Object)) As List(Of LKM_CompanyOfficeDTO) Implements IOTL0100Svc.getCompany
        Dim loException As New SC_Exception
        Dim loCls As New OTL0100Cls
        Dim loReturn As List(Of LKM_CompanyOfficeDTO)

        Try
            loReturn = loCls.getCompany(poparam)
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Sub Import(DataTable As DataSet, company_office As String, user As String) Implements IOTL0100Svc.Import
        Dim loException As New SC_Exception
        Dim loCls As New OTL0100Cls

        Try
            loCls.Import(DataTable, company_office, user)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function getParamDoc(param As String) As List(Of LKM_ParamDTO) Implements IOTL0100Svc.getParamDoc
        Dim loException As New SC_Exception
        Dim loCls As New OTL0100Cls
        Dim loReturn As List(Of LKM_ParamDTO)

        Try
            loReturn = loCls.getParamDoc(param)
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function
End Class
