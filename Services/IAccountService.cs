namespace RafahiaBlazorApp.Services
{
    public interface IAccountService
    {
        Task<AuthModel> RegisterAsync(RegisterModel model);
        Task<AuthModel> RegisterCustomerAsync(RegisterModel model);
        Task<AuthModel> GetTokenAsync(TokenRequestModel model);
        Task<AuthModel> GetUserinfoAsync(UserInfo model);
        Task<string> AddRoleAsync(AddRoleModel model);
        Task<AuthModel> RefreshTokenAsync(string token);
        //Task<AuthModel> RefreshTokenstatAsync(RevokeToken token);
        Task<bool> RevokeTokenAsync(string token);
    }
}
