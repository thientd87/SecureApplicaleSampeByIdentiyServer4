using System.Threading.Tasks;
using IdentityModel.Client;

namespace SecureApplicationExample.IdentityServer4.WebApi.Client.Services
{
    public interface IIdentityServer4Service
    {
        Task<TokenResponse> GetToken(string apiScope);
    }
}