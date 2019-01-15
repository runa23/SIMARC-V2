Imports SC_BackEnd
Imports SC_Common
Imports SYS0500Back
Public Class SYS0500Svc
    Implements ISYS0500Svc

    Public Sub Svc_SC_Delete(poEntity As SYS0500DTO01) Implements SC_IServicebase(Of SYS0500DTO01).Svc_SC_Delete
        Dim loException As New SC_Exception
        Dim loCls As New SYS0500Cls

        Try
            loCls.SC_Delete(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_SC_GetRecord(poEntity As SYS0500DTO01, poCRUDMode As eCRUDMode) As SYS0500DTO01 Implements SC_IServicebase(Of SYS0500DTO01).Svc_SC_GetRecord
        Dim loException As New SC_Exception
        Dim loCls As New SYS0500Cls
        Dim loDTO As SYS0500DTO01

        Try
            loDTO = loCls.SC_GetRecord(poEntity, poCRUDMode)
            Return loDTO
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function Svc_SC_Save(poEntity As SYS0500DTO01, poCRUDMode As eCRUDMode) As SYS0500DTO01 Implements SC_IServicebase(Of SYS0500DTO01).Svc_SC_Save
        Dim loException As New SC_Exception
        Dim loCls As New SYS0500Cls
        Dim loDTO As SYS0500DTO01

        Try
            loDTO = loCls.SC_Save(poEntity, poCRUDMode)
            Return loDTO
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function getCompany() As List(Of LKM_CompanyDTO) Implements ISYS0500Svc.getCompany
        Dim loException As New SC_Exception
        Dim loCls As New SYS0500Cls
        Dim loReturn As List(Of LKM_CompanyDTO)

        Try
            loReturn = loCls.getCompany()
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function getCompanyOffice() As List(Of LKM_CompanyOfficeDTO) Implements ISYS0500Svc.getCompanyOffice
        Dim loException As New SC_Exception
        Dim loCls As New SYS0500Cls
        Dim loReturn As List(Of LKM_CompanyOfficeDTO)

        Try
            loReturn = loCls.getCompanyOffice()
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function getList(poparam As List(Of Object)) As List(Of SYS0500DTO02) Implements ISYS0500Svc.getList
        Dim loException As New SC_Exception
        Dim loCls As New SYS0500Cls
        Dim loReturn As List(Of SYS0500DTO02)

        Try
            loReturn = loCls.getList(poparam)
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function getRegional() As List(Of LKM_RegionalDTO) Implements ISYS0500Svc.getRegional
        Dim loException As New SC_Exception
        Dim loCls As New SYS0500Cls
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
