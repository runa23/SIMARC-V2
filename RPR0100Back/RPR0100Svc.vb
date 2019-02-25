Imports SC_BackEnd
Imports SC_Common
Imports RPR0100Back
Imports System.ServiceModel
Public Class RPR0100Svc
    Implements IRPR0100Svc

    Public Function getList(ByVal poParam As List(Of Object)) As List(Of RPR0100DTO02) Implements IRPR0100Svc.getList
        Dim loException As New SC_Exception
        Dim loCls As New RPR0100Cls
        Dim loReturn As List(Of RPR0100DTO02)

        Try
            loReturn = loCls.getList(poParam)
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Sub Svc_SC_Delete(poEntity As RPR0100DTO01) Implements SC_IServicebase(Of RPR0100DTO01).Svc_SC_Delete
        Dim loException As New SC_Exception
        Dim loCls As New RPR0100Cls

        Try
            loCls.SC_Delete(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_SC_GetRecord(poEntity As RPR0100DTO01, poCRUDMode As eCRUDMode) As RPR0100DTO01 Implements SC_IServicebase(Of RPR0100DTO01).Svc_SC_GetRecord
        Dim loException As New SC_Exception
        Dim loCls As New RPR0100Cls
        Dim loDTO As RPR0100DTO01

        Try
            loDTO = loCls.SC_GetRecord(poEntity, poCRUDMode)
            Return loDTO
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function Svc_SC_Save(poEntity As RPR0100DTO01, poCRUDMode As eCRUDMode) As RPR0100DTO01 Implements SC_IServicebase(Of RPR0100DTO01).Svc_SC_Save
        Dim loException As New SC_Exception
        Dim loCls As New RPR0100Cls
        Dim loDTO As RPR0100DTO01

        Try
            loDTO = loCls.SC_Save(poEntity, poCRUDMode)
            Return loDTO
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function
End Class
