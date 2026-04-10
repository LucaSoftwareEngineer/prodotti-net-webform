<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForm1App._Default" %>

<html>
    <body>
        <form id="loginForm" runat="server">
            <b>Username: </b>
            <asp:TextBox ID="Username" runat="server"></asp:TextBox>
            <br />
            <b>Password: </b>
            <asp:TextBox ID="Password" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="LoginButton_Click" />
        </form>
    </body>
</html>
