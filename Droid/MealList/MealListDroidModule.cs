using System;
using Autofac;
using MealDB.MealList;
using MealDB.MealList.Contracts;

namespace MealDB.Droid.MealList
{
    public class MealListDroidModule : MealListModule
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MealListRouter>().As<IMealListRouter>();
            base.Load(builder);
        }
    }
}
