<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ElencoProdotti.aspx.cs" Inherits="WebForm1App.ElencoProdottiaspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Elenco prodotti:
        <br />
        <asp:GridView ID="GridViewProdotti" runat="server" AutoGenerateColumns="true" ></asp:GridView>

        <br />
        <br />

        <a href="AggiungiProdotto.aspx">Aggiungi prodotto</a>
        
        <br />
        <br />

        Elimina prodotto con codice:
        &nbsp; <asp:TextBox ID="IdProdottoDaEliminareInput" runat="server"></asp:TextBox>
        &nbsp; <asp:Button ID="EliminaProdotto" runat="server" Text="Elimina" OnClick="EliminaProdotto_Click" />
        <br /> <asp:Label ID="ProdottoDaEliminareNonTrovatoLabel" runat="server" Text="Prodotto non trovato"></asp:Label>

        <br />
        <br />

        <asp:Button ID="LogoutButton" runat="server" Text="Logout" OnClick="LogoutButton_Click" />

    </form>
</body>
</html>
