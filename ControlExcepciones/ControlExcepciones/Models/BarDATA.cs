using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlExcepciones.Models
{
    public class BarDATA
    {
        public string Nombre { get; set; }
        public List<Bebida> bebidas = new List<Bebida>();

        public BarDATA(string Nombre)
        {
            this.Nombre = Nombre;
        }
    }
}
