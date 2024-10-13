//using Microsoft.AspNetCore.Components.Authorization;
//using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
//using Microsoft.VisualBasic;
//using System.Security.Claims;

//namespace RafahiaBlazorApp.States
//{
//    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
//    {
//        //private readonly ProtectedSessionStorage _sessionStorage;
//        //private ClaimsPrincipal _anonymous = new ClaimsPrincipal(new ClaimsIdentity());
//        private readonly ClaimsPrincipal anonymous = new ClaimsPrincipal(new ClaimsIdentity());

//        //public CustomAuthenticationStateProvider(ProtectedSessionStorage sessionStorage)
//        //{
//        //    _sessionStorage = sessionStorage;
//        //}

//        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
//        {
//            //try
//            //{
//            //    var usersessionstorage = await _sessionStorage.GetAsync<CustomUserClaims>("CustomUserClaims");
//            //    var userSession = usersessionstorage.Success ? usersessionstorage.Value : null;
//            //    if (userSession == null)
//            //        return await Task.FromResult(new AuthenticationState(_anonymous));
//            //    var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
//            //{
//            //    new Claim(ClaimTypes.Name,userSession.UserName),
//            //    new Claim(ClaimTypes.Email,userSession.Email)
//            //}, "JwtAuth"));
//            //    return await Task.FromResult(new AuthenticationState(_anonymous));
//            //}
//            //catch
//            //{
//            //    return await Task.FromResult(new AuthenticationState(_anonymous));
//            //}


//            //var authmodel = new AuthModel();
//            try
//            {
//                if (string.IsNullOrEmpty(Constans.Token))
//                    return await Task.FromResult(new AuthenticationState(anonymous));

//                var getUserClaims = DecryptToken(Constans.Token);
//                if (getUserClaims == null)
//                    return await Task.FromResult(new AuthenticationState(anonymous));
//                var claimsPrincipal = SetClaimPrincipal(getUserClaims);

//                return await Task.FromResult(new AuthenticationState(claimsPrincipal));
//            }
//            catch { return await Task.FromResult(new AuthenticationState(anonymous)); }
//        }

//        public async void UpdateAuthState(string Token)
//        {
//            var claimsPrincipal = new ClaimsPrincipal();
//            if (!string.IsNullOrEmpty(Token))
//            {
//                Constans.Token = Token;
//                var getUserClaims = DecryptToken(Token);
//                claimsPrincipal = SetClaimPrincipal(getUserClaims);
//            }
//            else
//            {
//                Constans.Token = null!;
//            }
//            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(claimsPrincipal)));
//        }
//        /////////////////////////////////////////////////////////////////

//        public static ClaimsPrincipal SetClaimPrincipal(CustomUserClaims claims)
//        {
//            //var authmodel = new AuthModel();
//            if (claims.Email is null) return new ClaimsPrincipal();
//            return new ClaimsPrincipal(new ClaimsIdentity(
//                new List<Claim>
//                {
//                       new Claim(ClaimTypes.Name,claims.UserName),
//                        new Claim(ClaimTypes.Email,claims.Email)
//                }, "Token"));
//        }

//        //    public async void UpdateAuthenticationState(string jwtToken)
//        //    {
//        //        var authModel = new AuthModel();
//        //        var claimsprincipal = new ClaimsPrincipal();
//        //        if (!string.IsNullOrEmpty(jwtToken))
//        //        {
//        //            //Constans.JWTToken = ;
//        //            Constans.JWTToken = authModel.Token;
//        //            var getUserClaims = DecryptToken(jwtToken);
//        //            claimsprincipal = SetClaimPrincipal(getUserClaims);
//        //        }
//        //    }
//        private static CustomUserClaims DecryptToken(string Token)
//        {
//            //var authModel = new AuthModel();
//            if (string.IsNullOrEmpty(Token)) return new CustomUserClaims();

//            var handler = new JwtSecurityTokenHandler();
//            var tttoken = handler.ReadJwtToken(Token);
//            var token = new JwtSecurityTokenHandler().WriteToken(tttoken);

//            var name = token.Claims.FirstOrDefault(_ => _.Type == ClaimTypes.Name);
//            var email = token.Claims.FirstOrDefault(_ => _.Type == ClaimTypes.Email);
//            return new CustomUserClaims(name!.Value, email!.Value);
//        }

//        /////////////////////////////
//        //public async Task UpdateAuthState(CustomUserClaims customUserClaims)
//        //{
//        //    ClaimsPrincipal claimsPrincipal;
//        //    if (customUserClaims != null)
//        //    {
//        //        await _sessionStorage.SetAsync("CustomUserClaims", customUserClaims);
//        //        claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
//        //            {
//        //                new Claim(ClaimTypes.Name,customUserClaims.UserName),
//        //                new Claim(ClaimTypes.Email,customUserClaims.Email)
//        //            }));
//        //    }
//        //    else
//        //    {
//        //        await _sessionStorage.DeleteAsync("CustomUserClaims");
//        //        claimsPrincipal = _anonymous;
//        //    }
//        //    NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(claimsPrincipal)));
//        //}

//    }
//}
