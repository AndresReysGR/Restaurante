using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    class Ingredientes
    {
        public string Nombre { get; set; }
        public string Identificador { get; set; }

        public Ingredientes ()
        {
            Nombre = "No Asignado";
            Identificador = "No Asignado";
        }
        public Ingredientes(string nombre, string identificador)
        {
            Nombre = nombre;
            Identificador = identificador;
        }

    }
}
