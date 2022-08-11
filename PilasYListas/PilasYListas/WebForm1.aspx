<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PilasYListas.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <h2>Agregar</h2>
                <br />
                    <asp:Label ID="Label1" runat="server" Text="Agrega un numero"></asp:Label>
               

            &nbsp;
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar" />
                <br />
                <br />
                <asp:Label ID="Label2" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Mostrar Pila" />
                <br />
                <br />
                <asp:ListBox ID="ListBox1" runat="server" Height="120px" Width="528px"></asp:ListBox>
                <br />
                <br />
                <asp:Label ID="Label3" runat="server" Text="Coloque el numero que desea Buscar o Eliminar"></asp:Label>
&nbsp;
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;&nbsp;
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Buscar" />
&nbsp;&nbsp;
                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Eliminar" />
                <br />
                <br />
                <asp:Label ID="Label4" runat="server"></asp:Label>
               

            </center>
        </div>
    </form>
</body>
</html>
