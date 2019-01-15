Imports SC_BackEnd
Imports SC_Common
Imports SYS0500Back
Public Class SYS0501Svc
    Implements ISYS0501Svc

    Public Sub Svc_SC_Delete(poEntity As SYS0501DTO01) Implements SC_IServicebase(Of SYS0501DTO01).Svc_SC_Delete
        Dim loException As New SC_Exception
        Dim loCls As New SYS0501Cls

        Try
            loCls.SC_Delete(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_SC_GetRecord(poEntity As SYS0501DTO01, poCRUDMode As eCRUDMode) As SYS0501DTO01 Implements SC_IServicebase(Of SYS0501DTO01).Svc_SC_GetRecord
        Dim loException As New SC_Exception
        Dim loCls As New SYS0501Cls
        Dim loDTO As SYS0501DTO01

        Try
            loDTO = loCls.SC_GetRecord(poEntity, poCRUDMode)
            Return loDTO
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function Svc_SC_Save(poEntity As SYS0501DTO01, poCRUDMode As eCRUDMode) As SYS0501DTO01 Implements SC_IServicebase(Of SYS0501DTO01).Svc_SC_Save
        Dim loException As New SC_Exception
        Dim loCls As New SYS0501Cls
        Dim loDTO As SYS0501DTO01

        Try
            loDTO = loCls.SC_Save(poEntity, poCRUDMode)
            Return loDTO
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function getRole() As List(Of LKM_RoleDTO) Implements ISYS0501Svc.getRole
        Dim loException As New SC_Exception
        Dim loCls As New SYS0501Cls
        Dim loReturn As List(Of LKM_RoleDTO)

        Try
            loReturn = loCls.getRole()
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function getList(poparam As String) As List(Of SYS0501DTO02) Implements ISYS0501Svc.getList
        Dim loException As New SC_Exception
        Dim loCls As New SYS0501Cls
        Dim loReturn As List(Of SYS0501DTO02)

        Try
            loReturn = loCls.getList(poparam)
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function
End Class
