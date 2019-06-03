using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
             diary.AddRating(5);
             diary.AddRating(8.5f);
             diary.AddRating(4.7f);
             diary.AddRating(1.2f);
             diary.AddRating(3.5f);

            DiaryStatistics stats = diary.ComputeStatistics();

            Console.WriteLine("Srednia ocena: " + stats.AverageGrade);
            Console.WriteLine("Maksymalna ocena: " + stats.MaxGrade);
            Console.WriteLine("Minimalna ocena: " + stats.MinGrade);

            Diary diary2 = new Diary();

            diary2.AddRating(5);
            diary2.AddRating(2);
            diary2.AddRating(6);
            diary2.AddRating(8);
            diary2.AddRating(9);

            stats = diary2.ComputeStatistics();

            Console.WriteLine("Srednia ocena: " + stats.AverageGrade);
            Console.WriteLine("Maksymalna ocena: " + stats.MaxGrade);
            Console.WriteLine("Minimalna ocena: " + stats.MinGrade);

            Console.ReadLine();

           
        }
        
    }

}
