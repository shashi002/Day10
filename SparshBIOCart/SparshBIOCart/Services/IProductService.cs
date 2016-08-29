
using SparshBIOCart.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SparshBIOCart.Services
{
    public interface IProductService
    {
        Task<List<Category>> GetCategories();

        Task<List<Product>> GetProducts();

        Task<List<Product>> GetProductsForCategory(string category);

        Task<List<Product>> Search(string searchString);
    }
}