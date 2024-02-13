<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Pomeridiano.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Username:
            <asp:TextBox ID="TxtUsername" runat="server"></asp:TextBox>
            <Br />
            Password:
            <asp:TextBox ID="TxtPassword" runat="server" ></asp:TextBox>
            <asp:Button ID="BtnLogin" runat="server" Text="Button" OnClick="BtnLogin_Click" />
        </div>
    </form>
</body>
</html>
