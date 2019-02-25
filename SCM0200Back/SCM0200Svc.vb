Imports SC_Common
Imports SC_BackEnd
Imports SCM0200Back
Imports System.ServiceModel
Public Class SCM0200Svc
    Implements ISCM0200Svc

    Public Sub Svc_SC_Delete(poEntity As SCM0200DTO01) Implements SC_IServicebase(Of SCM0200DTO01).Svc_SC_Delete
        Dim loException As New SC_Exception
        Dim loCls As New SCM0200Cls

        Try
            loCls.SC_Delete(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_SC_GetRecord(poEntity As SCM0200DTO01, poCRUDMode As eCRUDMode) As SCM0200DTO01 Implements SC_IServicebase(Of SCM0200DTO01).Svc_SC_GetRecord
        Dim loException As New SC_Exception
        Dim loCls As New SCM0200Cls
        Dim loDTO As SCM0200DTO01

        Try
            loDTO = loCls.SC_GetRecord(poEntity, poCRUDMode)
            Return loDTO
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function Svc_SC_Save(poEntity As SCM0200DTO01, poCRUDMode As eCRUDMode) As SCM0200DTO01 Implements SC_IServicebase(Of SCM0200DTO01).Svc_SC_Save
        Dim loException As New SC_Exception
        Dim loCls As New SCM0200Cls
        Dim loDTO As SCM0200DTO01

        Try
            loDTO = loCls.SC_Save(poEntity, poCRUDMode)
            Return loDTO
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function getList(poparam As List(Of Object)) As List(Of SCM0200DTO02) Implements ISCM0200Svc.getList
        Dim loException As New SC_Exception
        Dim loCls As New SCM0200Cls
        Dim loReturn As List(Of SCM0200DTO02)

        Try
            loReturn = loCls.getList(poparam)
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function getRegional() As List(Of LKM_RegionalDTO) Implements ISCM0200Svc.getRegional
        Dim loException As New SC_Exception
        Dim loCls As New SCM0200Cls
        Dim loReturn As List(Of LKM_RegionalDTO)

        Try
            loReturn = loCls.getRegional()
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function
End Class
