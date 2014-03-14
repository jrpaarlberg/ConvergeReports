Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim instanceReportSource As New Telerik.Reporting.InstanceReportSource()

        If Len(Request.QueryString("rpt_nm").ToString) > 0 Then
            Select Case Request.QueryString("rpt_nm")
                Case "PackListDropShip"
                    instanceReportSource.ReportDocument = New ClassTimcoReports.DropShipPackingSlip()
                Case "PackList"
                    instanceReportSource.ReportDocument = New ClassTimcoReports.RegularPackingSlip()
            End Select
        End If

        instanceReportSource.Parameters.Add(New Telerik.Reporting.Parameter("ShipmentID", Request.QueryString("ship_id")))

        ReportViewer1.ReportSource = instanceReportSource
        ReportViewer1.RefreshReport()

    End Sub

End Class