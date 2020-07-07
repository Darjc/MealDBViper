using System;
using System.Collections.Generic;

namespace MealDB.Models
{
    public class Meal
    {
        public int id { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public string pictureUrl { get; set; }
        public string youtubeUrl { get; set; }
        public List<Ingridient> ingridents { get; set; }

        public Meal()
        {
        }
    }
}
