#pragma checksum "C:\exoBlazor\Telerik\BlazorForTelerik\BlazorForTelerikUi\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90d92936364e6760187820306aa8f37c88e8e978"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorForTelerikUi.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\exoBlazor\Telerik\BlazorForTelerik\BlazorForTelerikUi\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\exoBlazor\Telerik\BlazorForTelerik\BlazorForTelerikUi\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\exoBlazor\Telerik\BlazorForTelerik\BlazorForTelerikUi\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\exoBlazor\Telerik\BlazorForTelerik\BlazorForTelerikUi\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\exoBlazor\Telerik\BlazorForTelerik\BlazorForTelerikUi\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\exoBlazor\Telerik\BlazorForTelerik\BlazorForTelerikUi\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\exoBlazor\Telerik\BlazorForTelerik\BlazorForTelerikUi\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\exoBlazor\Telerik\BlazorForTelerik\BlazorForTelerikUi\_Imports.razor"
using BlazorForTelerikUi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\exoBlazor\Telerik\BlazorForTelerik\BlazorForTelerikUi\_Imports.razor"
using BlazorForTelerikUi.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\exoBlazor\Telerik\BlazorForTelerik\BlazorForTelerikUi\_Imports.razor"
using Telerik.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\exoBlazor\Telerik\BlazorForTelerik\BlazorForTelerikUi\_Imports.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Telerik.Blazor.Components.TelerikRootComponent>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n\r\n    ");
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "sidebar");
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.OpenComponent<BlazorForTelerikUi.Shared.NavMenu>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(8, "\r\n\r\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "main content px-4");
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.AddContent(12, 
#nullable restore
#line 11 "C:\exoBlazor\Telerik\BlazorForTelerik\BlazorForTelerikUi\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(13, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
