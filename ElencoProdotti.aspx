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
    </form>
</body>
</html>
