#pragma checksum "C:\Users\amirashraf.ahmadizh\OneDrive - PETRONAS\Desktop\BlazorAPIClient\Pages\DeleteCommand.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "826e3548eb46ce2cb831a1352a38c2d93db1b856"
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
            __builder.AddMarkupContent(0, "<h3>Delete Command</h3>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Are you sure you want to delete this Product with Id: ");
            __builder.OpenElement(3, "b");
            __builder.AddContent(4, 
#nullable restore
#line 7 "C:\Users\amirashraf.ahmadizh\OneDrive - PETRONAS\Desktop\BlazorAPIClient\Pages\DeleteCommand.razor"
                                                             id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(5, "? ");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n<br>\r\n\r\n");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-md-4");
            __builder.OpenElement(9, "table");
            __builder.AddAttribute(10, "class", "table");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "<td>How To</td>\r\n            ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 14 "C:\Users\amirashraf.ahmadizh\OneDrive - PETRONAS\Desktop\BlazorAPIClient\Pages\DeleteCommand.razor"
                 command.HowTo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "tr");
            __builder.AddMarkupContent(17, "<td>Line</td>\r\n            ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 18 "C:\Users\amirashraf.ahmadizh\OneDrive - PETRONAS\Desktop\BlazorAPIClient\Pages\DeleteCommand.razor"
                 command.Line

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "tr");
            __builder.AddMarkupContent(22, "<td>Platform</td>\r\n            ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 22 "C:\Users\amirashraf.ahmadizh\OneDrive - PETRONAS\Desktop\BlazorAPIClient\Pages\DeleteCommand.razor"
                 command.Platform

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "row");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "col-md-4");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "form-group");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "type", "button");
            __builder.AddAttribute(34, "class", "btn btn-success");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\amirashraf.ahmadizh\OneDrive - PETRONAS\Desktop\BlazorAPIClient\Pages\DeleteCommand.razor"
                                                                    DeleteCommandAPI

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "value", "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.OpenElement(38, "input");
            __builder.AddAttribute(39, "type", "button");
            __builder.AddAttribute(40, "class", "btn btn-danger");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\amirashraf.ahmadizh\OneDrive - PETRONAS\Desktop\BlazorAPIClient\Pages\DeleteCommand.razor"
                                                                   Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "value", "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
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
