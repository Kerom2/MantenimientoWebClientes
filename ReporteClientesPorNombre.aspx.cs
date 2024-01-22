using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MANTENIMIENTOSITIOWEBCLIENTES2023121
{
    public partial class ReporteClientesPorNombre : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Focus();
        }

        //Botón Mostrar
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                Response.Write(
                "<script language='JavaScript'>alert('Faltan Datos por Completar..');</script>");
            }
        }
    }
}