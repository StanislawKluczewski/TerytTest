using System.IdentityModel.Tokens.Jwt;

namespace Teryt.WebApi.Authentication
{
    public static class UserAuthenticationCheck
    {
        public static bool IsUserAuthenticated(string token)
        {
            if (token == null || token == "" || token == "Bearer")
            {
                return false;
            }
            else
            {
                var handler = new JwtSecurityTokenHandler();
                var decodedToken = handler.ReadJwtToken(token) as JwtSecurityToken;
                var email = decodedToken.Claims.First(c => c.Type == "email").Value;
                var userId = decodedToken.Claims.First(c => c.Type == "userId").Value;
                if (email is null || email is null)
                {
                    return false;
                }
                return true;
            }
        }

        public static string UserRoleCheck(string token)
        {
            if (token == null || token == "" || token == "Bearer")
            {
                return "";
            }
            else
            {
                var handler = new JwtSecurityTokenHandler();
                var decodedToken = handler.ReadJwtToken(token) as JwtSecurityToken;
                var email = decodedToken.Claims.First(c => c.Type == "email").Value;
                
                if (email.Contains("admin"))
                {
                    return "Admin";
                }
                else
                {
                    return "User";
                }
            }
        }
    }
}
