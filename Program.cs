using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r;
            double d;
            double a;

            Console.Write("Insira o Diamertro da Circunferência: ");
            d = double.Parse(Console.ReadLine());

            r = d / 2;

           a = Math.PI * Math.Pow(r, 2);

            Console.WriteLine("A Area do circulo é {0}.", a);
        }
    }
}
