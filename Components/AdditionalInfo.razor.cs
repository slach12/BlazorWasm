using Microsoft.AspNetCore.Components;

namespace BlazorWasm.Components
{
    public partial class AdditionalInfo
    {
        [CascadingParameter(Name = "Info")]
        public string Info { get; set; }
        [CascadingParameter(Name = "Title")]
        public string Title { get; set; }


    }
}
