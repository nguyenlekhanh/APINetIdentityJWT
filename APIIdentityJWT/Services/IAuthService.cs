using APIIdentityJWT.Models;

namespace APIIdentityJWT.Services
{
    public interface IAuthService
    {
        Task<bool> Login(LoginUser user);
        Task<bool> RegisterUser(LoginUser user);
    }
}