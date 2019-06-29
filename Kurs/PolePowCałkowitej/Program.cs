using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Zadania
{
    class Program
    {

        public static double PolePowCalkOstroslupa(double podstawa, double wysokość)
        {
            double polePowierzchniCałkowitej = (podstawa * Math.Sqrt(3)) / 4 + (3 * podstawa * wysokość) / 2;

            return polePowierzchniCałkowitej;

        }
        public static void Mainn(string[] args)
        {
            Console.Write("Podaj podstawę i wysokość oddzielone spacją: ");
            string WprowadzonePrzezUżytkownika = Console.ReadLine();
            string[] poSplicie = WprowadzonePrzezUżytkownika.Split(' ');
            double podstawa = Convert.ToDouble(poSplicie[0]);
            double wysokość = Convert.ToDouble(poSplicie[1]);
            if (podstawa < 0 || wysokość < 0)
            {

                Console.WriteLine("Ujemny argument!");
                return;
            }


            double wynikDziałania = PolePowCalkOstroslupa(wysokość, podstawa);
            Console.WriteLine("Pole powierzchni całkowitej wynosi " + wynikDziałania);
            Console.ReadLine();
        }
    }
}