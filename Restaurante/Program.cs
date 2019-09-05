using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    class Program
    {
        static void Main(string[] args)
        {
            Platillos cliente = new Platillos();

            try
            {
                cliente.Precio = 100;
                Console.WriteLine("Precio: " + cliente.Precio);

            }
            catch
            {
                Console.WriteLine("Debes tener mas de 50 pesos");
            }

            List<Platillos> platillos = new List<Platillos>();

            Platillos Quesadillas = new Platillos("Quesadillas");
            Quesadillas.Identificador = "\tBueno";
            Quesadillas.Descripcion = "\tTortillas con queso";

            Platillos Tacos = new Platillos("Tacos");
            Tacos.Identificador = "\tBueno";
            Tacos.Descripcion = "\tTortilla y carne";

            platillos.Add(Quesadillas);
            platillos.Add(Tacos);

            Ingredientes Jamon = new Ingredientes("\tJamon", "\tCaliente");
            Ingredientes Queso = new Ingredientes("\tQueso", "\tDerretido");
            Ingredientes Tortilla = new Ingredientes("\tTortilla", "\tCaliente");

            Ingredientes Carne = new Ingredientes("\tCarne", "Cocida");
            Ingredientes Tortilla1 = new Ingredientes("\tTorilla", "Tostada");

            Quesadillas.Ingredientes.Add(Jamon);
            Quesadillas.Ingredientes.Add(Queso);
            Quesadillas.Ingredientes.Add(Tortilla);

            Tacos.Ingredientes.Add(Carne);
            Tacos.Ingredientes.Add(Tortilla1);

            foreach(Platillos platillo in platillos)
            {
                Console.WriteLine("\n\tPlatillo: " + platillo.Nombre);
                Console.WriteLine("\tLista de Ingredientes: ");
                Console.WriteLine("\tIdentificador: " + platillo.Identificador);
                Console.WriteLine("\tDescripcion: " + platillo.Descripcion);

                foreach(Ingredientes ingrediente in platillo.Ingredientes)
                {
                    Console.WriteLine("-" + "\tNombre: " + ingrediente.Nombre);
                    Console.WriteLine("*" + "\tIdentificador: " + platillo.Identificador);

                }
            }


            Console.Read();
        }
    }
}
