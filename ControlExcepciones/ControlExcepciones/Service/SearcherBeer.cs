using ControlExcepciones.Models;
using ControlExcepciones.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlExcepciones.Service
{
    public class SearcherBeer
    {
        List<Cerveza> cervezas = new List<Cerveza>()
        {
            new Cerveza() {Alcohol=7, Cantidad =10, Nombre="Pale Ale", Marca ="Minerva" },
            new Cerveza() {Alcohol=8, Cantidad =10, Nombre= "Ticús", Marca="Colima" },
            new Cerveza() {Alcohol =9, Cantidad =10, Nombre = "Stout", Marca = "Quilmes"}
        };

        public int GetCantidad(string Nombre)
        {
            var cerveza = (from d in cervezas
                           where d.Nombre == Nombre
                           select d).FirstOrDefault();
            //throw new FileNotFoundException("Hola, no me agarraste.");
            if (cerveza == null)
                throw new BeerNotFoundException("La cerveza se ha terminado");

            
            return cerveza.Cantidad;
        } 

    }
}
