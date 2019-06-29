using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrzecieZadanie
{
    class Program
    {
            static double KtoraKolumna(int[,] a)
            {
                double[] srednia = new double[5];

                for (int i = 0; i < 5; i++)
                {
                    srednia[i] = 0;
                    for (int j = 0; j < 4; j++)
                    {
                        srednia[i] += a[i, j];
                    }

                    srednia[i] /= 4;
                }
                int nrKolumny = Array.IndexOf(srednia, srednia.Min());
            int kolumna = nrKolumny + 1;

                return kolumna;
            }
            static void Main(string[] args)
            {
                int[,] a = new int[5, 4] { { 1, 1, 1, 0 }, { -2, -3, 2, 1 }, { -12, -50, 0, -1 }, { -3, 4, 6, 2 }, { -6, 6, 3, 4 } };

                Console.WriteLine("numer kolumny z maksymalną sumą = " + KtoraKolumna(a));
            Console.ReadLine();
            }
        }
   
    }

