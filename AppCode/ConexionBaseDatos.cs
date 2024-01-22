using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Sql;
//Biblioteca que permite hacer conexión con motor SQL
using System.Data.SqlClient;
//Biblioteca para poder ejecutar comandos en tablas BD
using System.Data;

namespace MANTENIMIENTOSITIOWEBCLIENTES2023121.AppCode
{
    public class ConexionBaseDatos
    {
        //Define y construye una variable de tipo objeto que
        //permite hacer conexión con la BD de SQLServer
        //En el paréntesis lo que iría es la cadena de conexión
        //a la BD
        public SqlConnection oConexion =
            new SqlConnection(
            "Data Source=LAPTOP-CNF1PP8B;Initial Catalog=CLIENTESWEB2023121;Integrated Security=True");

        public void conectarbase()
        {
            try
            {
                oConexion.Open();
                Console.WriteLine("Conectado..");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                if (oConexion.State == ConnectionState.Open)
                    oConexion.Close();
            }
        }

        public void desconectarbase()
        {
            try
            {
                if (oConexion.State == ConnectionState.Open)
                    oConexion.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}