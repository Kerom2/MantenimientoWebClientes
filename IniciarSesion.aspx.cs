using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MANTENIMIENTOSITIOWEBCLIENTES2023121
{
    public partial class IniciarSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Focus();
        }

        //Botón Iniciar Sesión
        protected void Button1_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "") || (TextBox2.Text == ""))
            {
                Response.Write(
                 "<script language='JavaScript'>alert('Faltan Datos por Completar...!!!');</script>");
            }
            else
            //Aquí verifica que el usuario sea root y el password root y si son correctos
            //permite redireccionar o llamar al WebForm MenuPrincipal
            if ((TextBox1.Text == "root") && (TextBox2.Text == "root"))
            {
                FormsAuthentication.RedirectFromLoginPage(
                 TextBox1.Text, false);
                Response.Redirect("MenuPrincipal.aspx");
            }
            else
            {
                //Despliega mensaje en JS que Credenciales incorrectos
                Response.Write(
                "<script language='JavaScript'>alert('Credenciales Incorrectos...!!!');</script>");
            }

        }

        //Botón limpiar
        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
    }
}