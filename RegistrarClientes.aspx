<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarClientes.aspx.cs" Inherits="MANTENIMIENTOSITIOWEBCLIENTES2023121.RegistrarClientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Formulario Registrar Clientes</title>

    <link href="ESTILOS/Menu2.css" rel="stylesheet" type="text/css" />

	<meta charset="utf-8" />
	<style>
	    body { font-family: Helvetica, Arial, sans-serif; line-height: 1.3em; -webkit-font-smoothing: antialiased; }
	    .container {
	        width: 90%;
	        background-color: #FFF;
	        padding: 20px;
	        opacity:0.9;
            margin-left: auto;
            margin-right: auto;
            margin-bottom: 20px;
        }

      pre, code {
        font-family: Monaco, Menlo, Consolas, "Courier New", monospace;
        font-size: 12px;
        color: #333;
        -webkit-border-radius: 3px;
        -moz-border-radius: 3px;
        border-radius: 3px;
      }
	    pre { border: 1px solid #CCC; background-color: #EEE; color: #333; padding: 10px; overflow: scroll; }
      code { padding: 2px 4px; background-color: #F7F7F9; border: 1px solid #E1E1E8; color: #D14; }

      .other { height: 300px; color: #FFF; }
      .other div {
        position: absolute;
        bottom: 0;
        width: 100%;
        background: #000;
        background: rgba(0,0,0,0.7);
      }
      .other div p { padding: 10px; }
	    </style>

    <link type="text/css"rel="stylesheet" />

</head>
<body bgcolor="lightblue">
    <form id="form1" runat="server">
    
    <div class="container">

    <nav>
	<ul>
		<li><a href="IniciarSesion.aspx">Inicio</a></li>
		<li><a href="RegistrarClientes.aspx">Registrar Clientes</a>
        <li><a href="ConsultarClientes.aspx">Consultar Clientes</a>
        <li><a href="EliminarClientes.aspx">Eliminar Clientes</a>
        <li><a href="#">Reportar Clientes...</a>
			<ul>
						<li><a href="ReportarClientes.aspx">Reportar Todos Clientes</a></li>
						<li><a href="ReporteClientesPorNombre.aspx">Reportar Clientes por Nombre</a></li>
				</li>
			</ul>
		</li>
        <li><a href="IniciarSesion.aspx">Cerrar Sesión</a></li>
	</ul>
    </nav>

    <h1><br />
              <center>CTP de CALLE BLANCOS<br /></h1></Center>
              </center></h1>
      
    </div>

    <br />
    <center>
    <asp:Label ID="Label1" runat="server" Text="Registrando Clientes" Font-Bold="True" Font-Size="28px" ForeColor="Red"></asp:Label>
    </center>
    <hr />
    
    <br />
    <div align="center">
    <table border="0">
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Identificación:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>                           
                <asp:Button ID="Button1" runat="server" Font-Bold="True" Text="Buscar" OnClick="Button1_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Nombre Cliente:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Teléfono Cliente:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Fecha Registro:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
        
    </table>
    </div>

    <br />
    <div align="center">
    <table border="1">
        <tr>
            <td>                    
                <asp:Button ID="Button2" runat="server" Font-Bold="True" Text="Registrar Cliente" OnClick="Button2_Click" />                    
            </td>
            <td>            
                <asp:Button ID="Button3" runat="server" Font-Bold="True" Text="Nuevo Cliente" OnClick="Button3_Click" />            
            </td>
        </tr>
    </table>        
    </div>
    
    </form>
</body>
</html>
