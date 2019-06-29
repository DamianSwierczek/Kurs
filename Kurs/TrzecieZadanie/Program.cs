using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrzecieZadanie
{
    class Program
    {
      public static void Main(string[] args)
        {
            int [,] a = new int[5,4] { { 1, 1, 1, 0 }, { -2, -3, 2, 1}, { -2, -5, 0, -1}, { -3, 4, 6, 2}, { -6, 6, 3, 2} };
           /* double najniższaŚrednia = 0;
            double wielkośćPierwszejKolumny = a.GetLength(1);
            for (int k = 0; k < a.GetLength(1); k++)
            {
                najniższaŚrednia += a[0,k];
            }
            double pierwszaŚrednia = najniższaŚrednia / wielkośćPierwszejKolumny;
            Console.WriteLine(pierwszaŚrednia);*/
            for (int j = 0; j < a.GetLength(0); j++)
            {
                double suma = 0;
                for (int i = 0; i < a.GetLength(1); i++)
                {
                    suma += a[j, i];
                }
                double wielkość = a.GetLength(1);
                double średnia = suma / wielkość;
                int ktoraKolumna = j + 1;
                double[] wyniki = new double[a.GetLength(0)];
                wyniki[j] = średnia;
            }
            
            Console.ReadLine();
        }
    }
}
