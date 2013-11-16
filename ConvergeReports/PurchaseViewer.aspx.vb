Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then

            'instanceReportSource.ReportDocument = New CustomerAddress.CustomerAddress()
            'Items = all
            Dim instanceReportSource As New Telerik.Reporting.InstanceReportSource()
            Dim strReportPrint As String = "Y"
            'po_id=11929


         
          
         

            If Len(Request.QueryString("rpt_nm").ToString) > 0 Then

                Select Case Request.QueryString("rpt_nm")
                    Case "PurchaseOrder"
                        If Len(Request.QueryString("po_id").ToString) > 0 Then
                            instanceReportSource.ReportDocument = New ClassTimcoReports.PurchaseOrder()
                            Dim strPOid As String = Request.QueryString("po_id")
                            instanceReportSource.Parameters.Add(New Telerik.Reporting.Parameter("PONumber", strPOid.ToString))
                            If Len(Request.QueryString("Items").ToString) > 0 Then
                                Dim strItemFlag As Boolean = True
                                If Request.QueryString("Items").Equals("all") Then
                                    strItemFlag = False
                                End If


                                instanceReportSource.Parameters.Add(New Telerik.Reporting.Parameter("PONumber", strItemFlag))
                            End If
                        End If

                    Case Else
                        strReportPrint = "N"

                End Select
            End If

                If strReportPrint.Equals("Y") Then
                    ReportViewer1.ReportSource = instanceReportSource
                    ReportViewer1.RefreshReport()
                End If


                'Dim instanceReportSource1 As New Telerik.Reporting.InstanceReportSource()

                ' Assigning the Report object to the InstanceReportSource
                'instanceReportSource1.ReportDocument = New ClassSalesOrder.SOitems()

                'instantiate the master report

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

            End If
    End Sub

End Class