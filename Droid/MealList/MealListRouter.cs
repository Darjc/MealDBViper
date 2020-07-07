using System;
using Android.Content;
using MealDB.MealList.Contracts;
using MealDB.Models;

namespace MealDB.Droid.MealList
{
    public class MealListRouter : IMealListRouter
    {
        public MealListRouter()
        {
        }

        public void StartMealDetail(Meal meal)
        {
            throw new NotImplementedException();
        }

        public void StartMealList()
        {
            
        }

        public static void StartMealList(Context context, Type className)
        {
            

            Intent intent = new Intent(context, className);
            context.StartActivity(intent);

        }
    }
}
