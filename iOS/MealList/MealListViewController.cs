using System;
using System.Linq;

using System.Collections.Generic;
using MealDB.MealList.Contracts;
using MealDB.Models;
using UIKit;

namespace MealDB.iOS.MealList
{
    public partial class MealListViewController : UIViewController, IMealListView
    {
        IMealListPresenter presenter;

        public MealListViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            presenter = AppDelegate.Resolve<IMealListPresenter>();

            presenter.ViewDidLoad(this);

            btnService.TouchUpInside += BtnService_TouchUpInside;
            presenter.SearchMeals("a");

            // Perform any additional setup after loading the view, typically from a nib.
        }

        private void BtnService_TouchUpInside(object sender, EventArgs e)
        {
            this.meals = meals.OrderBy(x => Guid.NewGuid()).ToList();

            btnService.SetTitle(meals[0].name, UIControlState.Normal);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public void ShowLoading()
        {
          
        }

        public void HideLoading()
        {
        }

        List<Meal> meals { get; set; }

        public void ShowMealList(List<Meal> meals)
        {
            this.meals = meals;
        }

        public void ShowErrorMessage(string message)
        {
            throw new NotImplementedException();
        }

        public void ShowAlertMessage(string message)
        {

        }
    }
}

