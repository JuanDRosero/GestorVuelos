/*
 * Clase Conexión BD Sql Server 2019
 * 
 */
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    internal class DBConexion
    {
        private readonly SqlConnection conexion;    //Conexión a la base de datos
        public DBConexion() //Hay que cambiar la cadena de conexión
        {
            conexion =new SqlConnection("Server=LAPTOP-KL3O55FP\\SQLEXPRESS;DataBase= Prueba;Integrated Security=true; Encrypt=False");
        }

        public SqlConnection abrirConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Closed)
                    conexion.Open();
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return conexion;
        }
        public SqlConnection cerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }
    }
}
