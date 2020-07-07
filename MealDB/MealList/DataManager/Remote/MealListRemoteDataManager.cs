using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MealDB.Api.Models;
using MealDB.MealList.Contracts;
using MealDB.Models;
using Refit;

namespace MealDB.MealList.DataManager.Remote
{
    public class MealListRemoteDataManager: IMealListRemoteDataManager
    {
        string BASE_URL = "https://www.themealdb.com/api/json/v1/1/";

        public MealListRemoteDataManager()
        {
        }


        public async Task<List<Meal>> SearchMeals(string query)
        {
            IMealDBApi api = RestService.For<IMealDBApi>(BASE_URL);
            var response = await api.Search(query);
            return MealMapper.Map(response);
        }
    }
}
