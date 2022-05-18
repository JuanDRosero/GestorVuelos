/*
 * Clase que valida las credenciales de un administrador
 * 
 */
using System.Data;
using System.Data.SqlClient;

namespace Datos.Logica
{
    public class AccionesAdmin
    {
        private DBConexion conexion;
        private SqlDataReader leer;
        private SqlCommand comando;
        public AccionesAdmin()
        {
            conexion= new DBConexion();
            comando= new SqlCommand();
        }
        public bool Validar(int Cedula, string pass)
        {
            bool validar = false;
            if (!String.IsNullOrEmpty(pass))
            {
                comando.Connection = conexion.abrirConexion();
                try
                {
                    comando.Connection = conexion.abrirConexion();
                    comando.CommandText = "ValidarAdmin";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@Cedula", Cedula);
                    comando.Parameters.AddWithValue("@Contrasena", pass);
                    leer = comando.ExecuteReader();
                    if (leer.HasRows)
                        validar = true;

                }
                catch (Exception)
                {
                    Console.WriteLine("Ha ocurrido un error en la consulta");
                }
                finally
                {
                    conexion.cerrarConexion();
                }
                
            }
            return validar;
        }
    }
}
