using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideYNew
{
    public class Senior : Programador
    {
        int multiplicador;

        public Senior(int eurosPorHora, int horas, int multiplicador) : base(eurosPorHora, horas)
        {
            this.multiplicador = multiplicador;
        }
        public override int CalcularSueldo() 
        {
            return eurosPorHora * multiplicador * horas;
        }
    }
}
