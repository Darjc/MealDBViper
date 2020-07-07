using System;
using System.Collections.Generic;
using MealDB.Models;

namespace MealDB.MealList.Contracts
{
    public interface IMealListView
    {
        void ShowLoading();
        void HideLoading();
        void ShowMealList(List<Meal> meals);
        void ShowErrorMessage(string message);
        void ShowAlertMessage(string message);
    }
}
