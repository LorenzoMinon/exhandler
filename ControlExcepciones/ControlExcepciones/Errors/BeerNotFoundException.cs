using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlExcepciones.Errors
{
    public class BeerNotFoundException : Exception //tengo que heredar de exception
    {
        //Tres constructores uno sin nada, otro con message y otro con message interno. 
        public BeerNotFoundException() : base() { }
        public BeerNotFoundException(string message) : base(message) { }
        public BeerNotFoundException(string message, Exception inner) : base(message, inner) { }
    }
}
