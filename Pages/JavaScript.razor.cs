using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorWasm.Pages
{
    public partial class JavaScript
    {
        private bool _dialogResult = false;
        private string _currentDate = "";
        [Inject]
        public IJSRuntime JSRuntime { get; set; }
        public async Task DisplayAlert()
        {
            await JSRuntime.InvokeVoidAsync("alert", "Przykładowa wiadomość z przycisku JavaScript");
        }

        private async Task DisplayConfirmDialog()
        {
            _dialogResult = await JSRuntime.InvokeAsync<bool>("confirm", "Czy na pewno chcesz usunąć rekord?");
        }

        private async Task ShowResultJS()
        {
            await JSRuntime.InvokeVoidAsync("addNumberJS", 1, 2);
        }

        [JSInvokable]
        public static int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        private async Task ShowResultCSharp()
        {
            await JSRuntime.InvokeVoidAsync("addNumberCSharp", 11, 22);
        }
        [JSInvokable]
        public static string GetCurrentDate()
        {
            return DateTime.Now.ToString("dd-MM-yyyy");
        }

        private async Task ShowDate()
        {
            _currentDate = await JSRuntime.InvokeAsync<string>("GetCurrentDateCShape");
        }


}
}
