#pragma checksum "C:\Users\enriq\Desktop\PruebaCalendario\GraphTutorial\Pages\Calendar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25d593f16568805a5a1e4ee5e0b660f0f583e46c"
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
#nullable restore
#line 2 "C:\Users\enriq\Desktop\PruebaCalendario\GraphTutorial\Pages\Calendar.razor"
using Microsoft.Graph;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\enriq\Desktop\PruebaCalendario\GraphTutorial\Pages\Calendar.razor"
using TimeZoneConverter;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/calendar")]
    public partial class Calendar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "<h1 class=\"mb-3\">Calendar</h1>\r\n        ");
                __builder2.AddMarkupContent(3, "<a href=\"/newevent\" class=\"btn btn-light btn-sm mb-3\">New event</a>\r\n        ");
                __builder2.OpenElement(4, "table");
                __builder2.AddAttribute(5, "class", "table");
                __builder2.AddMarkupContent(6, "<thead><tr><th>Organizer</th>\r\n                    <th>Subject</th>\r\n                    <th>Start</th>\r\n                    <th>End</th></tr></thead>\r\n            ");
                __builder2.OpenElement(7, "tbody");
#nullable restore
#line 21 "C:\Users\enriq\Desktop\PruebaCalendario\GraphTutorial\Pages\Calendar.razor"
                 foreach(var calendarEvent in events)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(8, "tr");
                __builder2.OpenElement(9, "td");
                __builder2.AddContent(10, 
#nullable restore
#line 24 "C:\Users\enriq\Desktop\PruebaCalendario\GraphTutorial\Pages\Calendar.razor"
                             calendarEvent.Organizer.EmailAddress.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, "\r\n                        ");
                __builder2.OpenElement(12, "td");
                __builder2.AddContent(13, 
#nullable restore
#line 25 "C:\Users\enriq\Desktop\PruebaCalendario\GraphTutorial\Pages\Calendar.razor"
                             calendarEvent.Subject

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n                        ");
                __builder2.OpenElement(15, "td");
                __builder2.AddContent(16, 
#nullable restore
#line 26 "C:\Users\enriq\Desktop\PruebaCalendario\GraphTutorial\Pages\Calendar.razor"
                             FormatIso8601DateTime(calendarEvent.Start.DateTime)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n                        ");
                __builder2.OpenElement(18, "td");
                __builder2.AddContent(19, 
#nullable restore
#line 27 "C:\Users\enriq\Desktop\PruebaCalendario\GraphTutorial\Pages\Calendar.razor"
                             FormatIso8601DateTime(calendarEvent.End.DateTime)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 29 "C:\Users\enriq\Desktop\PruebaCalendario\GraphTutorial\Pages\Calendar.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(20, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<GraphTutorial.Shared.RedirectToLogin>(21);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\enriq\Desktop\PruebaCalendario\GraphTutorial\Pages\Calendar.razor"
      
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }

    private GraphServiceClient graphClient;
    private IList<Event> events = new List<Event>();
    private string dateTimeFormat;

    protected override async Task OnInitializedAsync()
    {
        // Get the user
        var user = (await authenticationStateTask).User;
        var graphTimeZone = user.GetUserGraphTimeZone();
        dateTimeFormat = $"{user.GetUserGraphDateFormat()} {user.GetUserGraphTimeFormat()}";

        // Calculate the start and end of the current week in user's time zone
        var startOfWeek = GetUtcStartOfWeekInTimeZone(DateTime.Today, graphTimeZone);
        var endOfWeek = startOfWeek.AddDays(7);

        graphClient = clientFactory.GetAuthenticatedClient();

        // Specifies the start and end of the view on the calendar
        // Translates to: ?startDateTime=""&endDateTime=""
        var viewOptions = new List<QueryOption>
        {
            new QueryOption("startDateTime", startOfWeek.ToString("o")),
            new QueryOption("endDateTime", endOfWeek.ToString("o"))
        };

        var eventPage = await graphClient.Me
            .CalendarView
            .Request(viewOptions)
            // Send user time zone in request so date/time in
            // response will be in preferred time zone
            .Header("Prefer", $"outlook.timezone=\"{graphTimeZone}\"")
            // Get max 50 per request
            .Top(50)
            // Only return fields app will use
            .Select(e => new
            {
                e.Subject,
                e.Organizer,
                e.Start,
                e.End
            })
            // Order results chronologically
            .OrderBy("start/dateTime")
            .GetAsync();

        events = eventPage.CurrentPage;
    }

    private DateTime GetUtcStartOfWeekInTimeZone(DateTime today, string timeZoneId)
    {
        // Time zone returned by Graph could be Windows or IANA style
        // TimeZoneConverter can take either
        TimeZoneInfo userTimeZone = TZConvert.GetTimeZoneInfo(timeZoneId);

        // Assumes Sunday as first day of week
        int diff = System.DayOfWeek.Sunday - today.DayOfWeek;

        // create date as unspecified kind
        var unspecifiedStart = DateTime.SpecifyKind(today.AddDays(diff), DateTimeKind.Unspecified);

        // convert to UTC
        return TimeZoneInfo.ConvertTimeToUtc(unspecifiedStart, userTimeZone);
    }

    private string FormatIso8601DateTime(string iso8601DateTime)
    {
        // Load into a DateTime
        var dateTime = DateTime.Parse(iso8601DateTime);

        if (!string.IsNullOrWhiteSpace(dateTimeFormat))
        {
            // Format it using the user's settings
            return dateTime.ToString(dateTimeFormat);
        }

        // Fallback to return original value
        return iso8601DateTime;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private GraphTutorial.Graph.GraphClientFactory clientFactory { get; set; }
    }
}
#pragma warning restore 1591
