using Xamarin.Forms;

namespace SparshBIOCart.Services
{
    public enum Pages
    {
        Login,
        Welcome,
        Categories,
        ProductsListPage,
        About,
    }

    public interface IPageFactory
    {
        Page GetPage(Pages page);
    }
}