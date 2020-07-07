using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MealDB.Models;

namespace MealDB.MealList.Contracts
{
    public interface IMealListLocalDataManager
    {
        Task<bool> UpdateMeal(Meal meal);
        Task<bool> SaveMeal(Meal meal);
        Task<List<Meal>> GetSavedMeals();
        Task<bool> DeleteMeal(int id);
    }
}
