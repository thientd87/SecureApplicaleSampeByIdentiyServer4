using System.Collections.Generic;
using System.Security.Claims;
using IdentityModel;
using IdentityServer4.Test;

namespace SecureApplicationExample.IdentityServer4.IdentityConfiguration
{
    public class Users
    {
        public static List<TestUser> Get()
        {
            return new List<TestUser> 
            {
                new TestUser 
                {
                    SubjectId = "56892347",
                    Username = "procoder",
                    Password = "password",
                    Claims = new List<Claim> 
                    {
                        new Claim(JwtClaimTypes.Email, "support@happycodingdotnet.com"),
                        new Claim(JwtClaimTypes.Role, "admin"),
                        new Claim(JwtClaimTypes.WebSite, "https://happycodingdotnet.com")
                    }
                }
            };
        }
    }
}