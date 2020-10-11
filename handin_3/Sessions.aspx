<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sessions.aspx.cs" Inherits="handin_3.Sessions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login page</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" integrity="sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z" crossorigin="anonymous">
</head>
<body>
    <h1 class="text-center mt-5">Login</h1>
    <form id="form1" runat="server" class="container-sm">
        <div class="d-flex flex-column py-5">
            <asp:TextBox ID="NameInput" placeholder="Username" runat="server" CSSClass="form-control"></asp:TextBox><br/>
            <asp:TextBox ID="PasswordInput" placeholder="Password" TextMode="Password" runat="server" CssClass="form-control"></asp:TextBox><br/>
            <asp:Button id="LoginBtn" runat="server" Text="Login" OnClick="OnLogin" CssClass="btn btn-block btn-success" />
            <asp:Label id="ErrMessage" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
