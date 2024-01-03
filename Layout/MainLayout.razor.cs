using Microsoft.AspNetCore.Components.Web;
using System.Runtime.CompilerServices;

namespace BlazorWasm.Layout
{
    public partial class MainLayout
    {
        public static object TopSection = new();

        private ErrorBoundary _errorBoundary;

        protected override void OnParametersSet()
        {
            _errorBoundary?.Recover();
        }


    }
}
