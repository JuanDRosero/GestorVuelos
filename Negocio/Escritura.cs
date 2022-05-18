/*
 * Clase que define todos los metodos que puede usar un administrador con permisos
 */
using Datos.Logica;
using Modelo;


namespace Negocio
{
    public class Escritura 
    {
        private readonly AccionesAerolinea aerolineas;
        private readonly AccionesCiudad ciudades;
        private readonly AccionesVuelo vuelos;
        public Escritura()
        {
            aerolineas = new AccionesAerolinea();
            ciudades = new AccionesCiudad();
            vuelos = new AccionesVuelo();
        }
        public List<Ciudad> GetCiudades()
        {
            return ciudades.obtenerTodos();
        }
        public Ciudad GetCiudad(int id)
        {
            return ciudades.obtener(id);
        }
        public List<Aerolinea> GetAerolineas()
        {
            return aerolineas.obtenerTodos();
        }
        public Aerolinea GetAerolinea(int id)
        {
            return aerolineas.obtener(id);
        }
        public List<Vuelo> GetVuelos()
        {
            return vuelos.obtenerTodos();
        }
        public Vuelo GetVuelo(int id)
        {
            return vuelos.obtener(id);
        }
        public bool AddCiudad(Ciudad ciudad)
        {
            return ciudades.agregar(ciudad);
        }
        public bool EditCiudad(Ciudad ciudad)
        {
            return ciudades.editar(ciudad);
        }
        public bool DeleteCiudad(Ciudad ciudad)
        {
            return ciudades.remover(ciudad);
        }
        public bool AddAerolinea(Aerolinea aerolinea)
        {
            return aerolineas.agregar(aerolinea);
        }
        public bool EditAerolinea(Aerolinea aerolinea)
        {
            return aerolineas.editar(aerolinea);
        }
        public bool DeleteAerolinea(Aerolinea aerolinea)
        {
            return aerolineas.remover(aerolinea);
        }
        public bool AddVuelo(Vuelo vuelo)
        {
            return vuelos.agregar(vuelo);
        }
        public bool EditVuelo(Vuelo vuelo)
        {
            return vuelos.editar(vuelo);
        }
    }
}
