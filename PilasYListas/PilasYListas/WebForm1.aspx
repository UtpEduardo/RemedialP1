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
                <asp:Label ID="Label1" runat="server" Text="Agrege un Numero"></asp:Label>
                :&nbsp;
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
                <br />
                <asp:Label ID="Label3" runat="server" Text="Agregar algun dato: "></asp:Label>
&nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar" />
&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Mostrar Pila" />
                <br />
                <br />
                <asp:ListBox ID="ListBox1" runat="server" Height="101px" Width="350px"></asp:ListBox>
                <br />
                <br />
                <asp:Label ID="Label4" runat="server" Text="Escriba el Numero: "></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Buscar" />
                &nbsp;
                
                <br />
                <asp:Label ID="reBusqueda" runat="server"></asp:Label>
            </center>
        </div>
    </form>
</body>
</html>
