

namespace RafahiaBlazorApp.Services
{
    public interface IAuthService
    {
        Task<UserModelDto[]> GetUserAsync();
        Task<AuthModel> RegisterAsync(RegisterModel model);
        Task<AuthModel> RegisterCustomerAsync(RegisterModel model);
        Task<AuthModel> GetTokenAsync(TokenRequestModel model);
        Task<AuthModel> GetUserinfoAsync(UserInfo model);
        Task<string> AddRoleAsync(AddRoleModel model);
        Task<AuthModel> RefreshTokenAsync(string token);
        Task<bool> RevokeTokenAsync(string token);
        Task<JwtSecurityToken> CreateJwtToken(ApplicationUser user);
        //DurationInMinutes
    }
}