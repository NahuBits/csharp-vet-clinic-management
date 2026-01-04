using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_VeterinariaServices.Models
{
    public class PesoDeEspecies
    {
        public string especie {  get; set; }
        public decimal pesoMin { get; set; }
        public decimal pesoMax { get; set; }
        public decimal pesoAVG { get; set; }

        public PesoDeEspecies(string especie, decimal pesoMin, decimal pesoMax, decimal pesoAVG)
        {
            this.especie = especie;
            this.pesoMin = pesoMin;
            this.pesoMax = pesoMax;
            this.pesoAVG = pesoAVG;
        }

        public PesoDeEspecies()
        {
        }
    }
}
