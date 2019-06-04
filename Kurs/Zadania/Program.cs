using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Start:
            
           
            // PROMIEŃ

            for (; ; ) {

             

            Console.Write("Wpisz promień: ");
                double r;
                bool promien = double.TryParse(Console.ReadLine(), out r);

            if (r < 0)
            {
                Console.WriteLine("Ujemny argument!");
                Console.ReadLine();
                Console.Clear();
                goto Start;
                    


                }
            else if (promien == false)
            {
                Console.WriteLine("Wprowadziłeś niewłaściwy znak");
                Console.ReadLine();
                Console.Clear();
                goto Start;
                    

                }

            // TWORZĄCA


            Console.Write("Wpisz tworzącą: ");
                double L;
                bool tworzaca = double.TryParse(Console.ReadLine(), out L);
            if (L < 0)
            {
                Console.WriteLine("Ujemny argument!");
                Console.ReadLine();
                Console.Clear();
                goto Start;
                    

                }
            else if (tworzaca == false)
            {
                Console.WriteLine("Wprowadziłeś niewłaściwy znak");
                Console.ReadLine();
                Console.Clear();
                goto Start;
                    

                }
            if (r > L)
            {
                Console.WriteLine("Obiekt nie istnieje!");
                Console.ReadLine();
                Console.Clear();
                goto Start;
                    

                }


                // WYSOKOŚĆ - OBLICZENIE
                
                double wysokosc = (L * L) - (r * r);
                double H = Math.Sqrt((double)wysokosc);
                

                

                // OBJĘTOŚĆ - OBLICZENIE

                double objetosc;
                objetosc = (1 / 3.0) * Math.PI * r * r * H;

                // WYNIKI - OBLICZENIA

                double gorna = objetosc;
                Math.Ceiling(gorna);
                //gorna = Convert.ToInt32(gorna);
                double dolna = gorna;
                Math.Floor(dolna);
                //dolna = Convert.ToInt32(dolna);

                //WYNIKI

                Console.WriteLine("Dolna granica wynosi objętości wynosi: " + dolna);
                Console.WriteLine("Górna granica wynosi objętości wynosi: " + gorna);
                Console.ReadLine();
                Console.Clear();


            }
        }
       
        
    }

}
