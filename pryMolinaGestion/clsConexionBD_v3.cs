using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;

//para conexion de ACcess
using System.Data.OleDb;

using System.Windows.Forms;
using System.Data;

namespace pryDiazGestionInventario
{
    internal class clsConexionBDv3
    {
        //cadena de conexion
        string cadenaConexion = "Server=localhost;Database=gestion;Trusted_Connection=True;";
        //string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\..\\bdclase\\Database2.accdb";
        //conector
        
        // OleDbConnection coneccionBaseDatos;
        //comando
        SqlConnection coneccionBaseDatos;

        SqlCommand comandoBaseDatos;
        //OleDbCommand comandoBaseDatos;

        //OleDbDataReader lectorDataReader;

        public string nombreBaseDeDatos;

        public void ConectarBD()
        {
            try
            {
                coneccionBaseDatos = new SqlConnection(cadenaConexion);
                //coneccionBaseDatos = new OleDbConnection(cadenaConexion);

                nombreBaseDeDatos = coneccionBaseDatos.Database;

                coneccionBaseDatos.Open();
                
                MessageBox.Show("Conectado a " + nombreBaseDeDatos);
            }
            catch (Exception error)
            {
                MessageBox.Show("Tiene un errorcito - " + error.Message);
            }     

        }

        public void cargarCategoria (ComboBox cmbcate)
        {
            ////creo en memoria el objeto
            //comandoBaseDatos = new OleDbCommand();
            ////cargo la conexion a la base
            //comandoBaseDatos.Connection = coneccionBaseDatos;

            ////dar indicaciones 
            //comandoBaseDatos.CommandType = System.Data.CommandType.Text;
            //// sentencia SQL para consultar la base
            //comandoBaseDatos.CommandText = "SELECT marca_nombre FROM productosuno";
            //lectorDataReader = comandoBaseDatos.ExecuteReader();

            //while (lectorDataReader.Read()) 
            //{
            //    cmbcate.Items.Add(lectorDataReader[0]);
            //}
        }
    }
}
