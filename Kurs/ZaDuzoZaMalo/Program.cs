using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GraMonolitycznie
{
    public class Program
    {
        //funkcje
        static void rysuj_tablice(string[] gracze, int[] punkty, int liczbaGraczy)
        {
            Console.WriteLine("--------------------");
            for (int i = 0; i < liczbaGraczy; i++)
            {
                Console.WriteLine(punkty[i] + " pkt. | " + gracze[i]);
                Console.WriteLine("--------------------");
            }
        }

        static public void Mainn(string[] args)
        {
            //zmiennne główne
            bool koniecGry = false;
            int rozgrywka = 1;
            int runda = 0;
            int propozycja = 0;
            bool trafiono = false;
            string wejscie;
            int i = 1;//zmienna do pętli

            //zmienne do losowania
            int min, max, wylosowana;
            Random generator = new Random();

            //TUTAJ ZACZYNAMY
            Console.WriteLine("Witaj!");
            Console.WriteLine("Podaj liczbę graczy:");
            wejscie = Console.ReadLine();

            //zmienne gry
            int liczbaGraczy = Convert.ToInt32(wejscie);
            string[] gracze = new string[liczbaGraczy];
            int[] punkty = new int[liczbaGraczy];

            for (i = 0; i < liczbaGraczy; i++)
            {
                Console.WriteLine("Podaj nazwę gracza nr " + (i + 1));
                gracze[i] = Console.ReadLine();
                punkty[i] = 0;
            }

            Console.Clear();
            rysuj_tablice(gracze, punkty, liczbaGraczy);
            Console.WriteLine("Wciśnij dowolny klawisz, aby rozpocząć rozgrywkę,\"q\" aby wyjść");
            wejscie = Console.ReadLine();
            if (wejscie == "q")
                koniecGry = true;

            while (!koniecGry)
            {
                Console.Clear();
                Console.Write("Witajcie, ");
                for (i = 0; i < liczbaGraczy; i++)
                    Console.Write(gracze[i] + ", ");


                Console.WriteLine("wybierz dolną granicę:");
                wejscie = Console.ReadLine();
                min = Convert.ToInt32(wejscie);

                Console.WriteLine("Wybierz górną granicę:");
                wejscie = Console.ReadLine();
                max = Convert.ToInt32(wejscie);

                //Komputer losuje liczbę
                wylosowana = generator.Next(min, max);
                Console.WriteLine("Wylosowałem liczbę od " + min + " do " + max + ". Odgadnijcie ją");

                //reset
                trafiono = false;
                i = liczbaGraczy;


                do
                {
                    i++;
                    if (i > liczbaGraczy)
                    {
                        Console.WriteLine("Wciśnij dowolny klawisz, aby rozpocząć kolejną rundę...");
                        Console.ReadLine();
                        Console.Clear();
                        i = 1;
                        runda++;
                        Console.WriteLine("RUNDA " + runda + "!!! (" + min + "-" + max + ")");

                    }
                    //Krok 2. Człowiek proponuje rozwiązanie
                    Console.Write(gracze[i - 1] + " podaj swoją propozycję : ");
                    string tekst = Console.ReadLine();

                    try
                    {
                        propozycja = Convert.ToInt32(tekst);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Nie podano liczby!");
                        continue;
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Liczba nie mieści się w rejestrze!");
                        continue;
                    }

                    //Krok 3. Komputer ocenia propozycję
                    if (propozycja < wylosowana)
                        Console.WriteLine("za mało");
                    else if (propozycja > wylosowana)
                        Console.WriteLine("za dużo");
                    else
                    {
                        Console.WriteLine("TRAFIONO!!!");
                        trafiono = true;
                    }

                }
                while (!trafiono);//do momentu trafienia

                Console.WriteLine("Koniec gry. Wygrał " + gracze[i - 1] + " w rundzie " + runda + ". GRATULACJE!");
                punkty[i - 1]++;
                Console.WriteLine("Wciśnij dowolny klawisz, aby kontynuować");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Rozegrano " + rozgrywka + " rozgrywek.");
                rysuj_tablice(gracze, punkty, liczbaGraczy);
                rozgrywka++;
                Console.WriteLine("Wciśnij dowolny klawisz, aby rozpocząć " + rozgrywka + " rozgrywkę,\"q\" aby wyjść");
                wejscie = Console.ReadLine();
                if (wejscie == "q")
                    koniecGry = true;
            }
        }
    }
}