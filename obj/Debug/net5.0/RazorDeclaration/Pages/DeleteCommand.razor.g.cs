// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 2 "C:\Users\amirashraf.ahmadizh\OneDrive - PETRONAS\Desktop\BlazorAPIClient\Pages\DeleteCommand.razor"
using BlazorAPIClient.Dtos;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/deletecommand/{id}")]
    public partial class DeleteCommand : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\amirashraf.ahmadizh\OneDrive - PETRONAS\Desktop\BlazorAPIClient\Pages\DeleteCommand.razor"
       
    [Parameter]
    public string id { get; set; } = ""; //REMEMBER YOU HAVE TO PUT IT IN STRING OR ELSE YOU WILL GET CAST ERROR WHEN
                                         // LOADING THE PAGE
    private CommandDto command { get; set; } = new CommandDto();
    protected async Task DeleteCommandAPI()
    {
        await http.DeleteAsync($"http://localhost:5000/api/commands/{id}");
        NavigationManager.NavigateTo("command");
    }

    void Cancel()
    {
        NavigationManager.NavigateTo("command");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
