<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostLogin.aspx.cs" Inherits="Login.PostLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Čestitam, uspješno se prijavili u smeće od web formsa. Domagoj voli web forms.</div>
        <p>
            <asp:LoginName ID="LoginName1" runat="server" FormatString="Korisnik: {0}" />
        </p>
        <p>
            <asp:LoginStatus ID="LoginStatus1" runat="server" LogoutAction="Redirect" LogoutPageUrl="~/Login.aspx" />
        </p>
    </form>
</body>
</html>
