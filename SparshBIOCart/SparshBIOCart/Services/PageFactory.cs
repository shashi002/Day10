using SparshBIOCart.Views;
using System;
using Xamarin.Forms;

namespace SparshBIOCart.Services
{
    public class PageFactory : IPageFactory
    {
        public Page GetPage(Pages page)
        {
            switch (page)
            {
                case Pages.Login: return new LoginPage();
                case Pages.Welcome: return new WelcomePage();
                case Pages.Categories: return new CategoriesListPage();
                case Pages.ProductsListPage:  return new ProductsListPage();
                case Pages.About: return new AboutPage();
                default: throw new ArgumentException(string.Format("Unknown page type {0}", page));
            }
        }
    }
}