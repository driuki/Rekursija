using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Saka
    {

        List<Saka> sakos = new List<Saka>();

        public Saka()
        {

        }

        // Sukuriama šaka ir įdedama į sakos Listą pagal tai kokį skaičių įvedė vartotojas
        public void AddIntoList(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                sakos.Add(new Saka());
            }
        }

        // Įvedami duomenys ir patikrinami ar jie teisingi
        public int DataEntry()
        {
            int treeSizeValue;

            Console.WriteLine("Irasykite saku kieki: ");
            string treeSizeString = Console.ReadLine();
            bool succes = Int32.TryParse(treeSizeString, out treeSizeValue);

            if (succes)
            {
                return treeSizeValue;
            }
            else
            {
                Console.WriteLine("Kažkas nepavyko programoje. Arba įvedėte tekstą arba skaičių su liekana.");
                Console.WriteLine("Kitą kartą prašome vesti tik sveikus skaičius");
                return DataEntry();
            }
        }

        // Rekursijos būdu randamas giliausios šakos skaičius
        public int Rekursija(int value)
        {

            int maxValue;

            if (sakos.Count == value)
            {
                maxValue = value;
                return maxValue;
            }

            return Rekursija(value + 1);

        }

    }
}
