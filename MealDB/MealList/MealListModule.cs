using System;
using Autofac;
using MealDB.MealList.Contracts;
using MealDB.MealList.DataManager;
using MealDB.MealList.DataManager.Remote;
using MealDB.MealList.Interactor;
using MealDB.MealList.Presenter;

namespace MealDB.MealList
{
    public class MealListModule : Module
    {

        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<MealListRemoteDataManager>().As<IMealListRemoteDataManager>();
            builder.RegisterType<MealListInteractor>().As<IMealListInteractor>();
            builder.RegisterType<MealListPresenter>().As<IMealListPresenter>();
            // The router implementations are in the Android and IOS Projects
            // The View implementations are in the Android and IOS Projects



        }
    }
}
