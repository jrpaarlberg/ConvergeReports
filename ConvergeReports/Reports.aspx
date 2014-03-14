<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Reports.aspx.vb" Inherits="ConvergeReports.Reports" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border: 1px solid #000099;
        }
        .auto-style2 {
            width: 159px;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3><strong>Converge Report using TR Converge
                Data</strong></h3>
             <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Sales Order - All</td>
                    <td><a href="http://tr-converge/ConvergeReports/SalesOrderViewer.aspx?sales_ord_id=50983&Items=all" target="new"/>Sales Order - All</td>
                </tr>
                <tr>
                    <td class="auto-style2">Sales Order Open</td>
                    <td><a href="http://tr-converge/ConvergeReports/SalesOrderViewer.aspx?sales_ord_id=50983&Items=open" target="new"/>Sales Order - Open</td>
                </tr>
                <tr>
                    <td class="auto-style2">Sales Commission </td>
                    <td><a href="http://tr-converge/ConvergeReports/SalesAnalysisGroup.aspx?GroupBy=Commission&sales_rep_nbr=JPB&start_dt=10/1/2013&end_dt=10/10/2013" target="new">Sales Commission</a></td>
                </tr>
                <tr>
                    <td class="auto-style2">Sales Analyis - Customer</td>
                    <td> <a href="http://tr-converge/ConvergeReports/SalesAnalysisGroup.aspx?sales_rep_nbr=JPB&GroupBy=Sum&cust_id=1424&start_dt=10/1/2013&end_dt=10/10/2013" target="new">Sales Analysis</a></td>
                </tr>
                <tr>
                    <td class="auto-style2">Sales Analyis - Item </td>
                    <td><a href="http://tr-converge/ConvergeReports/SalesAnalysisGroup.aspx?sales_rep_nbr=JPB&GroupBy=DetItm&cust_id=1424&start_dt=10/1/2013&end_dt=10/10/2013" target="new">Sales Analysis</a></td>
                </tr>
                <tr>
                    <td class="auto-style2">Sales Analyis - Invoice </td>
                    <td><a href="http://tr-converge/ConvergeReports/SalesAnalysisGroup.aspx?sales_rep_nbr=JPB&GroupBy=DetInv&cust_id=1424&start_dt=10/1/2013&end_dt=10/10/2013"" target="new">Sales Analysis</a></td>
                </tr>

                <tr>
                    <td class="auto-style2">Customer Address</td>
                    <td> <a href="http://tr-converge/ConvergeReports/ReportViewer.aspx" target="new">Customer Address</a></td>
                </tr>
                <tr>
                    <td class="auto-style2">Purchase Order </td>
                    <td> <a href="http://tr-converge/ConvergeReports/PurchaseViewer.aspx?rpt_nm=PurchaseOrder&po_id=11929&Items=all" target="new">Purchase Order</a></td>
                </tr>

                    <tr>
                    <td class="auto-style2">Open Purchase Order </td>
                    <td> <a href="http://tr-converge/ConvergeReports/PurchaseViewer.aspx?rpt_nm=OpenPurchaseOrder" target="new">Print</a></td>
                </tr>
                <tr>
                    <td class="auto-style2">Drop Ship Pack List</td>
                    <td> <a href="http://tr-converge/ConvergeReports/PackList.aspx?rpt_nm=PackListDropShip&ship_id=141853" target="new">Print</a></td>
                </tr><tr>
                    <td class="auto-style2">Pack List</td>
                    <td> <a href="http://tr-converge/ConvergeReports/PackList.aspx?rpt_nm=PackList&ship_id=27223" target="new">Print</a></td>
                </tr>
            </table>

            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Sales Order - All</td>
                    <td><a href="http://tr-dev2:82/SalesOrderViewer.aspx?sales_ord_id=50983&Items=all" target="new"/>Sales Order - All</td>
                </tr>
                <tr>
                    <td class="auto-style2">Sales Order Open</td>
                    <td><a href="http://tr-dev2:82/SalesOrderViewer.aspx?sales_ord_id=50983&Items=open" target="new"/>Sales Order - Open</td>
                </tr>
                <tr>
                    <td class="auto-style2">Sales Commission </td>
                    <td><a href="http://tr-dev2:82/SalesAnalysisGroup.aspx?GroupBy=Commission&sales_rep_nbr=JPB&start_dt=10/1/2013&end_dt=10/10/2013" target="new">Sales Commission</a></td>
                </tr>
                <tr>
                    <td class="auto-style2">Sales Analyis - Customer</td>
                    <td> <a href="http://tr-dev2:82/SalesAnalysisGroup.aspx?sales_rep_nbr=JPB&GroupBy=Sum&cust_id=1424&start_dt=10/1/2013&end_dt=10/10/2013" target="new">Sales Analysis</a></td>
                </tr>
                <tr>
                    <td class="auto-style2">Sales Analyis - Item </td>
                    <td><a href="http://tr-dev2:82/SalesAnalysisGroup.aspx?sales_rep_nbr=JPB&GroupBy=DetItm&cust_id=1424&start_dt=10/1/2013&end_dt=10/10/2013" target="new">Sales Analysis</a></td>
                </tr>
                <tr>
                    <td class="auto-style2">Sales Analyis - Invoice </td>
                    <td><a href="http://tr-dev2:82/SalesAnalysisGroup.aspx?sales_rep_nbr=JPB&GroupBy=DetInv&cust_id=1424&start_dt=10/1/2013&end_dt=10/10/2013" target="new">Sales Analysis</a></td>
                </tr>

      
                <tr>
                    <td class="auto-style2">Customer Address</td>
                    <td> <a href="http://tr-dev2:82/ReportViewer.aspx" target="new">Customer Address</a></td>
                </tr>
                <tr>
                    <td class="auto-style2">Purchase Order </td>
                    <td> <a href="http://tr-dev2:82/PurchaseViewer.aspx?rpt_nm=PurchaseOrder&po_id=11929&Items=all" target="new">Purchase Order</a></td>
                </tr>
                <tr>
                    <td class="auto-style2">Open Purchase Order </td>
                    <td> <a href="http://localhost:59742/PurchaseViewer.aspx?rpt_nm=OpenPurchaseOrder" target="new">Report</a></td>
                </tr>
                <tr>
                    <td class="auto-style2">Drop Ship Pack List</td>
                    <td> <a href="http://localhost:59742/PackList.aspx?rpt_nm=PackListDropShip&ship_id=141853" target="new">Report</a></td>
                </tr><tr>
                    <td class="auto-style2">Pack List</td>
                    <td> <a href="http://localhost:59742/PackList.aspx?rpt_nm=PackList&ship_id=27223" target="new">Report</a></td>
                </tr>
            
            </table>
        <br />
        <br />
            FromDate
        <br />
        <br />
            Visual Studio Links 
        <br />
         <a href="http://localhost:59742/ReportViewer.aspx?cust_nbr=2002" target="new">Customer Address</a><br />
        <br />
         <a href="http://localhost:59742/SalesAnalysisGroup.aspx?sales_rep_nbr=JPB&GroupBy=Sum&cust_id=1424&start_dt=10/1/2013&end_dt=10/10/2013" target="new">Sales Analysis - Group By Customer</a><br />
               <br />
        <a href="http://localhost:59742/SalesAnalysisGroup.aspx?sales_rep_nbr=JPB&GroupBy=DetItm&cust_id=1424&start_dt=10/1/2013&end_dt=10/10/2013" target="new">Sales Analysis - Group By Item</a><br />
               <br />
        <a href="http://localhost:59742/SalesAnalysisGroup.aspx?sales_rep_nbr=JPB&GroupBy=DetInv&cust_id=1424&start_dt=10/1/2013&end_dt=10/10/2013" target="new">Sales Analysis - Group By Invoice</a><br />
        <br />
        <a href="http://localhost:59742/SalesAnalysisGroup.aspx?GroupBy=Commission&sales_rep_nbr=JPB&start_dt=10/1/2013&end_dt=10/10/2013" target="new">Sales Commission</a><br />
     
        <a href="http://localhost:59742/SalesAnalysisGroup.aspx?GroupBy=Commission&sales_rep_nbr=JPB&cust_nbr=AAON&item_nbr=1040&start_dt=10/1/2013&end_dt=10/10/2013" target="new">Sales Commission Filter Customer Item </a><br />
        <br />
        <a href="http://localhost:59742/SalesOrderViewer.aspx?sales_ord_id=52084&Items=open" target="new">Sales Order - Open</a>
        <br />
        <a href="http://localhost:59742/SalesOrderViewer.aspx?sales_ord_id=52084&Items=all" target="new">Sales Order - all</a>
        <br />
        <a href="http://localhost:59742/PurchaseViewer.aspx?rpt_nm=PurchaseOrder&po_id=11929&Items=all" target="new">Purchase Order</a>
        <br />
        <a href="http://localhost:59742/PurchaseViewer.aspx?rpt_nm=OpenPurchaseOrder" target="new">Open Purchase Orders</a>

        <br />
        <a href="http://localhost:59742/PackList.aspx?rpt_nm=PackListDropShip&ship_id=141853" target="new">Pack List Drop Ship</a>
        <br />
        <a href="http://localhost:59742/PackList.aspx?rpt_nm=PackList&ship_id=27223" target="new">Pack List</a>
        <br />
        <a href="http://localhost:59742/Labels.aspx?rpt_nm=LotLables2x5&lot_id=55143&lot_qty=20&StartLabel=3" target="new">Lot Label</a>
        <br />
        <a href="http://localhost:59742/Labels.aspx?rpt_nm=LotLables3x10&lot_id=55143&lot_qty=20&StartLabel=3" target="new">Lot Label</a>
        <br />

        </div>
    </form>
</body>
</html>
