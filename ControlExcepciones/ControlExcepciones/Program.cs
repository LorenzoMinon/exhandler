using ControlExcepciones.Models;
using ControlExcepciones.Service;
using System.ComponentModel;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;
using System.Linq;
using ControlExcepciones.Errors;

namespace ControlExcepciones
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var searcherBeer = new SearcherBeer();
                var cantidad = searcherBeer.GetCantidad("Stasdout");
                Console.WriteLine("Todo bien");

            }
            catch(FieldAccessException ex)
            {
                Console.WriteLine("Agarramos la excepción");
            }

            catch(InvalidOperationException ex)
            {
                Console.WriteLine("Ha caido en una operación invalida.");
            }

            catch(BeerNotFoundException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Una excepción inesperada");
                //Generica.
            }
            finally
            {
                Console.WriteLine("Cerramos recursos, cae siempre y se ejecuta");
            }


        }
    }
}