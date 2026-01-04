using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_VeterinariaServices.Models
{
    public class Cliente
    {
        public int id { get; set; }
        public string nombre_cliente { get; set; }
        public string dni { get; set; }

        public Cliente(int id, string nombre_cliente, string dni)
        {
            this.id = id;
            this.nombre_cliente = nombre_cliente;
            this.dni = dni;
        }
        public Cliente()
        {
        }
    }
}
