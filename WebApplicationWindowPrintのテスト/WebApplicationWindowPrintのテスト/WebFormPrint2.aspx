<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebFormPrint2.aspx.vb" Inherits="WebApplicationWindowPrintのテスト.WebFormPrint2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            function runPrint() {

            self.window.focus();
            self.window.print();
        }

    </div>
    </form>
</body>
</html>
