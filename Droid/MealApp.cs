using System;
using Android.App;
using Android.Runtime;
using Autofac;
using Autofac.Builder;
using MealDB.Droid.MealList;

namespace MealDB.Droid
{
    [Application]
    public class MealApp : Application
    {

        public static IContainer Container { get; set; }


        public MealApp(IntPtr handle, JniHandleOwnership transer)
          : base(handle, transer)
        {
            //Implement this method
        }
        public override void OnCreate()
        {
            base.OnCreate();
            BuildDependencies(); 
        }

        public static T Resolve<T>()
        {
            return Container.Resolve<T>();
        }


        public void BuildDependencies()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new MealListDroidModule());
            Container = builder.Build(ContainerBuildOptions.None);

        }
    }
}
