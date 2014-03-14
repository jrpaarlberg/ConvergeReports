Public Class SalesCommission
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim instanceReportSource As New Telerik.Reporting.InstanceReportSource()

        Dim report1 As Telerik.Reporting.Report

        report1 = New ClassSalesCommission.Report1()

        Dim filter1 As New Telerik.Reporting.Filter()
        Dim filter2 As New Telerik.Reporting.Filter()
        Dim filter3 As New Telerik.Reporting.Filter()
        Dim filter4 As New Telerik.Reporting.Filter()
       
        ' http://tr-converge/ConvergeReports/SalesCommission.aspx?GroupBy=&sales_rep_nbr=JPB&start_dt=10/1/2013&end_dt=10/10/2013%20
        ' Set the filter Customer NUmber
        If IsNothing(Request.QueryString("cust_nbr")) = False Then
            filter1.Expression = "=Fields.cust_nbr"
            filter1.Operator = Telerik.Reporting.FilterOperator.Like
            filter1.Value = Request.QueryString("cust_nbr").ToString
            report1.Filters.Add(filter1)

        End If

        If IsNothing(Request.QueryString("item_nbr")) = False Then
            filter2.Expression = "=Fields.item_nbr"
            filter2.Operator = Telerik.Reporting.FilterOperator.Like
            filter2.Value = Request.QueryString("item_nbr").ToString
            report1.Filters.Add(filter2)
        End If

        If IsNothing(Request.QueryString("cust_item_nbr")) = False Then
            filter3.Expression = "=Fields.cust_item_nbr"
            filter3.Operator = Telerik.Reporting.FilterOperator.Like
            filter3.Value = Request.QueryString("cust_item_nbr").ToString
            report1.Filters.Add(filter3)
        End If

        instanceReportSource.ReportDocument = report1

        If IsNothing(Request.QueryString("sales_rep_nbr")) = False Then
            instanceReportSource.Parameters.Add(New Telerik.Reporting.Parameter("SalesRepNbr", Request.QueryString("sales_rep_nbr").ToString()))
        End If

        'Added this code for cust_grp_nbr - i.e. Customer Class
        If IsNothing(Request.QueryString("cust_grp_nbr")) = False Then
            filter4.Expression = "=Fields.cust_grp_nbr"
            filter4.Operator = Telerik.Reporting.FilterOperator.Like
            filter4.Value = Request.QueryString("cust_grp_nbr").ToString
            report1.Filters.Add(filter4)
        End If

        ' Date From
        ' Date To 
        ' sales_rep_assoc_nbr
        instanceReportSource.Parameters.Add(New Telerik.Reporting.Parameter("StartDate", Request.QueryString("start_dt").ToString))
        instanceReportSource.Parameters.Add(New Telerik.Reporting.Parameter("EndDate", Request.QueryString("end_dt").ToString))

        ReportViewer1.ReportSource = instanceReportSource

        ReportViewer1.RefreshReport()
    End Sub

End Class