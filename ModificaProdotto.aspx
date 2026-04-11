<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModificaProdotto.aspx.cs" Inherits="WebForm1App.ModificaProdotto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:HiddenField ID="idProdottoHidden" runat="server" />

            Titolo: 
            &nbsp; <asp:TextBox ID="TitoloInput" runat="server"></asp:TextBox>

            <br />

            Prezzo: 
            &nbsp; <asp:TextBox ID="PrezzoInput" runat="server"></asp:TextBox>

            <br />

            <asp:Button ID="Modifica" runat="server" Text="Modifica" OnClick="Modifica_Click" />

            <br />

            <asp:Label ID="RisulatatoModifica" runat="server" Text=""></asp:Label>

            <br />
            <br />

            <a href="ElencoProdotti.aspx">Elenco prodotti</a>

            <br />
            <br />

            <asp:Button ID="LogoutButton" runat="server" Text="Logout" OnClick="LogoutButton_Click" />

        </div>
    </form>
</body>
</html>
