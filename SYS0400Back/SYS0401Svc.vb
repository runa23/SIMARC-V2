Imports SC_BackEnd
Imports SC_Common
Imports System.ServiceModel
Imports SYS0400Back
Public Class SYS0401Svc
    Implements ISYS0401Svc

    Public Sub Svc_SC_Delete(poEntity As SYS0401DTO01) Implements SC_IServicebase(Of SYS0401DTO01).Svc_SC_Delete
        Dim loException As New SC_Exception
        Dim loCls As New SYS0401Cls

        Try
            loCls.SC_Delete(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_SC_GetRecord(poEntity As SYS0401DTO01, poCRUDMode As eCRUDMode) As SYS0401DTO01 Implements SC_IServicebase(Of SYS0401DTO01).Svc_SC_GetRecord
        Dim loException As New SC_Exception
        Dim loCls As New SYS0401Cls
        Dim loDTO As SYS0401DTO01

        Try
            loDTO = loCls.SC_GetRecord(poEntity, poCRUDMode)
            Return loDTO
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function Svc_SC_Save(poEntity As SYS0401DTO01, poCRUDMode As eCRUDMode) As SYS0401DTO01 Implements SC_IServicebase(Of SYS0401DTO01).Svc_SC_Save
        Dim loException As New SC_Exception
        Dim loCls As New SYS0401Cls
        Dim loDTO As SYS0401DTO01

        Try
            loDTO = loCls.SC_Save(poEntity, poCRUDMode)
            Return loDTO
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function GetList(RoleID As String) As List(Of SYS0401DTO02) Implements ISYS0401Svc.GetList
        Dim loException As New SC_Exception
        Dim loCls As New SYS0401Cls
        Dim loReturn As List(Of SYS0401DTO02)

        Try
            loReturn = loCls.getList(RoleID)
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function GetList_App(RoleID As String) As List(Of LKMSys_AppDTO) Implements ISYS0401Svc.GetList_App
        Dim loException As New SC_Exception
        Dim loCls As New SYS0401Cls
        Dim loReturn As List(Of LKMSys_AppDTO)

        Try
            loReturn = loCls.GetList_App(RoleID)
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function
End Class
