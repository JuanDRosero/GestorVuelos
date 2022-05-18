using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Logica
{
    public interface ILectura<T>
    {
        public abstract  List<T> obtenerTodos();    //Metodo generico para obtener todos los elementos
        public abstract T obtener(int id);          //Metodo generico para obtener un elemento
    }
}
