using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Logica
{
    public interface IRemoverEspecial
    {
        public abstract bool removerXCiudad(Ciudad ciudad);     //Metodo para remover los vuelos que tengan una ciudad eliminada
        public abstract bool removerXAerolinea(Aerolinea aerolinea);    //Metodo para remover los vuelos que tengan una aerolinea eliminada
    }
}
