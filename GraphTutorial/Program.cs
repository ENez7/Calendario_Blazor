using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using GraphTutorial.Graph;

namespace GraphTutorial
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://graph.microsoft.com") });

            builder.Services.AddMsalAuthentication<RemoteAuthenticationState, RemoteUserAccount>(options =>
            {
                var scopes = builder.Configuration.GetValue<string>("GraphScopes");
                if (string.IsNullOrEmpty(scopes))
                {
                    Console.WriteLine("WARNING: No permission scopes were found in the GraphScopes app setting. Using default User.Read.");
                    scopes = "User.Read";
                }

                foreach(var scope in scopes.Split(';'))
                {
                    Console.WriteLine($"Adding {scope} to requested permissions");
                    options.ProviderOptions.DefaultAccessTokenScopes.Add(scope);
                }

                builder.Configuration.Bind("AzureAd", options.ProviderOptions.Authentication);
            })
            .AddAccountClaimsPrincipalFactory<RemoteAuthenticationState, RemoteUserAccount, GraphUserAccountFactory>();

            // THIS CODE ABOVES, LOADS THE VALUE OF GraphScopes FROM appsettings.json AND ADDS EACH SCOPE TO THE DEFAULT SCOPES USED BY
            // THE MSAL PROVIDER
            // ALSO, IT REPLACES THE EXISTING ACCOUNT FACTORY WITH THE GraphUserAccountFactory.cs CLASS
            builder.Services.AddScoped<GraphClientFactory>();  // THIS ADDS THE GraphClientFactory AS A SCOPED SERVICE THAT WE CAN MAKE AVAILABLE THROUGH DEP INJECTION
            await builder.Build().RunAsync();
        }
    }
}
