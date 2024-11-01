<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calculadora.aspx.cs" Inherits="WebApplication1.calculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>CALCULADORA WEB </title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1> CALCULADORA WEB</h1>
            <h2> Mi primer calcuadora</h2>

                <label> Numero1:
                 <br />
                <asp:TextBox ID="Tvalor1" type="number" Placeholder="Digite un numero" runat="server"></asp:TextBox>
                <br />

                Numero2:</label>
                <br />
                <asp:TextBox ID="Tvalor2" runat="server"></asp:TextBox>
                <br />


            <asp:Label ID="Lresultado" runat="server" Text=""></asp:Label>


            <asp:Button ID="Button1" runat="server" style="margin-left: 65px" Text="Aceptar" Width="58px" OnClick="Button1_Click" />


        </div>
        <p>
            <asp:RadioButton ID="rsuma" runat="server" GroupName="Radio" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Suma" ValidationGroup="Radio" />
            <asp:RadioButton ID="Rresta" runat="server" GroupName="Radio" Text="Resta" ValidationGroup="Radio" />
            <asp:RadioButton ID="Rmultiplicar" runat="server" GroupName="Radio" Text="Multiplicar" />
            <asp:RadioButton ID="Rdivision" runat="server" GroupName="Radio" Text="Dividir" />
        </p>
        <asp:DropDownList ID="Dlista" runat="server">
            <asp:ListItem>Suma</asp:ListItem>
            <asp:ListItem>Resta</asp:ListItem>
        </asp:DropDownList>
        <asp:CheckBox ID="Csuma" runat="server" Text="Suma" />
        <asp:CheckBox ID="Cresta" runat="server" Text="Resta" />
    </form>
</body>
</html>
