<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IniciarSesion.aspx.cs" Inherits="MANTENIMIENTOSITIOWEBCLIENTES2023121.IniciarSesion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Formulario Inicio de Sesión</title>
</head>
<body bgcolor="lightblue">
    <form id="form1" runat="server">
    
    <div align="center">
        <br />
        <asp:Label ID="Label4" runat="server" Text="CTP de Calle Blancos" Font-Bold="True" Font-size=28px ForeColor="#FF3300" Font-family ="Century Gothic"></asp:Label>        
        <br /> <br />
        <asp:Label ID="Label5" runat="server" Text="Especialidad Desarrollo de Software" Font-Bold="True" Font-size=28px ForeColor="blue"></asp:Label>
    </div>    
    
    <div align="center">
    <br />
    <hr />         
        <br /> <br /> <br />
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="18pt" ForeColor="Red" Font-family="Century Gothic" Text="Iniciando Sesión de Usuario"></asp:Label>
        <hr />
        <br />
    </div>

        <div align="center">
        <table border="0">
            <tr>
                <td> 
                    <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="14pt" Font-family="Century Gothic" Text="Usuario:"></asp:Label>
                </td>
                <td> 
                    <asp:TextBox ID="TextBox1" runat="server" Font-Bold="True" Font-Size="14pt" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>

                </td>
                <td>

                </td>
            </tr>
            <tr>
                <td> 
                    <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Size="14pt" Font-family="Century Gothic" Text="Contraseña:"></asp:Label>
                </td>
                <td> 
                    <asp:TextBox ID="TextBox2" runat="server" Font-Bold="True" Font-Size="14pt" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
         </table>
        <br />
        <hr />

        <div align="center">
        <table border="1">
            <tr>
                <td>                     
                    <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Size="16pt" Text="Iniciar" OnClick="Button1_Click" />                    
                </td>
                <td> 
                    <asp:Button ID="Button2" runat="server" Font-Bold="True" Font-Size="16pt" Text="Limpiar" OnClick="Button2_Click" />
                </td>
            </tr>
        </table>

    </form>
</body>
</html>
