
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MealDB.MealList.Contracts;

using MealDB.Models;

namespace MealDB.Droid.MealList
{
    [Activity(Label = "MealListActivity")]
    public class MealListActivity : Activity, IMealListView
    {

        TextView text_meal;
        IMealListPresenter presenter;
        List<Meal> meals { get; set; }

        public void HideLoading()
        {
            throw new NotImplementedException();
        }

        public void ShowAlertMessage(string message)
        {
            throw new NotImplementedException();
        }

        public void ShowErrorMessage(string message)
        {
            throw new NotImplementedException();
        }

        public void ShowLoading()
        {
            throw new NotImplementedException();
        }

        public void ShowMealList(List<Meal> meals)
        {
            this.meals = meals;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_meal_list);
            text_meal = FindViewById<TextView>(Resource.Id.text_meal);
            presenter = MealApp.Resolve<IMealListPresenter>();
            presenter.ViewDidLoad(this);
            presenter.SearchMeals("a");
            text_meal.Click += Text_meal_Click;

            // Create your application here
        }

        private void Text_meal_Click(object sender, EventArgs e)
        {
            this.meals = meals.OrderBy(x => Guid.NewGuid()).ToList();

            text_meal.Text = this.meals[0].name;
        }
    }
}
