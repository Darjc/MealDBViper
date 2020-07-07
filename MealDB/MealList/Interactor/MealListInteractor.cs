using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MealDB.MealList.Contracts;
using MealDB.Models;

namespace MealDB.MealList.Interactor
{
    public class MealListInteractor : IMealListInteractor
    {

        IMealListRemoteDataManager remoteDataManager;

        public MealListInteractor(IMealListRemoteDataManager remoteDataManager)
        {
            this.remoteDataManager = remoteDataManager;
        }

        public async Task<List<Meal>> SearchMeals(string query)
        {
            var meals = await remoteDataManager.SearchMeals(query);
            return meals;
        }

     

    }
}
