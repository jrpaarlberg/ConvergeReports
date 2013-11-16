Public Class ReportViewer
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            Dim instanceReportSource As New Telerik.Reporting.InstanceReportSource()
            instanceReportSource.ReportDocument = New CustomerAddress.CustomerAddress()

            If Len(Request.QueryString("cust_nbr").ToString) > 0 Then
                Dim filter1 As New Telerik.Reporting.Filter()
                filter1.Expression = "=Fields.cust_id"
                filter1.Operator = Telerik.Reporting.FilterOperator.Like
                filter1.Value = Request.QueryString("cust_nbr").ToString

            End If

            ReportViewer1.ReportSource = instanceReportSource
            ReportViewer1.RefreshReport()

        End If
    End Sub

End Class