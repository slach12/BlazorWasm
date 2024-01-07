﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorWasm.Components
{
    public partial class Card
    {
        private string _info = "Komunikat z CARD";
        [Parameter]
        public string Image { get; set; }
        [Parameter]
        public RenderFragment Title { get; set; }
        [Parameter]
        public RenderFragment Content { get; set; }
        [Parameter]
        public string BtnText { get; set; }
        [Parameter]
        public string Style { get; set; }
        [Parameter]
        public string BtnClass{ get; set; } = "btn btn-danger";
        [Parameter]
        public bool BtnDisabled { get; set; }
        [Parameter]
        public string BtnTitle { get; set; }



        [Parameter]
        public EventCallback<MouseEventArgs> OnClickMore { get; set; }
        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> BtnAttributes { get; set; }

        public override async Task SetParametersAsync(ParameterView parameters)
        {
            Console.WriteLine("SetParametersAsync");
            await base.SetParametersAsync(parameters);
        }

        protected override async Task OnInitializedAsync()
        {
            Console.WriteLine("OnInitializedAsync");
            await base.OnInitializedAsync();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                Console.WriteLine("OnAfterRenderAsync - pierwsze uruchomienie");
            }
            Console.WriteLine("OnAfterRenderAsync");
            await base.OnAfterRenderAsync(firstRender);
        }

    }
}
