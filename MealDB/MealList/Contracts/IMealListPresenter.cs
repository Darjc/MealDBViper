using System;
using System.Threading.Tasks;
using MealDB.Models;

namespace MealDB.MealList.Contracts
{
    public interface IMealListPresenter
    {
        void ViewDidLoad(IMealListView view);
        Task SearchMeals(string query);
        void showMealDetails(Meal meal);
    }
}
