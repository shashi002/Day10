
using SparshBIOCart.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SparshBIOCart.Services
{
    public interface IUserLoader
    {
        Task<User> getUserDetails(RequestParams param);
    }
}