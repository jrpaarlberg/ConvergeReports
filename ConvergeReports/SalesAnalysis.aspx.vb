Public Class SalesAnalysis
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim instanceReportSource As New Telerik.Reporting.InstanceReportSource()
            

            instanceReportSource.ReportDocument = New ClassSalesAnalysis.Report1()

            If Len(Request.QueryString("sales_rep_assoc_nbr").ToString) > 0 Then
                Dim filter1 As New Telerik.Reporting.Filter()
                filter1.Expression = "=Fields.sales_rep_assoc_nbr"
                filter1.Operator = Telerik.Reporting.FilterOperator.GreaterThan
                filter1.Value = Request.QueryString("sales_rep_assoc_nbr").ToString

            End If



            ReportViewer1.ReportSource = instanceReportSource



            ReportViewer1.RefreshReport()

        End If
    End Sub

End Class