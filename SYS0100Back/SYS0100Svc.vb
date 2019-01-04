Imports SC_Common
Imports SC_BackEnd
Imports SYS0100Back
Imports System.ServiceModel
Public Class SYS0100Svc
    Implements ISYS0100Svc

    Public Sub Svc_SC_Delete(poEntity As SYS0100DTO01) Implements SC_IServicebase(Of SYS0100DTO01).Svc_SC_Delete
        Dim loException As New SC_Exception
        Dim loCls As New SYS0100Cls

        Try
            loCls.SC_Delete(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

    End Sub

    Public Function Svc_SC_GetRecord(poEntity As SYS0100DTO01, poCRUDMode As eCRUDMode) As SYS0100DTO01 Implements SC_IServicebase(Of SYS0100DTO01).Svc_SC_GetRecord
        Dim loException As New SC_Exception
        Dim loCls As New SYS0100Cls
        Dim loDTO As SYS0100DTO01

        Try
            loDTO = loCls.SC_GetRecord(poEntity, poCRUDMode)
            Return loDTO
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

    End Function

    Public Function Svc_SC_Save(poEntity As SYS0100DTO01, poCRUDMode As eCRUDMode) As SYS0100DTO01 Implements SC_IServicebase(Of SYS0100DTO01).Svc_SC_Save
        Dim loException As New SC_Exception
        Dim loCls As New SYS0100Cls
        Dim loDTO As SYS0100DTO01

        Try
            loDTO = loCls.SC_Save(poEntity, poCRUDMode)
            Return loDTO
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

    End Function

    Public Function getList(poparam As List(Of Object)) As List(Of SYS0100DTO02) Implements ISYS0100Svc.getList
        Dim loException As New SC_Exception
        Dim loCls As New SYS0100Cls
        Dim loReturn As List(Of SYS0100DTO02)

        Try
            loReturn = loCls.getList(poparam)
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

    End Function
End Class
