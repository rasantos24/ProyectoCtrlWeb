<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerInventarios.aspx.cs" Inherits="CtrlWebT.VerInventarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Buscar en el Inventario: 
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button runat="server" Text="Ver" OnClick="Unnamed1_Click" />
        </div>
        <div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>

