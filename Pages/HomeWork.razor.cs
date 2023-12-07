using Microsoft.AspNetCore.Components;

namespace BlazorWasm.Pages
{
    public partial class HomeWork
    {
      
        [Inject]
        public NavigationManager NavigationManager { get; set; }
      //  [Parameter]
        //  private string _header;
        //public string Header { get; set; }
 /*       public string? Header {
            get  => _header.Length != 0 ? _header: "Praca domowa";
            set => _header = value;
        } 
 */     //  public string? Header { get { if (_header.Length == 0) { } }; set {_header = value } }
        public void ToMainPage()
        {
            NavigationManager.NavigateTo("/");
        }

    }
}
