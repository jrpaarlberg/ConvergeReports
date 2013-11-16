Public Class SalesCommission
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim instanceReportSource As New Telerik.Reporting.InstanceReportSource()
        instanceReportSource.ReportDocument = New ClassSalesCommission.Report1()

        ReportViewer1.ReportSource = instanceReportSource

        ReportViewer1.RefreshReport()
    End Sub

End Class