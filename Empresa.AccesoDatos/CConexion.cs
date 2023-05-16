using Npgsql;
using System;   
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Empresa.AccesoDatos
{
    public class CConexion
    {
        NpgsqlConnection conex = new NpgsqlConnection();
        /*
        static string servidor="localhost";
        static string bd="BD_Ejemplo";
        static string usuario="postgres";
        static string password="1234";
        static string puerto="5432";

        string cadenaConexion = "server="+servidor+";"+"port="+puerto+";"+"user id="+usuario+";"+"password="+password+";"+
            "database="+bd+";";*/

        string cadenaConexion = String.Format("Server ={0};Port={1}; User id={2}; Password={3};" +
            "Database={4}","localhost",5432, "postgres",1234,"BD_Ejemplo");

        public NpgsqlConnection estableConexion()
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                MessageBox.Show("Se conectó correctamente");
            }
            catch(NpgsqlException e)
            {

                MessageBox.Show("No se pudo establecer la conexión a la Base de Datos Postgresql, error: " + e.ToString());
            }
            return conex;
        }

        public NpgsqlConnection cerrarConexion()
        {
            try
            {
                if (conex != null)
                {
                    conex.Close();
                    MessageBox.Show("Se cerró la conexión!!!!!!");
                }

            }catch(NpgsqlException e)
            {
                MessageBox.Show("No se pudo cerrar la conexión a la Base de Datos Postgresql, error: " + e.ToString());
            }
            
            return conex;
        }

        public async Task<NpgsqlConnection> crearTablaEmpleadoAsync()
        {
            try
            {
                conex.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = conex;
                cmd.CommandText = $"DROP TABLE IF EXISTS tbEmpleado";
                await cmd.ExecuteNonQueryAsync();
                cmd.CommandText = "CREATE TABLE tbEmpleado (" +
                    "idE INT PRIMARY KEY," +
                    "nombre VARCHAR(50) NOT null," +
                    "apellidoP VARCHAR(50) NOT null," +
                    "apellidoS VARCHAR(50) NOT null," +
                    "cedula INT not null," +
                    "salario DOUBLE NOT null, " +
                    "correo VARCHAR(100) NOT null," +
                    "celular INT NOT null)";
                await cmd.ExecuteNonQueryAsync();
                MessageBox.Show("Tabla creada correctamente!!!!!!");
            }
            catch(NpgsqlException e)
            {
                MessageBox.Show("No se pudo crear la Tabla Empleado..., error:  " + e.ToString());
            }
            return conex;
        }

    }
}
