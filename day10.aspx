<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="day10.aspx.cs" Inherits="WebsiteUI.day10" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox><br />

    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
    
    <asp:Button ID="btnadd" runat="server" Text="+" OnClick="btnadd_Click"/><br />
    <asp:Button ID="btnsub" runat="server" Text="-" OnClick="btnsub_Click"/><br />
    <asp:Button ID="btnmul" runat="server" Text="*" OnClick="btnmul_Click"/><br />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br />
    






    </div>
    </form>
</body>
</html>
