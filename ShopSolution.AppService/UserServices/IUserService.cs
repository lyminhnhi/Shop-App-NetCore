using ShopSolution.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShopSolution.AppService.UserServices
{
    public interface IUserService
    {
        Task<string> Authenticate(LoginRequest request);
        Task<bool> Register(RegisterRequest request);
    }
}
