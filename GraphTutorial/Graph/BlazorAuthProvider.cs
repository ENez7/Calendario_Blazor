using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication.Internal;
using Microsoft.Graph;
// THIS CODE IMPLEMENTS AN AUTHENTICATION PROVIDER FOR MICORSOFT GRAPH SDK THAT USES THE IAccessTokenProviderAccessor PROVIDED BY THE
// Microsoft.AspNetCore.Components.WebAssembly.Authentication PACKAGE TO GET ACCESS TOKENS
namespace GraphTutorial.Graph
{
    public class BlazorAuthProvider : IAuthenticationProvider
    {
        private readonly IAccessTokenProviderAccessor accessor;

        public BlazorAuthProvider(IAccessTokenProviderAccessor accessor)
        {
            this.accessor = accessor;
        }

        // Function called every time the GraphServiceClient makes a call
        public async Task AuthenticateRequestAsync(HttpRequestMessage request)
        {
            // Request the token from the accessor
            var result = await accessor.TokenProvider.RequestAccessToken();

            if (result.TryGetToken(out var token))
            {
                // Add the token to the Authorization header
                request.Headers.Authorization =
                    new AuthenticationHeaderValue("Bearer", token.Value);
            }
        }
    }
}