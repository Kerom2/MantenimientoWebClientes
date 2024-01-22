using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MANTENIMIENTOSITIOWEBCLIENTES2023121.AppCode;

namespace MANTENIMIENTOSITIOWEBCLIENTES2023121
{
    
    public partial class RegistrarClientes : System.Web.UI.Page
    {
        ModeloDatos m = new ModeloDatos();

        protected void Page_Load(object sender, EventArgs e)
        {
            bloquearobjetos();

            //Obtiene la fecha del sistema en la variable today
            DateTime today = DateTime.Today;
            //Despliega la fecha del sistema, asignándola al campo texto
            //TextBox4 en formato corto
            TextBox4.Text = 
                Convert.ToString(today.ToShortDateString());

            TextBox1.Focus();
        }

        public void bloquearobjetos()
        {
            TextBox1.Enabled = true;
            TextBox2.Enabled = false;
            TextBox3.Enabled = false;
            TextBox4.Enabled = false;
            Button1.Enabled = true;  //Buscar
            Button2.Enabled = false; //Nuevo Cliente
            Button3.Enabled = true;  //Registrar
        }

        public void desbloquearobjetos()
        {
            TextBox1.Enabled = false;
            TextBox2.Enabled = true;
            TextBox3.Enabled = true;
            TextBox4.Enabled = false;
            Button1.Enabled = false;  //Buscar
            Button2.Enabled = true;   //Registrar Cliente
            Button3.Enabled = true;   //Nuevo Cliente
        }

        public void limpiarcampostextos()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox1.Focus();
        }

        //Botón Buscar
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                //Con el Response.Write se envían mensajes en un Web Form
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
                     "<script language='JavaScript'>alert('Cliente YA está Registrado..');</script>");
                    TextBox1.Focus();
                }
                else
                {
                    Response.Write(
                     "<script language='JavaScript'>alert('Cliente No está Registrado, Puede Registrarlo..');</script>");
                    desbloquearobjetos();
                    TextBox2.Focus();
                }
            }
        }

        //Botón Nuevo Cliente
        protected void Button3_Click(object sender, EventArgs e)
        {
            limpiarcampostextos();
            bloquearobjetos();
        }

        //Botón RegistrarCliente
        protected void Button2_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "") || (TextBox2.Text == "") ||
                (TextBox3.Text == "") || (TextBox4.Text == ""))
            {
                Response.Write(
                 "<script language='JavaScript'>alert('Faltan Datos por Completar..');</script>");
                //textBox1.Focus();
            }
            else
            {
                //Aquí invoca el método ingresarcliente del Modelo de datos
                //con cada uno de los nombres de los objetos del formulario
                m.ingresarcliente(this.TextBox1.Text,
                    this.TextBox2.Text, this.TextBox3.Text,
                    Convert.ToDateTime(TextBox4.Text));

                //Aquí le pasa cada uno de los campos textos a los parámetros del procedimiento ingresar en el 
                //modelo de datos y los que son double y dateTimePicker se convierten al tipo de dato
                m.oDataAdapter.InsertCommand.Parameters["@identificacion"].Value =
                    this.TextBox1.Text;
                m.oDataAdapter.InsertCommand.Parameters["@nombre"].Value =
                    this.TextBox2.Text;
                m.oDataAdapter.InsertCommand.Parameters["@telefono"].Value =
                    this.TextBox3.Text;
                m.oDataAdapter.InsertCommand.Parameters["@fecha"].Value =
                    Convert.ToDateTime(this.TextBox4.Text);

                //Abre la conexión
                m.oConexion.Open();

                //Aquí ejecuta la inserción del cliente
                m.oDataAdapter.InsertCommand.ExecuteNonQuery();

                Response.Write(
                 "<script language='JavaScript'>alert('Cliente Registrado Correctamente..');</script>");

                m.oConexion.Close(); //Cierra la conexión

                bloquearobjetos();

                TextBox1.Focus();
            }
        }
    }
}