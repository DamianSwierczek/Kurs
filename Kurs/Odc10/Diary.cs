using System;
using System.Collections.Generic;
using System.Linq;

namespace Odc10
{
    class Diary
    {
        public Diary()
        {
            ratings = new List<float>();
        }
        // Stan (zmienne czyli pola)
        List<float> ratings;




        // Zachowania

        /// <summary>
        /// Dodawanie oceny
        /// </summary>
        /// <param name="rating"></param>
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }
        /// <summary>
        /// Obliczamy średnią naszych ocen
        /// </summary>
        /// <returns></returns>
        public float CalculateAverage()
        {
            float sum = 0, avg = 0;
            foreach (var rating in ratings)
            {
                sum += rating;
            }
            avg = sum / ratings.Count();

            return avg;

        }
        /// <summary>
        /// Pobiera najwyższą ocenę
        /// </summary>
        /// <returns></returns>
        public float GiveMaxRating()
        {
            return ratings.Max();
        }

        /// <summary>
        /// Pobiera najniższą ocenę
        /// </summary>
        /// <returns></returns>
        public float GiveMinRating()
        {
            return ratings.Min();
        }
    }

}
