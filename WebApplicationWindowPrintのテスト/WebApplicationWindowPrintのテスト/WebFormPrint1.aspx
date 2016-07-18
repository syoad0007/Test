<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebFormPrint1.aspx.vb" Inherits="WebApplicationWindowPrintのテスト.WebFormPrint1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <script type="text/javascript">
        function runPrint() {

            self.window.focus();
            self.window.print();
        }


    </script>
    </div>
    </form>
</body>
</html>
