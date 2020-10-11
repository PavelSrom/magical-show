<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewMember.aspx.cs" Inherits="handin_3.NewMember" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" integrity="sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z" crossorigin="anonymous">
</head>
<body>
    <h1 class="text-center mt-5">Register new member</h1>
    <form id="form1" runat="server" class="py-5">
        <div class="container-sm d-flex flex-column align-items-center">
            <asp:TextBox ID="TrickInput" placeholder="Favorite trick" runat="server" CssClass="form-control mb-2"></asp:TextBox>
            <asp:TextBox ID="SalaryInput" placeholder="Salary" runat="server" CssClass="form-control mb-2"></asp:TextBox>
            <asp:TextBox ID="NameInput" placeholder="Username" runat="server" CssClass="form-control mb-2"></asp:TextBox>
            <asp:TextBox ID="PasswordInput" placeholder="Password" TextMode="Password" runat="server" CssClass="form-control mb-2"></asp:TextBox>
            <div class="d-flex justify-content-around w-100 mt-4">
                <asp:Button runat="server" Text="Register a magician" OnClick="OnRegisterMagic" CssClass="btn btn-outline-success" />
            <asp:Button runat="server" Text="Register a staff member" OnClick="OnRegisterStaff" CssClass="btn btn-outline-success" />
            </div>
            <asp:Label id="LoginMsg" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
