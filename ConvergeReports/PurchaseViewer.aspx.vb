Public Class PurchaseViewer
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then

            'instanceReportSource.ReportDocument = New CustomerAddress.CustomerAddress()
            'Items = all
            Dim instanceReportSource As New Telerik.Reporting.InstanceReportSource()
            Dim strReportPrint As String = "Y"
            'po_id=11929
            ' Currently Calling Sales Viewer 
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


                                instanceReportSource.Parameters.Add(New Telerik.Reporting.Parameter("FlagOpen", strItemFlag))
                            End If
                        End If
                    Case "OpenPurchaseOrder"
                        instanceReportSource.ReportDocument = New ClassTimcoReports.Open_Purchase()
                    Case Else
                        strReportPrint = "N"

                End Select
            End If

            If strReportPrint.Equals("Y") Then
                'ReportViewer1.ReportSource = instanceReportSource
                'ReportViewer1.RefreshReport()
            End If


          
        End If
    End Sub

End Class