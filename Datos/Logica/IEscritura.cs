using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Logica
{
    public interface IEscritura<T>
    {
        public abstract bool agregar(T elemento);       //Metodo generico para agregar un elemento en la BD
        public abstract bool editar(T elemento);        //Metodo generico para editar un elemento en la BD
    }
}
