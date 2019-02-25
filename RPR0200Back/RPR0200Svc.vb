Imports SC_BackEnd
Imports SC_Common
Imports RPR0200Back
Imports System.ServiceModel

Public Class RPR0200Svc
    Implements IRPR0200Svc

    Public Function getCompany(poparam As List(Of Object)) As List(Of LKM_CompanyDTO) Implements IRPR0200Svc.getCompany
        Dim loException As New SC_Exception
        Dim loCls As New RPR0200Cls
        Dim loReturn As List(Of LKM_CompanyDTO)

        Try
            loReturn = loCls.getCompany(poparam)
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function getList(poparam As List(Of Object)) As List(Of RPR0200DTO02) Implements IRPR0200Svc.getList
        Dim loException As New SC_Exception
        Dim loCls As New RPR0200Cls
        Dim loReturn As List(Of RPR0200DTO02)

        Try
            loReturn = loCls.getList(poparam)
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function getList_Detail(poparam As RPR0200DTO01) As List(Of Repair_DetailDTO) Implements IRPR0200Svc.getList_Detail
        Dim loException As New SC_Exception
        Dim loCls As New RPR0200Cls
        Dim loReturn As List(Of Repair_DetailDTO)

        Try
            loReturn = loCls.getList_Detail(poparam)
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function getOffice(poparam As List(Of Object)) As List(Of LKM_CompanyOfficeDTO) Implements IRPR0200Svc.getOffice
        Dim loException As New SC_Exception
        Dim loCls As New RPR0200Cls
        Dim loReturn As List(Of LKM_CompanyOfficeDTO)

        Try
            loReturn = loCls.getOffice(poparam)
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function getOutlet(poparam As List(Of Object)) As List(Of LKM_OutletDTO) Implements IRPR0200Svc.getOutlet
        Dim loException As New SC_Exception
        Dim loCls As New RPR0200Cls
        Dim loReturn As List(Of LKM_OutletDTO)

        Try
            loReturn = loCls.getOutlet(poparam)
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function getSparepart(KD_PART As String, CompanyOfficeID As String) As List(Of LKM_SparepartDTO) Implements IRPR0200Svc.getSparepart
        Dim loException As New SC_Exception
        Dim loCls As New RPR0200Cls
        Dim loReturn As List(Of LKM_SparepartDTO)

        Try
            loReturn = loCls.getSparepart(KD_PART, CompanyOfficeID)
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Sub Svc_SC_Delete(poEntity As RPR0200DTO01) Implements SC_IServicebase(Of RPR0200DTO01).Svc_SC_Delete
        Dim loException As New SC_Exception
        Dim loCls As New RPR0200Cls

        Try
            loCls.SC_Delete(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_SC_GetRecord(poEntity As RPR0200DTO01, poCRUDMode As eCRUDMode) As RPR0200DTO01 Implements SC_IServicebase(Of RPR0200DTO01).Svc_SC_GetRecord
        Dim loException As New SC_Exception
        Dim loCls As New RPR0200Cls
        Dim loDTO As RPR0200DTO01

        Try
            loDTO = loCls.SC_GetRecord(poEntity, poCRUDMode)
            Return loDTO
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function Svc_SC_Save(poEntity As RPR0200DTO01, poCRUDMode As eCRUDMode) As RPR0200DTO01 Implements SC_IServicebase(Of RPR0200DTO01).Svc_SC_Save
        Dim loException As New SC_Exception
        Dim loCls As New RPR0200Cls
        Dim loDTO As RPR0200DTO01

        Try
            loDTO = loCls.SC_Save(poEntity, poCRUDMode)
            Return loDTO
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function
End Class
