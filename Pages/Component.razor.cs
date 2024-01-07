using BlazorWasm.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorWasm.Pages
{
    public partial class Component
    {
        private string _info = "Komunikat 123";
        private string _title = "Tytuł!";
        private string _btnText = "Więcej";

        private Dictionary<string, object> _cardAttribiutes = new Dictionary<string, object>()
        {
            {"BtnClass","btn btn-success"},
            {"BtnTitle","Więcej" },
            {"BtnDisabled",false },
            {"Style", ""},
        };

        private Dictionary<string, object> _cardBtnAttribiutes = new Dictionary<string, object>()
        {
            {"class","btn btn-success"},
            {"title","Więcej" },
            {"disabled",false },
            {"type", "button"},
            {"abc", "111 "},
        };

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        private List<CardModel> _authors = new();

        protected async override Task OnInitializedAsync()
        {
            _authors = new List<CardModel>
                {
                    new CardModel { Title = "Jan Kowalski", Content = "Programista C#/.NET z 20 letnim doświadczeniem.Specjalizacje: Blazor i ASP.NET Core", Image = "/files/kowalski.png", BtnText = "Więcej"},
                    new CardModel { Title = "Anna Nowak", Content = "Programista C#/.NET z 10 letnim doświadczeniem.Specjalizacje: WPF", Image = "/files/nowak.png", BtnText = "Więcej"},
                    new CardModel { Title = "Błażej Kwiatkowski", Content = "Programista C#/.NET z 3 letnim doświadczeniem.Specjalizacje: Frontend", Image = "/files/kwiatkowski.png", BtnText = "Więcej" }
                };
            await base.OnInitializedAsync();
        }
        private void ClickMore(MouseEventArgs e)
        {
            NavigationManager.NavigateTo("/");
        }

        private void ChanegeBtnText()
        {
            _btnText = "Więcej .....";
        }
    }
}
