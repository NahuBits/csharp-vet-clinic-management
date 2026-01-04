using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_VeterinariaServices.Models
{
    public class Animal
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public decimal peso { get; set; }
        public int edad { get; set; }
        public string especie { get; set; }
        public int Especie_ID { get; set; }
        public int Cliente_ID { get; set; }

        public Animal(int id, string nombre, decimal peso, int edad, string especies,int especie_ID, int cliente_ID)
        {
            this.id = id;
            this.nombre = nombre;
            this.peso = peso;
            this.edad = edad;
            this.especie = especie;
            Especie_ID = Especie_ID;
            Cliente_ID = cliente_ID;
        }

        public Animal()
        {
         
        }
    }
}
