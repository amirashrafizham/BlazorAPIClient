#pragma checksum "C:\Users\amirashraf.ahmadizh\OneDrive - PETRONAS\Desktop\BlazorAPIClient\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fede460c9691c34fe4fa49117f0903cb89857866"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAPIClient.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\amirashraf.ahmadizh\OneDrive - PETRONAS\Desktop\BlazorAPIClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\amirashraf.ahmadizh\OneDrive - PETRONAS\Desktop\BlazorAPIClient\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\amirashraf.ahmadizh\OneDrive - PETRONAS\Desktop\BlazorAPIClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\amirashraf.ahmadizh\OneDrive - PETRONAS\Desktop\BlazorAPIClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\amirashraf.ahmadizh\OneDrive - PETRONAS\Desktop\BlazorAPIClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\amirashraf.ahmadizh\OneDrive - PETRONAS\Desktop\BlazorAPIClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\amirashraf.ahmadizh\OneDrive - PETRONAS\Desktop\BlazorAPIClient\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\amirashraf.ahmadizh\OneDrive - PETRONAS\Desktop\BlazorAPIClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\amirashraf.ahmadizh\OneDrive - PETRONAS\Desktop\BlazorAPIClient\_Imports.razor"
using BlazorAPIClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\amirashraf.ahmadizh\OneDrive - PETRONAS\Desktop\BlazorAPIClient\_Imports.razor"
using BlazorAPIClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\amirashraf.ahmadizh\OneDrive - PETRONAS\Desktop\BlazorAPIClient\_Imports.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>SpaceX Launches</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This is launch data pulled back back via REST API</p>");
#nullable restore
#line 8 "C:\Users\amirashraf.ahmadizh\OneDrive - PETRONAS\Desktop\BlazorAPIClient\Pages\FetchData.razor"
 if (launches == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 11 "C:\Users\amirashraf.ahmadizh\OneDrive - PETRONAS\Desktop\BlazorAPIClient\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th>ID</th>\r\n                <th>Tentative (True/False)</th>\r\n                <th>Launch Date Local</th>\r\n                <th>Mission Name</th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 24 "C:\Users\amirashraf.ahmadizh\OneDrive - PETRONAS\Desktop\BlazorAPIClient\Pages\FetchData.razor"
             foreach (var launch in launches)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 27 "C:\Users\amirashraf.ahmadizh\OneDrive - PETRONAS\Desktop\BlazorAPIClient\Pages\FetchData.razor"
                         launch.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 28 "C:\Users\amirashraf.ahmadizh\OneDrive - PETRONAS\Desktop\BlazorAPIClient\Pages\FetchData.razor"
                         launch.IsTentative

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 29 "C:\Users\amirashraf.ahmadizh\OneDrive - PETRONAS\Desktop\BlazorAPIClient\Pages\FetchData.razor"
                         launch.LaunchDateLocal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 30 "C:\Users\amirashraf.ahmadizh\OneDrive - PETRONAS\Desktop\BlazorAPIClient\Pages\FetchData.razor"
                         launch.MissionName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\amirashraf.ahmadizh\OneDrive - PETRONAS\Desktop\BlazorAPIClient\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "C:\Users\amirashraf.ahmadizh\OneDrive - PETRONAS\Desktop\BlazorAPIClient\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
