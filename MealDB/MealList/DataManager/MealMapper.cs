using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using MealDB.Api.Models.Response;
using MealDB.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MealDB.MealList.DataManager
{
    public static class MealMapper
    {
        
        public static List<Meal> Map(MealListResponse responseList)
        {
            var mealList = new List<Meal>();
            foreach(MealResponse response in responseList.meals)
            {
                var meal = new Models.Meal();
                meal.id = Int32.Parse(response.idMeal);
                meal.name = response.strMeal;
                meal.category = response.strCategory;
                meal.pictureUrl = response.strMealThumb;
                meal.youtubeUrl = response.strYoutube;
                 meal.ingridents = MapIngridients(response);
                mealList.Add(meal);

            }

            return mealList;
        }

        private static List<Ingridient> MapIngridients(MealResponse meal)
        {
            int i = 0;
            int j = 0;
            List<Ingridient> ingridients = new List<Ingridient>();
            
            foreach (PropertyInfo propertyInfo in meal.GetType().GetProperties())
            {
                string name = "strIngredient" + (i + 1);
                string nameb = "strMeasure" + (j + 1);
                string value = string.Empty;

                if (propertyInfo == null)
                    continue;


                value = propertyInfo.GetValue(meal) as string;

                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) 
                {
                    continue;
                }

                if (propertyInfo.Name.Equals(name))
                {
                    ingridients.Add(new Ingridient() { name = value,
                });
                    i++;
                }

                if (propertyInfo.Name.Equals(nameb) && i > 0)
                {
                    int position = j;


                    try
                    {

                        ingridients[position].mesure = value;
                        j++;
                    }
                    catch (Exception e)
                    {
                        Console.Write("HOLA" + position);
                    }

                }
            }

            return ingridients;
        }
    }
}
