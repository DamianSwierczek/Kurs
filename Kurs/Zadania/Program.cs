﻿using System;
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
                Console.WriteLine("Wciśnij dowolny klawisz, aby rozpocząć jeszcze raz");
                Console.ReadKey();
                Console.Clear();
                goto Start;
                    


                }
            else if (promien == false)
            {
                Console.WriteLine("Wprowadziłeś niewłaściwy znak");
                Console.WriteLine("Wciśnij dowolny klawisz, aby rozpocząć jeszcze raz");
                Console.ReadKey();
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
                Console.WriteLine("Wciśnij dowolny klawisz, aby rozpocząć jeszcze raz");
                Console.ReadKey();
                Console.Clear();
                goto Start;
                    

                }
            else if (tworzaca == false)
            {
                Console.WriteLine("Wprowadziłeś niewłaściwy znak");
                Console.WriteLine("Wciśnij dowolny klawisz, aby rozpocząć jeszcze raz");
                Console.ReadKey();
                Console.Clear();
                goto Start;
                    

                }
            if (r >= L)
            {
                Console.WriteLine("Obiekt nie istnieje!");
                Console.WriteLine("Wciśnij dowolny klawisz, aby rozpocząć jeszcze raz");
                Console.ReadKey();
                Console.Clear();
                goto Start;
                    

                }


                // WYSOKOŚĆ - OBLICZENIE
                
                double wysokosc = (L * L) - (r * r);
                double H = Math.Sqrt((double)wysokosc);
                

                

                // OBJĘTOŚĆ - OBLICZENIE

                double objetosc;
                objetosc = (1 / 3.0) * Math.PI * r * r * H;

                // WYNIKI

                double gorna = objetosc;
                gorna = Convert.ToInt32(gorna);
                double dolna = gorna - 1;
                dolna = Convert.ToInt32(dolna);

                Console.WriteLine("Dolna granica wynosi objętości wynosi: " + dolna);
                Console.WriteLine("Górna granica wynosi objętości wynosi: " + gorna);
                Console.WriteLine("Wciśnij dowolny klawisz, aby rozpocząć jeszcze raz");
                Console.ReadKey();
                Console.Clear();


            }
        }
       
        
    }

}