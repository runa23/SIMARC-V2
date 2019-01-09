Imports SC_Common
Imports SC_BackEnd
Imports SYS0300Back
Imports System.ServiceModel
Public Class SYS0300Svc
    Implements ISYS0300Svc
    Public Sub Svc_SC_Delete(poEntity As SYS0300DTO01) Implements SC_IServicebase(Of SYS0300DTO01).Svc_SC_Delete
        Dim loException As New SC_Exception
        Dim loCls As New SYS0300Cls

        Try
            loCls.SC_Delete(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_SC_GetRecord(poEntity As SYS0300DTO01, poCRUDMode As eCRUDMode) As SYS0300DTO01 Implements SC_IServicebase(Of SYS0300DTO01).Svc_SC_GetRecord
        Dim loException As New SC_Exception
        Dim loCls As New SYS0300Cls
        Dim loDTO As SYS0300DTO01

        Try
            loDTO = loCls.SC_GetRecord(poEntity, poCRUDMode)
            Return loDTO
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function Svc_SC_Save(poEntity As SYS0300DTO01, poCRUDMode As eCRUDMode) As SYS0300DTO01 Implements SC_IServicebase(Of SYS0300DTO01).Svc_SC_Save
        Dim loException As New SC_Exception
        Dim loCls As New SYS0300Cls
        Dim loDTO As SYS0300DTO01

        Try
            loDTO = loCls.SC_Save(poEntity, poCRUDMode)
            Return loDTO
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function getList(poparam As List(Of Object)) As List(Of SYS0300DTO02) Implements ISYS0300Svc.getList
        Dim loException As New SC_Exception
        Dim loCls As New SYS0300Cls
        Dim loReturn As List(Of SYS0300DTO02)

        Try
            loReturn = loCls.getList(poparam)
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function getModule() As List(Of LKM_SysModuleDTO) Implements ISYS0300Svc.getModule
        Dim loException As New SC_Exception
        Dim loCls As New SYS0300Cls
        Dim loReturn As List(Of LKM_SysModuleDTO)

        Try
            loReturn = loCls.getModule()
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function getAppGroup() As List(Of LKM_SysAppGroupDTO) Implements ISYS0300Svc.getAppGroup
        Dim loException As New SC_Exception
        Dim loCls As New SYS0300Cls
        Dim loReturn As List(Of LKM_SysAppGroupDTO)

        Try
            loReturn = loCls.getAppGroup()
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function getAppType() As List(Of LKM_SysAppTypeDTO) Implements ISYS0300Svc.getAppType
        Dim loException As New SC_Exception
        Dim loCls As New SYS0300Cls
        Dim loReturn As List(Of LKM_SysAppTypeDTO)

        Try
            loReturn = loCls.getAppType()
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function
End Class
