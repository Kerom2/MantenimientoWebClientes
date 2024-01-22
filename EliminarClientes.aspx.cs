using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MANTENIMIENTOSITIOWEBCLIENTES2023121.AppCode;

namespace MANTENIMIENTOSITIOWEBCLIENTES2023121
{
    public partial class EliminarClientes : System.Web.UI.Page
    {
        ModeloDatos m = new ModeloDatos();

        protected void Page_Load(object sender, EventArgs e)
        {
            bloquearobjetos();
            TextBox1.Focus();
        }

        public void bloquearobjetos()
        {
            Button1.Enabled = true;
            Button2.Enabled = false;
        }

        public void desbloquearobjetos()
        {
            Button1.Enabled = false;
            Button2.Enabled = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                Response.Write(
                 "<script language='JavaScript'>alert('Faltan Datos por Completar..');</script>");
                TextBox1.Focus();
            }
            else
            {
                //Llama a la función buscaridentificacion del modelodatos
                if (m.buscaridentificacion(TextBox1.Text) == 1)
                {
                    Response.Write(
                     "<script language='JavaScript'>alert('Cliente Encontrado, se mostrarán sus Datos..');</script>");
                    desbloquearobjetos();
                    TextBox1.Focus();
                }
                else
                {
                    Response.Write(
                     "<script language='JavaScript'>alert('Cliente No Encontrado..');</script>");
                    TextBox1.Text = "";
                    TextBox1.Focus();
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Write(
            "<script language='JavaScript'>alert('Cliente Eliminado Correctamente..');</script>");
            m.eliminarcliente(TextBox1.Text);
            TextBox1.Text = "";
        }
    }
}