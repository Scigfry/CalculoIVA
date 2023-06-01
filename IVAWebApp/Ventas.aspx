<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ventas.aspx.cs" Inherits="IVAWebApp.Ventas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Hola mundo</h1>
        </div>

        <asp:RadioButtonList ID="RadioButtonList1" runat="server" Height="110px" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" Width="247px">
            <asp:ListItem Value="0">Generico</asp:ListItem>
            <asp:ListItem Value="1">Reducido</asp:ListItem>
            <asp:ListItem Value="2">Basico</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Panel ID="Panel1" runat="server" Height="167px">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br />
            <asp:TextBox ID="TextBox1" runat="server" Height="49px"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Calcular valor original" />
            <asp:Button ID="Button2" runat="server" Height="77px" OnClick="Button2_Click" Text="Button" />
        </asp:Panel>
            
    </form>
</body>
</html>
