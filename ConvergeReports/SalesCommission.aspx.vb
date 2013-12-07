Public Class SalesCommission
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim instanceReportSource As New Telerik.Reporting.InstanceReportSource()

        Dim report1 As Telerik.Reporting.Report

        report1 =  New ClassSalesCommission.Report1()

        Dim filter1 As New Telerik.Reporting.Filter()

        ' Set the filter Customer NUmber
        If IsNothing(Request.QueryString("cust_nbr")) = False Then
            filter1.Expression = "=Fields.cust_nbr"
            filter1.Operator = Telerik.Reporting.FilterOperator.Like
            filter1.Value = Request.QueryString("cust_nbr").ToString
            report1.Filters.Add(filter1)
        End If

        If IsNothing(Request.QueryString("item_nbr")) = False Then
            filter1.Expression = "=Fields.item_nbr"
            filter1.Operator = Telerik.Reporting.FilterOperator.Like
            filter1.Value = Request.QueryString("item_nbr").ToString
            report1.Filters.Add(filter1)
        End If

        If IsNothing(Request.QueryString("cust_item_nbr")) = False Then
            filter1.Expression = "=Fields.cust_item_nbr"
            filter1.Operator = Telerik.Reporting.FilterOperator.Like
            filter1.Value = Request.QueryString("cust_item_nbr").ToString
            report1.Filters.Add(filter1)
        End If


        If IsNothing(Request.QueryString("sales_rep_assoc_nbr")) = False Then
            'filter1.Expression = "=Fields.sales_rep_nbr"
            'filter1.Operator = Telerik.Reporting.FilterOperator.Like
            'filter1.Value = Request.QueryString("sales_rep_nbr").ToString
            'report1.Filters.Add(filter1)
            instanceReportSource.Parameters.Add(New Telerik.Reporting.Parameter("SalesmanNBR", Request.QueryString("sales_rep_nbr").ToString()))
        End If
        ' Removed this code since it didn't look like the other
        'If IsNothing(Request.QueryString("cust_class")) = False Then
        '    instanceReportSource.Parameters.Add(New Telerik.Reporting.Parameter("CustomerClass", Request.QueryString("cust_class").ToString()))
        'End If

        'Added this code for cust_grp_nbr - i.e. Customer Class
        If IsNothing(Request.QueryString("cust_grp_nbr")) = False Then
            'filter1.Expression = "=Fields.cust_grp_nbr"
            'filter1.Operator = Telerik.Reporting.FilterOperator.Like
            'filter1.Value = Request.QueryString("cust_grp_nbr").ToString
            'report1.Filters.Add(filter1)
            instanceReportSource.Parameters.Add(New Telerik.Reporting.Parameter("CustomerClass", Request.QueryString("cust_grp_nbr").ToString()))
        End If

        instanceReportSource.ReportDocument = report1

        ' Date From
        ' Date To 
        ' sales_rep_assoc_nbr

        instanceReportSource.Parameters.Add(New Telerik.Reporting.Parameter("StartDate", Request.QueryString("start_dt").ToString))
        instanceReportSource.Parameters.Add(New Telerik.Reporting.Parameter("EndDate", Request.QueryString("end_dt").ToString))

        ReportViewer1.RefreshReport()
    End Sub

End Class