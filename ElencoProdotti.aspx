<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ElencoProdotti.aspx.cs" Inherits="WebForm1App.ElencoProdottiaspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        Cerca: <asp:TextBox ID="CercaInput" runat="server"></asp:TextBox> 
        &nbsp; <asp:Button ID="CercaButton" runat="server" Text="Cerca" OnClick="CercaButton_Click" />
        &nbsp; <asp:Button ID="AnnullaRicercaButton" runat="server" Text="Annulla" OnClick="AnnullaRicercaButton_Click" />
        <br />
        <br />

        Elenco prodotti:
        <br />
        <asp:GridView ID="GridViewProdotti" runat="server" AutoGenerateColumns="true" ></asp:GridView>

        <br />
        <br />

        <a href="AggiungiProdotto.aspx">Aggiungi prodotto</a>
        
        <br />
        <br />

        <asp:Button ID="LogoutButton" runat="server" Text="Logout" OnClick="LogoutButton_Click" />

    </form>
</body>
</html>
