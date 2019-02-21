using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideYNew
{
    class Program
    {
        static void Main(string[] args)
        {
        Júnior programadorJunior = new Júnior(10,40*4);
        Senior programadorSenior = new Senior(10,40*4,2);
        Console.WriteLine("ProgramadorJunior tienen un sueldo de: " + programadorJunior.CalcularSueldo() + "\n");
        Console.WriteLine("ProgramadorSenior tienen un sueldo de: " + programadorSenior.CalcularSueldo() + "\n");
        }
    }
}
