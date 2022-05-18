using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Aerolinea
    {
        private string nombre;
        public int ID { get; set; }
        public string Nombre
        {
            get { return nombre.ToUpper(); }
            set { if (!String.IsNullOrEmpty(value)) nombre = value; }
        }
    }
}
