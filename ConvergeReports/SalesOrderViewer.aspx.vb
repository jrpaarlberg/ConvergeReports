Public Class SalesOrderViewer
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then

            'instanceReportSource.ReportDocument = New CustomerAddress.CustomerAddress()
            'Items = all
            Dim instanceReportSource As New Telerik.Reporting.InstanceReportSource()
            instanceReportSource.ReportDocument = New ClassSalesOrder.Report1()
            
            If Len(Request.QueryString("items").ToString) > 0 Then
                Dim strItemFlag As Boolean = True
                If Request.QueryString("items").Equals("all") Then
                    strItemFlag = False
                End If
                instanceReportSource.Parameters.Add(New Telerik.Reporting.Parameter("FlagOpen", strItemFlag))
            End If


            'Dim instanceReportSource1 As New Telerik.Reporting.InstanceReportSource()

            ' Assigning the Report object to the InstanceReportSource
            'instanceReportSource1.ReportDocument = New ClassSalesOrder.SOitems()

            'instantiate the master report


            'Dim SubReport As New ClassSalesOrder.SOitems


            'InstanceReportSource irs = sr.ReportSource as InstanceReportSource;
            '                    if (irs != null)
            '                      Report rsd = irs.ReportDocument as Report;
            '                       if (rsd != null)
            '                        rsd.DataSource = dataList;

            '= New ClassSalesOrder.SOitems()

            'set it's report source to a new InstanceReportSource with the report document that you have already instantiated above
            'subRepItem.ReportSource = new InstanceReportSource { ReportDocument = subReport };
            'display the master report in the viewer
            'this.ReportViewer1.ReportSource = new InstanceReportSource { ReportDocument = masterReport };

            ReportViewer1.ReportSource = instanceReportSource

            If Len(Request.QueryString("sales_ord_id").ToString) > 0 Then
                Dim strQueryString As String
                strQueryString = Request.QueryString("sales_ord_id")

                instanceReportSource.Parameters.Add(New Telerik.Reporting.Parameter("SalesOrderId", strQueryString.ToString))
            Else

            End If
            ReportViewer1.RefreshReport()
        End If
    End Sub

End Class