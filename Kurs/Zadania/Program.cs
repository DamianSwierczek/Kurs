using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Zadania
{  class Program
    { 
        static void Main(string[] args)
        {
            string WprowadzonePrzezUżytkownika = Console.ReadLine();
            string[] poSplicie = WprowadzonePrzezUżytkownika.Split(' ');
            double promień = Convert.ToDouble(poSplicie[0]);
            double tworząca = Convert.ToDouble(poSplicie[1]);
            if (promień < 0 || tworząca < 0)
            {

                Console.WriteLine("Ujemny argument!");
                return;
            }
            else if (promień > tworząca)
            {
                Console.WriteLine("Obiekt nie istnieje");
                return;
            }
            double wysokosc = (tworząca * tworząca) - (promień * promień);
            double H = Math.Sqrt((double)wysokosc);
            double objetosc;
            objetosc = (1 / 3.0) * Math.PI * promień * promień * H;
            double gora = Math.Ceiling(objetosc);
            double dol = Math.Floor(objetosc);
            Console.WriteLine(dol + " " + gora);
            Console.ReadLine();
        }
    }
}