using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Sql;
//Biblioteca que permite hacer conexión con motor SQL
using System.Data.SqlClient;
//Biblioteca para poder ejecutar comandos en tablas BD
using System.Data;
//using MANTENIMIENTOSITIOWEBCLIENTES2023121;

namespace MANTENIMIENTOSITIOWEBCLIENTES2023121.AppCode
{
    public class ModeloDatos
    {
        //Definiendo e instanciando en la variable cn la clase BASEDATOS
        //que pertenece a el paquete CONEXIONBASEDATOS
        public ConexionBaseDatos cn = new
            ConexionBaseDatos();

        //Define y construye una variable de tipo objeto que
        //permite hacer conexión con la BD de SQLServer
        //En el paréntesis lo que iría es la cadena de conexión
        //a la BD
        public SqlConnection oConexion =
            new SqlConnection(
            "Data Source=LAPTOP-CNF1PP8B;Initial Catalog=CLIENTESWEB2023121;Integrated Security=True");

        //Define e instancia la variable oDataSet del tipo de objeto DataSet
        //que funciona similar al ResultSet del entorno de Java
        public DataSet oDataSet = new DataSet();

        //Define e instancia la variable oDataAdapter del tipo de objeto
        //SqlDataAdapter. Este objeto permite utilizar y ejecutar las
        //sentencias e instrucciones de SQL en las tablas de la BD y 
        //funciona similar al objeto Statement de Java
        public SqlDataAdapter oDataAdapter = new SqlDataAdapter();

        //Esta función permite buscar una identifcación en la tablaclientes de la BD
        public int buscaridentificacion(string ide)
        {
            int enco = 0;
            try
            {
                cn.conectarbase(); //Conectar con la BD
                SqlCommand oCmdConsulta = new SqlCommand("SELECT * FROM TABLACLIENTES WHERE IDENTIFICACION = '" + ide + "'", oConexion);
                //Plantear la instrucción en SQL que se va a ejecutar
                oDataAdapter.SelectCommand = oCmdConsulta;
                //Ejecuta por medio del oDataAdapter la instrucción que está almacenada
                //en oCmdConsulta
                oDataSet.Clear();
                oConexion.Open(); //Abre la conexión
                oDataAdapter.Fill(oDataSet, "TABLACLIENTES");
                //Rellena el DataSet con los datos que obtiene de la tablaclientes
                //cuando se hace el Select
                oConexion.Close();

                //Si el DataSet es mayor que 0 quiere decir que hubo datos encontrados
                //cuando realizó la consulta o select
                if (oDataAdapter.Fill(oDataSet) > 0)
                    enco = 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                cn.desconectarbase();
            }
            return enco;
        } //Cierra función

        //Procedimiento que permite ingresar un cliente en la tablaclientes
        public void ingresarcliente(String identificacion, String nombre,
            String telefono, DateTime fecha)
        {
            try
            {
                cn.conectarbase();
                //Aquí construye el objeto oCmdInsercion con la instrucción en SQL de insertar
                SqlCommand oCmdInsercion = new SqlCommand("INSERT INTO TABLACLIENTES (IDENTIFICACION,NOMBRE,TELEFONO,FECHA) VALUES (@identificacion,@nombre,@telefono,@fecha)", oConexion);
                oDataAdapter.InsertCommand = oCmdInsercion;
                //Aquí ejecuta la instrucción SQL que está en oCmdInsercion

                //Aquí se especifican los tipos de datos de cada uno de los parámetros que van en los values
                oDataAdapter.InsertCommand.Parameters.Add(
                    new SqlParameter("@identificacion", SqlDbType.VarChar));
                oDataAdapter.InsertCommand.Parameters.Add(
                    new SqlParameter("@nombre", SqlDbType.VarChar));
                oDataAdapter.InsertCommand.Parameters.Add(
                    new SqlParameter("@telefono", SqlDbType.VarChar));
                oDataAdapter.InsertCommand.Parameters.Add(
                    new SqlParameter("@fecha", SqlDbType.Date));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                cn.desconectarbase();
            }
        }

        //Método tipo procedimiento que permite mostrar los datos de un cliente
        //en el formulario
        public void eliminarcliente(String ide)
        {
            try
            {
                cn.conectarbase();
                //Aquí se construye una variable de tipo objeto SqlCommand la cual
                //tiene almacenado la instrucción en SQL que se va a ejecutar
                //sobre la tablaclientes
                SqlCommand oCmdElimina = new SqlCommand(
                    "DELETE FROM TABLACLIENTES WHERE IDENTIFICACION = '" + ide + "'", oConexion);
                oDataAdapter.SelectCommand = oCmdElimina;
                //Ejecuta la instrucción en SQL que está en oCmdConsulta
                oDataSet.Clear();
                oConexion.Open();
                oDataAdapter.Fill(oDataSet, "tablaclientes");
                oConexion.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                cn.desconectarbase();
            }
        }
    }
}