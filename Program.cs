using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Saka saka = new Saka();

            // Vartotojas iveda skaiciu 
            int ivestiDuomenys = saka.DataEntry();

            // Įkeliama į Listą tiek objektų pagal kokį skaičių įveda naudotojas 
            saka.AddIntoList(ivestiDuomenys);

            // Vykdoma rekursija ir gražinamas skaičius giliausios šakos skaičius 
            int sakuKiekis = saka.Rekursija(0);

            Console.WriteLine("Saku kiekis {0}", sakuKiekis);

            Console.WriteLine("Spauskite Enter, kad paliktumete programa.");
            Console.ReadLine();
        }
    }
}
