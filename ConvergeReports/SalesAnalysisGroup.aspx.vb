Public Class SalesAnalysisGroup
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim instanceReportSource As New Telerik.Reporting.InstanceReportSource()

            Dim report1 As Telerik.Reporting.Report


            If IsNothing(Request.QueryString("GroupBy")) = False Then
                Select Case Request.QueryString("GroupBy")
                    Case "Sum"
                        report1 = New ClassSalesAnalysisSummary.Report1()
                    Case "DetItm"
                        report1 = New ClassSalesAnalysisItem.Report1()
                    Case "DetInv"
                        report1 = New ClassSalesAnalysisInvoice.Report1()
                    Case "Commission"
                        report1 = New ClassSalesCommission.Report1()
                    Case Else
                        report1 = New ClassSalesAnalysisSummary.Report1()
                End Select
            Else
                report1 = New ClassSalesAnalysisSummary.Report1()
            End If


            Dim filter1 As New Telerik.Reporting.Filter()
            Dim filter2 As New Telerik.Reporting.Filter()
            Dim filter3 As New Telerik.Reporting.Filter()
            Dim filter4 As New Telerik.Reporting.Filter()
            Dim filter5 As New Telerik.Reporting.Filter()


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

            If IsNothing(Request.QueryString("sales_rep_nbr")) = False Then
                If Request.QueryString("GroupBy") <> "Commission" Then
                    instanceReportSource.Parameters.Add(New Telerik.Reporting.Parameter("SalesmanNBR", Request.QueryString("sales_rep_nbr").ToString()))
                Else
                    instanceReportSource.Parameters.Add(New Telerik.Reporting.Parameter("SalesRepNbr", Request.QueryString("sales_rep_nbr").ToString()))
                End If
            End If

                If IsNothing(Request.QueryString("cust_rep_assoc_id")) = False Then
                    filter4.Expression = "=Fields.cust_rep_assoc_id"
                    filter4.Operator = Telerik.Reporting.FilterOperator.Like
                    filter4.Value = Request.QueryString("cust_rep_assoc_id").ToString
                    report1.Filters.Add(filter4)
                End If

                If IsNothing(Request.QueryString("item_commodity_cd")) = False Then
                    filter5.Expression = "=Fields.item_commodity_cd"
                    filter5.Operator = Telerik.Reporting.FilterOperator.Like
                    filter5.Value = Request.QueryString("item_commodity_cd").ToString
                    report1.Filters.Add(filter5)
                End If




                instanceReportSource.ReportDocument = report1

                ' Date From
                ' Date To 
                ' sales_rep_assoc_nbr


                instanceReportSource.Parameters.Add(New Telerik.Reporting.Parameter("StartDate", Request.QueryString("start_dt").ToString))
                instanceReportSource.Parameters.Add(New Telerik.Reporting.Parameter("EndDate", Request.QueryString("end_dt").ToString))

                If Request.QueryString("GroupBy") <> "Commission" Then
                    instanceReportSource.Parameters.Add(New Telerik.Reporting.Parameter("CustomerClass", "A"))
                End If

                ReportViewer1.ReportSource = instanceReportSource

                ReportViewer1.RefreshReport()

            End If
    End Sub

End Class