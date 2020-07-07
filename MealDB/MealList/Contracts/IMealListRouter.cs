using System;
using MealDB.Models;

namespace MealDB.MealList.Contracts
{
    public interface IMealListRouter
    {
        void StartMealList();
        void StartMealDetail(Meal meal);
    }
}
