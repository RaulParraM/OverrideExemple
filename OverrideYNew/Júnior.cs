using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideYNew
{
    public class Júnior : Programador
    {
        public Júnior(int eurosPorHora, int horas) : base (eurosPorHora, horas)
        {
        }

        public override int CalcularSueldo()
        {
            return eurosPorHora * horas;
        }
    }
}
