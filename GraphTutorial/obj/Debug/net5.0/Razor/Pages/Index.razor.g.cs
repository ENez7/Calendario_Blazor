#pragma checksum "C:\Users\enriq\Desktop\PruebaCalendario\GraphTutorial\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "261c06cfeac85278caa7a2dd3615f3fb263a3352"
// <auto-generated/>
#pragma warning disable 1591
namespace GraphTutorial.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\enriq\Desktop\PruebaCalendario\GraphTutorial\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\enriq\Desktop\PruebaCalendario\GraphTutorial\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\enriq\Desktop\PruebaCalendario\GraphTutorial\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\enriq\Desktop\PruebaCalendario\GraphTutorial\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\enriq\Desktop\PruebaCalendario\GraphTutorial\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\enriq\Desktop\PruebaCalendario\GraphTutorial\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\enriq\Desktop\PruebaCalendario\GraphTutorial\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\enriq\Desktop\PruebaCalendario\GraphTutorial\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\enriq\Desktop\PruebaCalendario\GraphTutorial\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\enriq\Desktop\PruebaCalendario\GraphTutorial\_Imports.razor"
using GraphTutorial;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\enriq\Desktop\PruebaCalendario\GraphTutorial\_Imports.razor"
using GraphTutorial.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "jumbotron");
            __builder.AddMarkupContent(2, "<h1>Blazor Client-side Graph Tutorial</h1>\r\n    ");
            __builder.AddMarkupContent(3, "<p class=\"lead\">This sample app shows how to use the Microsoft Graph API to access a user\'s data from a Blazor client-side app</p>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(4);
            __builder.AddAttribute(5, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(6, "h4");
                __builder2.AddContent(7, "Welcome ");
                __builder2.AddContent(8, 
#nullable restore
#line 8 "C:\Users\enriq\Desktop\PruebaCalendario\GraphTutorial\Pages\Index.razor"
                         context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(9, "!");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(10, "\r\n            ");
                __builder2.AddMarkupContent(11, "<p>Use the navigation bar on the left to get started.</p>");
            }
            ));
            __builder.AddAttribute(12, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(13, "<a class=\"btn btn-primary btn-large\" href=\"authentication/login\">Click here to sign in</a>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591