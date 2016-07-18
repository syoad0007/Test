<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="TreeView_Test.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="App_Themes/Theme1/StyleSheet1.css" type="text/css" />
    <script type="text/javascript" src="Scripts/jquery-1.10.2.js"></script>
    <script type="text/javascript" src="App_Themes/Theme1/JSFile.js"></script>

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="float:left;">
            <!-- TreeView -->
            <div>
                <asp:TreeView ID="TreeView1" runat="server" OnSelectedNodeChanged="Select_Change" SelectedNodeStyle-CssClass="ChangeRow" ShowLines="True">
                </asp:TreeView>
            </div>

            <!-- Table(TreeViewのデータを設定する) -->
            <table>
            </table>

            <!-- Table(TreeViewのデータを設定する) -->
            <asp:Table ID="Table1" runat="server"></asp:Table>

            <!-- GridView(TreeViewのデータを設定する) -->
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" ShowHeader="false" >

                <RowStyle CssClass="RowColor SelectRow" />
                <AlternatingRowStyle CssClass="RRowColor SelectRow" />

                <Columns>
                    <asp:BoundField DataField="Name" />
                    <asp:BoundField DataField="Data" ItemStyle-CssClass="nodisp" HeaderStyle-CssClass="nodisp"  />
                </Columns>

            </asp:GridView>
            <asp:HiddenField ID="SelectRowNo" runat="server" />
        </div>

        <div style="float:left;">
            <br /><br /><br /><br />
            <input id="BtnTreeRight" type="button" value="button" />
            <br /><br />
            <input id="Button2" type="button" value="button" />
            <br /><br /><br /><br /><br /><br />
            <input id="BtnGVRight" type="button" value="button" />
            <br /><br />
            <input id="Button4" type="button" value="button" />
        </div>



                
        <div style="float:none;">


            <asp:Table ID="Table2" runat="server">

                

            </asp:Table>

            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="false" ShowHeader="false" >
                
                <RowStyle CssClass="RowColor SelectRow" />
                <AlternatingRowStyle CssClass="RRowColor SelectRow" />

                <Columns>
                    <asp:BoundField DataField="Name" />
                    <asp:BoundField DataField="Data" ItemStyle-CssClass="nodisp" HeaderStyle-CssClass="nodisp" />
                    
                </Columns>
                <EmptyDataTemplate >
                 
                </EmptyDataTemplate>
            </asp:GridView>

            <asp:ListView ID="ListView1" runat="server"></asp:ListView>


        </div>


    </form>
</body>
</html>
