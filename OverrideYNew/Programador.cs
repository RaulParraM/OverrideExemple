using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideYNew
{
    public abstract class Programador 
    {
        public int eurosPorHora;
        public int horas;

        public Programador(int eurosPorHora, int horas)
        {
            this.eurosPorHora = eurosPorHora;
            this.horas = horas;
        }

        public virtual int CalcularSueldo()
        {
            return eurosPorHora * horas;
        }
    }
}
