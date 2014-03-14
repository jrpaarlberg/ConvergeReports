<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="SalesAnalysisGroup.aspx.vb" Inherits="ConvergeReports.SalesAnalysisGroup" %>

<%@ Register Assembly="Telerik.ReportViewer.WebForms, Version=7.2.13.1016, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" Namespace="Telerik.ReportViewer.WebForms" TagPrefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />

</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <telerik:ReportViewer ID="ReportViewer1" runat="server" Height="1000px" Width="1000px"></telerik:ReportViewer>
    </form>
</body>
</html>
