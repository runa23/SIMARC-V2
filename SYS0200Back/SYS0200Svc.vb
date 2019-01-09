Imports SC_Common
Imports SC_BackEnd
Imports SYS0200Back
Imports System.ServiceModel

Public Class SYS0200Svc
    Implements ISYS0200Svc
    Public Sub Svc_SC_Delete(poEntity As SYS0200DTO01) Implements SC_IServicebase(Of SYS0200DTO01).Svc_SC_Delete
        Dim loException As New SC_Exception
        Dim loCls As New SYS0200Cls

        Try
            loCls.SC_Delete(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_SC_GetRecord(poEntity As SYS0200DTO01, poCRUDMode As eCRUDMode) As SYS0200DTO01 Implements SC_IServicebase(Of SYS0200DTO01).Svc_SC_GetRecord
        Dim loException As New SC_Exception
        Dim loCls As New SYS0200Cls
        Dim loDTO As SYS0200DTO01

        Try
            loDTO = loCls.SC_GetRecord(poEntity, poCRUDMode)
            Return loDTO
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function Svc_SC_Save(poEntity As SYS0200DTO01, poCRUDMode As eCRUDMode) As SYS0200DTO01 Implements SC_IServicebase(Of SYS0200DTO01).Svc_SC_Save
        Dim loException As New SC_Exception
        Dim loCls As New SYS0200Cls
        Dim loDTO As SYS0200DTO01

        Try
            loDTO = loCls.SC_Save(poEntity, poCRUDMode)
            Return loDTO
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function getList(poparam As List(Of Object)) As List(Of SYS0200DTO02) Implements ISYS0200Svc.getList
        Dim loException As New SC_Exception
        Dim loCls As New SYS0200Cls
        Dim loReturn As List(Of SYS0200DTO02)

        Try
            loReturn = loCls.getList(poparam)
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function
End Class
