/*
 * Clase que define todos los metodos para manipular aerolineas
 */
using System.Data;
using System.Data.SqlClient;
using Modelo;

namespace Datos.Logica
{
    public class AccionesCiudad : ILectura<Ciudad>, IEscritura<Ciudad>, IRemover<Ciudad>
    {
        private DBConexion conexion;
        private SqlDataReader leer;
        private SqlCommand comando;
        public AccionesCiudad()
        {
            conexion = new DBConexion();
            comando = new SqlCommand();
        }
        public bool agregar(Ciudad elemento)
        {
            bool estado = false;
            comando.Connection = conexion.abrirConexion();
            try
            {
                
                comando.CommandText = "InsertarCiudad";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Nombre",elemento.Nombre);
                comando.ExecuteNonQuery();
                estado = true;

            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Parametro no puede ser nulo");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Hubo un error en el procedimiento");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                comando.Parameters.Clear();
                conexion.cerrarConexion();

            }
            return estado;
        }

        public bool editar(Ciudad elemento)
        {
            bool estado = false;
            try
            {
                comando.Connection = conexion.abrirConexion();
                comando.CommandText = "ActualizarCiudad";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ID", elemento.ID);
                comando.Parameters.AddWithValue("@Nombre", elemento.Nombre);
                comando.ExecuteNonQuery();
                estado = true;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Parametro no puede ser nulo");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("El elemento buscado no se encuentra");
            }
            finally
            {
                comando.Parameters.Clear();
                conexion.cerrarConexion();
            }
            return estado;

        }

        public Ciudad obtener(int id)
        {
            Ciudad ciudad = null;
            comando.Connection = conexion.abrirConexion();
            try
            {
                comando.CommandText = "MostrarCiudad";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ID", id);
                leer = comando.ExecuteReader();
                leer.Read();
                ciudad = new Ciudad() { ID = leer.GetInt32(0), Nombre = leer.GetString(1) };
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("El elemento buscado no se encuentra");
            }
            finally
            {
                comando.Parameters.Clear();
                conexion.cerrarConexion();
            }
            return ciudad;
        }

        public List<Ciudad> obtenerTodos()
        {
            List<Ciudad> lista = new List<Ciudad>();
            comando.Connection = conexion.abrirConexion();
            try
            {
                comando.CommandText = "MostrarCiudades";
                comando.CommandType = CommandType.StoredProcedure;
                using (leer = comando.ExecuteReader())
                {
                    while (leer.Read())
                    {
                        lista.Add(new Ciudad() { ID = leer.GetInt32(0), Nombre = leer.GetString(1) });
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Ocurrio un error en la consulta");
            }
            finally
            {
                conexion.cerrarConexion();
            }
            return lista;
        }

        public bool remover(Ciudad elemento)
        {
            bool estado=false;
            comando.Connection = conexion.abrirConexion();
            try
            {
                comando.CommandText = "EliminarVueloXCiudad";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdCiudad", elemento.ID);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();

                comando.CommandText = "EliminarCiudad";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ID", elemento.ID);
                comando.ExecuteNonQuery();              
                estado = true;
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine("El elemento buscado no se encuentra");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("El elemento buscado no se encuentra");
            }
            finally
            {
                comando.Parameters.Clear();
                conexion.cerrarConexion();
            }
            return estado;

        }
    }
}
