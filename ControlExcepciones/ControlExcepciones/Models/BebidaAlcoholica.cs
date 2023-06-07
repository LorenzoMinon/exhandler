using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlExcepciones.Models
{
    interface IBebidaAlcoholica
    {
        public int Alcohol { get; set; }

        public string Marca { get; set; }

        public void MaxRecomendado();
    }
}
