using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorAPIClient.Dtos;
using Microsoft.AspNetCore.Components;
namespace BlazorAPIClient.Pages
{
    public partial class Command
    {

        [Inject]
        private HttpClient Http { get; set; }
        private CommandDto[] commands;

        protected override async Task OnInitializedAsync()
        {
            commands = await Http.GetFromJsonAsync<CommandDto[]>("http://localhost:5000/api/commands/");
        }
    }
}