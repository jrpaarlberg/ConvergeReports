<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="SalesViewer.aspx.vb" Inherits="ConvergeReports.WebForm1" %>

<%@ Register Assembly="Telerik.ReportViewer.WebForms, Version=7.2.13.1016, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" Namespace="Telerik.ReportViewer.WebForms" TagPrefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <telerik:ReportViewer ID="ReportViewer1" height=1000 width=900 runat="server"></telerik:ReportViewer>
    </div>
    </form>
</body>
</html>
