using Microsoft.AspNetCore.Components;

namespace BlazorWasm.Pages
{
    public partial class Home
    {

        [Inject]
        NavigationManager NavigationManager { get; set; }   
        public void ToHomeWork()
        {
            NavigationManager.NavigateTo("/homework-par/paremtrTestowy");
        }
    }
}
