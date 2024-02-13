<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Pomeridiano.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Ciao 
            <br />
            <asp:Label ID="LblShow" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Button ID="BtnLogout" runat="server" Text="Logout" OnClick="BtnLogout_Click" />
        </div>
    </form>
</body>
</html>
