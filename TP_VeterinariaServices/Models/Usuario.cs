using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_VeterinariaServices.Models
{
    public class Usuario
    {
        public string usuario{ get; set; }
        public string pass { get; set; }

        public Usuario(string usuario, string pass)
        {
            this.usuario = usuario;
            this.pass = pass;
        }
        public Usuario()
        {
        }
    }
}
