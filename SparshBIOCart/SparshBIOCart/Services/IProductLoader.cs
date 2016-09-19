
using SparshBIOCart.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SparshBIOCart.Services
{
    public interface IProductLoader
    {
        Task<List<Product>> LoadProducts();
        Task<string> SparshBIOCart(RequestParams param);
    }
}