using System;
using Autofac;
using MealDB.MealList;
using MealDB.MealList.Contracts;

namespace MealDB.iOS.MealList
{
    public class MealListModuleIOS : MealListModule
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterType<MealListRouter>().As<IMealListRouter>();
        }
    }
}
