using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MealDB.MealList.Contracts;
using MealDB.Models;

namespace MealDB.MealList.DataManager.Local
{
    public class MealListLocalDataManager : IMealListLocalDataManager
    {
        public Task<bool> DeleteMeal(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Meal>> GetSavedMeals()
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveMeal(Meal meal)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateMeal(Meal meal)
        {
            throw new NotImplementedException();
        }
    }
}
