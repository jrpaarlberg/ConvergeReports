<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Labels.aspx.vb" Inherits="ConvergeReports.WebForm3" %>

<%@ Register assembly="Telerik.ReportViewer.WebForms, Version=7.2.13.1016, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" namespace="Telerik.ReportViewer.WebForms" tagprefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <telerik:ReportViewer ID="ReportViewer1" runat="server" Height="732px" Width="1097px"></telerik:ReportViewer>
    
    </div>
    </form>
</body>
</html>
