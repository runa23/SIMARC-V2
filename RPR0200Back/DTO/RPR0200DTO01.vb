Imports SC_BackEnd
Public Class RPR0200DTO01
    Inherits SC_DTOBase

    Public REPAIR_ID As String
    Public COMPANY_ID As String
    Public COMPANY_OFFICE_ID As String
    Public FROM_DATE As Date
    Public TO_DATE As Date
    Public BARCODE As String
    Public OUTLET_ID As String
    Public OUTLET_NAME As String
    Public CREA_BY As String
    Public CREA_DATE As Date
    Public UPD_BY As String
    Public UPD_DATE As Date

    Public REPAIR_DETAIL As New List(Of Repair_DetailDTO)
End Class
