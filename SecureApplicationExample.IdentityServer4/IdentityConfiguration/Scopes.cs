using System.Collections.Generic;
using IdentityServer4.Models;

namespace SecureApplicationExample.IdentityServer4.IdentityConfiguration
{
    public class Scopes
    {
        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new[]
            {
                new ApiScope("weatherApi.read", "Read Access to Weather API"),
                new ApiScope("weatherApi.write", "Write Access to Weather API"),
            };
        }
    }
}