using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    class Platillos
    {
        public string Nombre { get; set; }
        public string Identifador { get; set; }
        public string Descripcion { get; set; }
        public int _precio;
        public List<Ingredientes> Ingredientes;

        public int Precio
        {
            get
            {
                return _precio;
            }
            set
            {
                if(value>=50)
                {
                    _precio = value;
                }
                else
                {
                    throw new Exception("No es mayor de 50");
                }
            }
        }
        public Platillos()
        {
            Nombre = "No Asignado";
            Identifador = "No Asignado";
            Descripcion = "No Asignado";
            Ingredientes = new List<Ingredientes>();
        }
        public Platillos(string nombre)
        {
            Nombre = nombre;
            Identifador = "No Asignado";
            Descripcion = "No Asignado";
            Ingredientes = new List<Ingredientes>();

        }


    }
}
