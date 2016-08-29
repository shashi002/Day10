using SparshBIOCart.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SparshBIOCart.Services
{
    public interface IAppNavigation
    {
        Task LoggedIn(bool result);

        Task ShowAbout();

        Task ShowLogin();

        Task ShowProduct(Product product);

        Task ShowProductList(List<Product> items, string title, bool canShowSinglePage = false);
    }
}