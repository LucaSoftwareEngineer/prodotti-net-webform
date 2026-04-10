<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AggiungiProdotto.aspx.cs" Inherits="WebForm1App.AggiungiProdotto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="salvaProdotto" runat="server">
        <asp:Label ID="lbl_titolo" runat="server" Text="Titolo: "></asp:Label>
        <asp:TextBox ID="titolo" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbl_prezzo" runat="server" Text="Prezzo: "></asp:Label>
        <asp:TextBox ID="prezzo" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="salva" runat="server" Text="Salva" OnClick="salva_Click" />
        <br />
        <asp:Label ID="lbl_esito_operazione" runat="server" Text=""></asp:Label>
    </form>

    <br />
    <br />

    <a href="ElencoProdotti.aspx">Elenco prodotti</a>
</body>
</html>
