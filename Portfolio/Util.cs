using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio
{
    public static class Util
    {
        public static async Task OpenUrlInNewTab(IJSRuntime jsRuntime, string url)
        {
            await jsRuntime.InvokeAsync<object>("open", url, "_blank");
        }
    }
}
