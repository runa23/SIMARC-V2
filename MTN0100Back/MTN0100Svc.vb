Imports SC_BackEnd
Imports SC_Common
Imports MTN0100Back
Imports System.ServiceModel
Public Class MTN0100Svc
    Implements IMTN0100Svc
    Public Function getCompany(poParam As List(Of Object)) As List(Of LKM_CompanyDTO) Implements IMTN0100Svc.getCompany
        Dim loException As New SC_Exception
        Dim loCls As New MTN0100Cls
        Dim loReturn As List(Of LKM_CompanyDTO)

        Try
            loReturn = loCls.getCompany(poParam)
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function getList(poParam As List(Of Object)) As List(Of MTN0100DTO02) Implements IMTN0100Svc.getList
        Dim loException As New SC_Exception
        Dim loCls As New MTN0100Cls
        Dim loReturn As List(Of MTN0100DTO02)

        Try
            loReturn = loCls.getList(poParam)
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function getList_Detail(poParam As MTN0100DTO01) As List(Of Maintenance_DetailDTO) Implements IMTN0100Svc.getList_Detail
        Dim loException As New SC_Exception
        Dim loCls As New MTN0100Cls
        Dim loReturn As List(Of Maintenance_DetailDTO)

        Try
            loReturn = loCls.getList_Detail(poParam)
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function getOffice(poParam As List(Of Object)) As List(Of LKM_CompanyOfficeDTO) Implements IMTN0100Svc.getOffice
        Dim loException As New SC_Exception
        Dim loCls As New MTN0100Cls
        Dim loReturn As List(Of LKM_CompanyOfficeDTO)

        Try
            loReturn = loCls.getOffice(poParam)
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Sub Svc_SC_Delete(poEntity As MTN0100DTO01) Implements SC_IServicebase(Of MTN0100DTO01).Svc_SC_Delete
        Dim loException As New SC_Exception
        Dim loCls As New MTN0100Cls

        Try
            loCls.SC_Delete(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_SC_GetRecord(poEntity As MTN0100DTO01, poCRUDMode As eCRUDMode) As MTN0100DTO01 Implements SC_IServicebase(Of MTN0100DTO01).Svc_SC_GetRecord
        Dim loException As New SC_Exception
        Dim loCls As New MTN0100Cls
        Dim loDTO As MTN0100DTO01

        Try
            loDTO = loCls.SC_GetRecord(poEntity, poCRUDMode)
            Return loDTO
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function Svc_SC_Save(poEntity As MTN0100DTO01, poCRUDMode As eCRUDMode) As MTN0100DTO01 Implements SC_IServicebase(Of MTN0100DTO01).Svc_SC_Save
        Dim loException As New SC_Exception
        Dim loCls As New MTN0100Cls
        Dim loDTO As MTN0100DTO01

        Try
            loDTO = loCls.SC_Save(poEntity, poCRUDMode)
            Return loDTO
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function getOutlet(poParam As List(Of Object)) As List(Of LKM_OutletDTO) Implements IMTN0100Svc.getOutlet
        Dim loException As New SC_Exception
        Dim loCls As New MTN0100Cls
        Dim loReturn As List(Of LKM_OutletDTO)

        Try
            loReturn = loCls.getOutlet(poParam)
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function
End Class
