﻿using Autofac;
using SparshBIOCart.Commands;
using SparshBIOCart.Services;
using SparshBIOCart.ViewModels;
using Xamarin.Forms;

namespace SparshBIOCart
{
    public class AppSetup
    {
        /// <summary>
        /// Creates an instance of the AutoFac container
        /// </summary>
        /// <returns>A new instance of the AutoFac container</returns>
        /// <remarks>
        /// https://github.com/autofac/Autofac/wiki
        /// </remarks>
        public IContainer CreateContainer()
        {
            ContainerBuilder cb = new ContainerBuilder();

            RegisterDepenencies(cb);

            return cb.Build();
        }

        protected virtual void RegisterDepenencies(ContainerBuilder cb)
        {
            // Services
            cb.RegisterType<LoginService>().As<ILoginService>().SingleInstance();
            cb.RegisterType<ProductLoader>().As<IProductLoader>().SingleInstance();
            cb.RegisterType<ProductService>().As<IProductService>().SingleInstance();
            cb.RegisterType<NavigationService>().As<INavigationService>().SingleInstance();
            cb.RegisterType<DefaultThemer>().As<IThemer>().SingleInstance();
            cb.RegisterType<AppNavigation>().As<IAppNavigation>().SingleInstance();
            cb.RegisterType<PageFactory>().As<IPageFactory>().SingleInstance();
            cb.RegisterType<Cache>().As<ICache>().SingleInstance();
            //cb.RegisterType<MockCache>().As<ICache>().SingleInstance();

            // Commands
            cb.RegisterType<LogOutCommand>().As<LogOutCommand>().SingleInstance();

            // View Models
            cb.RegisterType<CategoriesListViewModel>().SingleInstance();
            cb.RegisterType<LoginViewModel>().SingleInstance();
            cb.RegisterType<ProductsListViewModel>().SingleInstance();
            cb.RegisterType<ProductViewModel>().SingleInstance();
            cb.RegisterType<WelcomeViewModel>().SingleInstance();
            cb.RegisterType<AboutViewModel>().SingleInstance();
        }
    }
}