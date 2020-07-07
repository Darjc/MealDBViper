using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MealDB.MealList.Contracts;
using MealDB.Models;

namespace MealDB.MealList.Presenter
{
    public class MealListPresenter : IMealListPresenter
    {
        IMealListRouter router;
        IMealListInteractor interactor;
        IMealListView view;

        public MealListPresenter(IMealListRouter router,
            IMealListInteractor interactor)
        {
            this.router = router;
            this.interactor = interactor;
        }

        public async Task SearchMeals(string query)
        {

            try
            {
                var meals = await interactor.SearchMeals("a");
                view.ShowMealList(meals);

            }
            catch (Exception e)
            {
                view.ShowErrorMessage(e.Message);
            }
            await Task.Delay(30);
            
            
        }

        public void showMealDetails(Meal meal)
        {
            router.StartMealDetail(meal);
        }
      
     
        public void ViewDidLoad(IMealListView view)
        {
            this.view = view;
        }

        
    }
}
