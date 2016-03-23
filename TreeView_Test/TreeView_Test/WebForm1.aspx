<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="TreeView_Test.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="App_Themes/Theme1/StyleSheet1.css" type="text/css" />

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <!-- TreeView -->
        <div>
            <asp:TreeView ID="TreeView1" runat="server" OnSelectedNodeChanged="Select_Change">
                

            </asp:TreeView>




        </div>



        <!-- Table(TreeViewのデータを設定する) -->
        <table>
        </table>

                
        <!-- Table(TreeViewのデータを設定する) -->
        <asp:Table ID="Table1" runat="server"></asp:Table>

        <!-- GridView(TreeViewのデータを設定する) -->
        <asp:GridView ID="GridView1" runat="server">


            <Columns>
                <asp:BoundField DataField="Name" ItemStyle-CssClass="nodisp" HeaderStyle-CssClass="nodisp" />
                <asp:BoundField DataField="Data" />
            </Columns>
        </asp:GridView>


    </form>
</body>
</html>
