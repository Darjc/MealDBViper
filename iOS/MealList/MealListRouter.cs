using System;
using MealDB.MealList.Contracts;
using MealDB.Models;
using UIKit;
using Foundation;

namespace MealDB.iOS.MealList
{
    public class MealListRouter : IMealListRouter
    {
        public MealListRouter()
        {
        }

        public static UIViewController GetFirstViewController()
        {
            return mealListStoryBoard()
              .InstantiateViewController("MealListView");
        }
        public void StartMealDetail(Meal meal)
        {
            throw new NotImplementedException();
        }

        public void StartMealList()
        {
            
        }

        public static UIStoryboard mealListStoryBoard()
        {
            var story = UIStoryboard.FromName("MealListStoryboard", NSBundle.MainBundle);

            return story;
        }
    }
}
