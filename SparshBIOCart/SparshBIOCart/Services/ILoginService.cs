using SparshBIOCart.Models;
using System.Threading.Tasks;

namespace SparshBIOCart.Services
{
    public interface ILoginService
    {
        Task<bool> IsLoggedIn();

        Task<User> LoginAsync(string username, string password);

        Task LogOutAsync();
    }
}