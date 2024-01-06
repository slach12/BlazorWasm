using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorWasm.Components
{
    public partial class Card
    {
        private string _info = "Komunikat z CARD";
        [Parameter]
        public string Image { get; set; }
        [Parameter]
        public string Title { get; set; }
        [Parameter]
        public string Content { get; set; }
        [Parameter]
        public string BtnText { get; set; }
        [Parameter]
        public EventCallback<MouseEventArgs> OnClickMore { get; set; }


    }
}
