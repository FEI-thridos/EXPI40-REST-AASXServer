// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AasxServerBlazor.Shared
{
    #line hidden
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\martin.pajpach\Downloads\AASX REST Server\src\AasxServerBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\martin.pajpach\Downloads\AASX REST Server\src\AasxServerBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\martin.pajpach\Downloads\AASX REST Server\src\AasxServerBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\martin.pajpach\Downloads\AASX REST Server\src\AasxServerBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\martin.pajpach\Downloads\AASX REST Server\src\AasxServerBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\martin.pajpach\Downloads\AASX REST Server\src\AasxServerBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\martin.pajpach\Downloads\AASX REST Server\src\AasxServerBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\martin.pajpach\Downloads\AASX REST Server\src\AasxServerBlazor\_Imports.razor"
using AasxServerBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\martin.pajpach\Downloads\AASX REST Server\src\AasxServerBlazor\_Imports.razor"
using AasxServerBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\martin.pajpach\Downloads\AASX REST Server\src\AasxServerBlazor\Shared\MainLayout.razor"
using System;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 87 "C:\Users\martin.pajpach\Downloads\AASX REST Server\src\AasxServerBlazor\Shared\MainLayout.razor"
      
    static string path = "https://zvei-pcf.germanywestcentral.cloudapp.azure.com/dashboard/submodelView.html?id=ZveiControlCabinetAas";
    static bool pathIntit = true;

    static string getIframePath()
    {
        if (pathIntit)
        {
            pathIntit = false;
            var p = Environment.GetEnvironmentVariable("IFRAMEPATH");
            if (p != null)
                path = p;
        }

        return path;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMan { get; set; }
    }
}
#pragma warning restore 1591
