<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
        </div>
       select any name: 
        <br />
        <br />
        <asp:Image ID="Image1" runat="server" Height="353px" style="margin-right: 0px" Width="879px" />
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            Check the price of snacks: <asp:Button ID="price" runat="server" Text="price" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
