/*
 * Clase que define todos los metodos para manipular aerolineas
 */

using System.Data;
using System.Data.SqlClient;
using Modelo;

namespace Datos.Logica
{
    public class AccionesAerolinea : ILectura<Aerolinea>, IEscritura<Aerolinea>, IRemover<Aerolinea>
    {
        private DBConexion conexion;
        private SqlDataReader leer;
        private SqlCommand comando;
        public AccionesAerolinea()
        {
            conexion= new DBConexion();
            comando = new SqlCommand();

        }
        public bool agregar(Aerolinea elemento)
        {
            bool estado = false;
            comando.Connection = conexion.abrirConexion();
            try
            {
                comando.CommandText = "InsertarAerolinea";
                comando.CommandType = CommandType.StoredProcedure;
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

        public bool editar(Aerolinea elemento)
        {
            bool estado = false;
            comando.Connection = conexion.abrirConexion();
            try
            {
                comando.CommandText = "ActualizarAerolinea";
                comando.CommandType=CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ID",elemento.ID);
                comando.Parameters.AddWithValue("@Nombre", elemento.Nombre);
                comando.ExecuteNonQuery ();
                estado=true;
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

        public Aerolinea obtener(int id)
        {
            Aerolinea aerolinea = null;
            comando.Connection = conexion.abrirConexion();
            
            try
            {
                comando.CommandText = "MostrarAerolinea";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ID", id);
                leer = comando.ExecuteReader();
                leer.Read();
                aerolinea = new Aerolinea() { ID = leer.GetInt32(0), Nombre = leer.GetString(1) };
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
            return aerolinea;
        }

        public List<Aerolinea> obtenerTodos()
        {
            List<Aerolinea > list = new List<Aerolinea>();
            comando.Connection = conexion.abrirConexion();
            try
            {
                comando.CommandText = "MostrarAerolineas";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    list.Add(new Aerolinea() { ID = leer.GetInt32(0), Nombre = leer.GetString(1) });
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
            return list;
        }

        public bool remover(Aerolinea elemento)
        {
            bool estado = false;
            comando.Connection = conexion.abrirConexion();
            try
            {
                comando.CommandText = "EliminarVueloXAerolinea";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdAerolinea", elemento.ID);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                comando.CommandText = "EliminarAerolinea";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ID",elemento.ID);
                comando.ExecuteNonQuery();
                estado = true;

            }catch(NullReferenceException ex)
            {
                Console.WriteLine("El elemento buscado no se encuentra");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("No se pudo completar el procedimieto");
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
