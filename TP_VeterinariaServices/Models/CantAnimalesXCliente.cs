using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_VeterinariaServices.Models
{
    public class CantAnimalesXCliente
    {
        public string nombre {  get; set; }
        public int cantidad { get; set; }

        public CantAnimalesXCliente(string nombre, int cantidad)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
        }

        public CantAnimalesXCliente()
        {
        }
    }
}
