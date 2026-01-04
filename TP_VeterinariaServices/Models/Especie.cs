using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_VeterinariaServices.Models
{
    /* 
     id int identity (1,1) primary key,
	especie varchar(50) not null,
	edad_madurez int not null,
	peso_promedio int not null
     */
    public class Especie
    {
        public int id { get; set; }
        public string especie { get; set; }
        public int edad_madurez { get; set; }
        public int peso_promedio { get; set; }

        public Especie(int id, string especie, int edad_madurez, int peso_promedio)
        {
            this.id = id;
            this.especie = especie;
            this.edad_madurez = edad_madurez;
            this.peso_promedio = peso_promedio;
        }

        public Especie()
        {
        }
    }
}
