/*
 * Clase que define todos los metodos que puede usar un usuario sin permisos
 */
using Datos.Logica;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Lectura
    {
        private readonly ILectura<Ciudad> ciudades;
        private readonly ILectura<Aerolinea> aerolineas;
        private readonly ILectura<Vuelo> vuelos;
        private readonly AccionesAdmin admin;
        public Lectura()
        {
            ciudades = new AccionesCiudad();
            aerolineas = new AccionesAerolinea();
            vuelos= new AccionesVuelo();
            admin= new AccionesAdmin();
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
        public bool Ingresar(int cedula, string password)
        {
            return admin.Validar(cedula, password);
        }
    }
}
