using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MealDB.Models;

namespace MealDB.MealList.Contracts
{
    public interface IMealListInteractor
    {
        Task<List<Meal>> SearchMeals(string query);
        
    }
}
