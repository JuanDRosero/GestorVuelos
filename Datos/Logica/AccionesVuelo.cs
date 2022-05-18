/*
 * Clase que define todos los metodos para manipular los vuelos
 */
using System.Data;
using System.Data.SqlClient;
using Modelo;

namespace Datos.Logica
{
    public class AccionesVuelo : ILectura<Vuelo>, IEscritura<Vuelo>
    {
        private SqlCommand comando;
        private DBConexion conexion;
        private SqlDataReader leer;
        private AccionesAerolinea aa;
        private AccionesCiudad ac;
        public AccionesVuelo()
        {
            conexion= new DBConexion();
            comando = new SqlCommand();
            aa= new AccionesAerolinea();
            ac= new AccionesCiudad();
        }
        public bool agregar(Vuelo elemento)
        {
            bool estado = false;
            comando.Connection = conexion.abrirConexion();
            try
            {
                comando.CommandText = "InsertarVuelo";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@NumeroV",elemento.ID);
                comando.Parameters.AddWithValue("@Fecha", elemento.Fecha);
                comando.Parameters.AddWithValue("@Salida",elemento.HSalida);
                comando.Parameters.AddWithValue("@Llegada", elemento.HLlegada);
                comando.Parameters.AddWithValue("@COrigen", elemento.Origen.ID);
                comando.Parameters.AddWithValue("@CDestino", elemento.Destino.ID);
                comando.Parameters.AddWithValue("@Aerolinea",elemento.Aerolinea.ID);
                comando.Parameters.AddWithValue("@Estado", elemento.Estado == true ? 1 : 0);
                comando.ExecuteNonQuery();
                estado = true;

            }
            catch(SqlException ex)
            {
               MessageBox.Show("Test");
                Console.WriteLine("El no. ya existe");
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

        public bool editar(Vuelo elemento)
        {
            bool estado = false;
            comando.Connection = conexion.abrirConexion();
            try
            {
                comando.CommandText = "CambiarEstadoVuelo";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ID", elemento.ID);
                comando.Parameters.AddWithValue("@Estado", elemento.Estado == true ? 1 : 0);
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

        public Vuelo obtener(int id)
        {
            Vuelo vuelo = null;
            comando.Connection = conexion.abrirConexion();
            
            try
            {
                comando.CommandText = "MostrarVuelo";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ID", id);
                leer = comando.ExecuteReader();
                leer.Read();
                vuelo = new Vuelo()
                {
                    ID = leer.GetInt32(0),
                    Fecha = leer.GetDateTime(1),
                    HSalida = leer.GetTimeSpan(2),
                    HLlegada = leer.GetTimeSpan(3),
                    Origen = ac.obtener(leer.GetInt32(4)),
                    Destino = ac.obtener(leer.GetInt32(5)),
                    Aerolinea = aa.obtener(leer.GetInt32(6)),
                    Estado = leer.GetBoolean(7)
                };
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine("Hubo un error en el procedimiento");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.cerrarConexion();
                comando.Parameters.Clear();
            }
            return vuelo;
        }

        public List<Vuelo> obtenerTodos()
        {
            List<Vuelo> lista = new List<Vuelo>();
            comando.Connection = conexion.abrirConexion();
            try
            {
                comando.CommandText = "MostrarVuelos";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    lista.Add(new Vuelo()
                    {
                        ID = leer.GetInt32(0),
                        Fecha = leer.GetDateTime(1),
                        HSalida = leer.GetTimeSpan(2),
                        HLlegada = leer.GetTimeSpan(3),
                        Origen = ac.obtener(leer.GetInt32(4)),
                        Destino = ac.obtener(leer.GetInt32(5)),
                        Aerolinea = aa.obtener(leer.GetInt32(6)),
                        Estado = leer.GetBoolean(7)
                    });
                }
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine("Ocurrio un error en la consulta");
            }
            finally
            {
                conexion.cerrarConexion();
            }
            return lista;
        }

        public bool removerXAerolinea(Aerolinea aerolinea)
        {
            bool estado = false;
            comando.Connection = conexion.abrirConexion();
            try
            {
                comando.CommandText = "EliminarVueloXAerolinea";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdAerolinea",aerolinea.ID);
                comando.ExecuteNonQuery();
                estado = true;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("El elemento buscado no se encuentra");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Ha ocurrido un error en la consulta");
            }
            finally
            {
                comando.Parameters.Clear();
                conexion.cerrarConexion();
            }
            return estado;
        }

        public bool removerXCiudad(Ciudad ciudad)
        {
            bool estado=false;
            comando.Connection = conexion.abrirConexion();
            try
            {
                comando.CommandText = "EliminarVueloXCiudad";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdCiudad",ciudad.ID);
                comando.ExecuteNonQuery();
                estado = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error en la consulta");
            }
            finally
            {
                conexion.cerrarConexion();
                comando.Parameters.Clear();
            }
            return estado;

        }
    }
}
