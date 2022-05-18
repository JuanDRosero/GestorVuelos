using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Logica
{
    public interface IRemover<T>
    {
        public abstract bool remover(T elemento);       //Metodo generico para eliminar un elemento de las BD
    }
}
