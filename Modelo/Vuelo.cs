using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Vuelo
    {
        public int ID { get; set; }
        public Ciudad Origen { get; set; }
        public Ciudad Destino { get; set; }
        public DateTime Fecha { get; set; }
        [Display(Name = "Hora Salida")]
        public TimeSpan HSalida { get; set; }
        [Display(Name = "Hora Llegada")]
        public TimeSpan HLlegada { get; set; }
        public Aerolinea Aerolinea { get; set; }
        public bool Estado { get; set; }    //True=1=Activo ; False=0=No Activo

    }
}
