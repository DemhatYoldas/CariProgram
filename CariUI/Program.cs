using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace CariUI
{
    internal static class Program
    {
        public static IContainer Container;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Container = Configure();
            Application.Run(new XtraHome(Container.Resolve<IGrubService>(), Container.Resolve<ITurServis>(), Container.Resolve<IUlkeServis>(), Container.Resolve<ISehirServis>()));
        }

        static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<GrubManager>().As<IGrubService>();
            builder.RegisterType<EfGrubDal>().As<IGrubDal>();

            builder.RegisterType<TurManager>().As<ITurServis>();
            builder.RegisterType<EfTurDal>().As<ITurDal>();

            builder.RegisterType<UlkeManager>().As<IUlkeServis>();
            builder.RegisterType<EfUlkeDal>().As<IUlkeDal>();

            builder.RegisterType<SehirManager>().As<ISehirServis>();
            builder.RegisterType<EfSehirDal>().As<ISehirDal>();

            //builder.RegisterType<�lceManager>().As<I�lceServis>();
            //builder.RegisterType<Ef�lceDal>().As<I�lceDal>();

            //builder.RegisterType<BilgilerimManager>().As<IBilgilerimServis>();
            //builder.RegisterType<EfBilgilerimDal>().As<IBilgilerimDal>();

            builder.RegisterType<XtraHome>();
            return builder.Build();
        }
    }
}