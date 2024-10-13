//using Swashbuckle.Swagger;
namespace RafahiaBlazorApp.Services
{
    public class AccountService : IAccountService
    {
        private readonly HttpClient httpClient;

        public AccountService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<UserModelDto> GetUserAsync()
        {
            var response = await httpClient.GetAsync("api/auth");
            var result = await response.Content.ReadFromJsonAsync<UserModelDto>();
            return result;
        }

        public async Task<AuthModel> RegisterAsync(RegisterModel model)
        {
            var response = await httpClient.PostAsJsonAsync("api/auth/register", model);
            var result = await response.Content.ReadFromJsonAsync<AuthModel>();
            return result;
        }

        public async Task<AuthModel> RegisterCustomerAsync(RegisterModel model)
        {
            var response = await httpClient.PostAsJsonAsync("api/auth/registerCustomer", model);
            var result = await response.Content.ReadFromJsonAsync<AuthModel>();
            return result;
        }

        public async Task<AuthModel> GetTokenAsync(TokenRequestModel model)
        {
            var response = await httpClient.PostAsJsonAsync("api/auth/token", model);
            var result = await response.Content.ReadFromJsonAsync<AuthModel>();
            return result;
        }

        public async Task<AuthModel> GetUserinfoAsync(UserInfo model)
        {
            var response = await httpClient.PostAsJsonAsync("api/auth/userinfo", model);
            var result = await response.Content.ReadFromJsonAsync<AuthModel>();
            return result;
        }

        public async Task<string> AddRoleAsync(AddRoleModel model)
        {
            var response = await httpClient.PostAsJsonAsync("api/auth/addRole", model);
            var result = await response.Content.ReadFromJsonAsync<string>();
            return result;
        }

        public async Task<AuthModel> RefreshTokenAsync(string token)
        {
            var response = await httpClient.PostAsJsonAsync("api/auth/refreshToken", token);
            var result = await response.Content.ReadFromJsonAsync<AuthModel>();
            return result;
        }
       

        public Task<bool> RevokeTokenAsync(string token)
        {
            throw new NotImplementedException();
        }

        //public async Task<AuthModel> RefreshTokenstatAsync(RevokeToken token)
        //{
        //    var response = await httpClient.PostAsJsonAsync("api/auth/refreshToken", token);
        //    var result = await response.Content.ReadFromJsonAsync<AuthModel>();
        //    { Name = CustomUserClaims.}
        //    return result;
        //}

        //public async Task<AuthModel> RefreshTokenAsync(string token)
        //{
        //    var response = await httpClient.PostAsJsonAsync("api/auth/refreshToken", token);
        //    var result = await response.Content.ReadFromJsonAsync<string>();
        //    return response;
        //}

        //public async Task<bool> RevokeTokenAsync(string token)
        //{
        //    var response = await httpClient.PostAsJsonAsync("api/auth/revokeToken", token);
        //    var result = await response.Content.ReadFromJsonAsync<string>();
        //    return result;
        //}
        //private void SetRefreshTokenInCookie(string refreshToken, DateTime expires)
        //{
        //    var cookieOptions = new CookieOptions
        //    {
        //        HttpOnly = true,
        //        Expires = expires.ToLocalTime(),
        //        Secure = true,
        //        IsEssential = true,
        //        SameSite = SameSiteMode.None
        //    };

        //    Response.Cookies.Append("refreshToken", refreshToken, cookieOptions);
        //}
    }
}
