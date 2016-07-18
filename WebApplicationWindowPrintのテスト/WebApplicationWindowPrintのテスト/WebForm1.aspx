<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="WebApplicationWindowPrintのテスト.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
            
        <asp:ScriptManager ID="ScriptManager1" runat="server" />

        <div style="border-style: solid; height: 50px;">

            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <div style="border-style: solid; height: 50px;">
                        <asp:Button ID="Button2" runat="server" Text="Button2" />
                        <iframe id="printFrame2" runat="server" src="No.aspx" style="width: 0px; height: 0px;" />
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>

               
        <div style="border-style: solid; height: 50px;">

            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                <ContentTemplate>
                    <div style="border-style: solid; height: 50px;">
                        <asp:Button ID="Button4" runat="server" Text="Button4" />
                        <iframe id="printFrame4" runat="server" src="No.aspx" style="width: 0px; height: 0px;" />
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
         
        <div style="border-style: solid; height: 50px;">
            <asp:Button ID="ButtonXXX" runat="server" Text="ButtonX_押さないで" />
            <input id="Button3" type="button" value="button3" onclick="runPrint();" />
            <iframe id="printFrame3" runat="server" src="No.aspx" style="width: 0px; height: 0px;" />
        </div>

                
        <div style="border-style: solid; height: 50px;">
            <asp:Button ID="Button1" runat="server" Text="Button1" />
            <iframe id="printFrame1" runat="server" src="No.aspx" style="width: 0px; height: 0px;" />
        </div>


        <script type="text/javascript">
            function runPrint() {
                document.getElementById("printFrame3").src = "WebFormPrint.aspx";
            }

        </script>
    </form>
</body>
</html>
