#pragma checksum "C:\exoBlazor\Telerik\BlazorForTelerik\BlazorForTelerikUi\Pages\Calendar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "108ca8be8fd38f3b28f51ff8462f649ba50d0ea0"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorForTelerikUi.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/calendar")]
    public partial class Calendar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Telerik Calendar</h3>\r\n");
            __builder.OpenComponent<Telerik.Blazor.Components.TelerikCalendar>(1);
            __builder.AddAttribute(2, "Min", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#nullable restore
#line 3 "C:\exoBlazor\Telerik\BlazorForTelerik\BlazorForTelerikUi\Pages\Calendar.razor"
                       min

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Max", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#nullable restore
#line 3 "C:\exoBlazor\Telerik\BlazorForTelerik\BlazorForTelerikUi\Pages\Calendar.razor"
                                  max

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.DateTime>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTime>(this, 
#nullable restore
#line 3 "C:\exoBlazor\Telerik\BlazorForTelerik\BlazorForTelerikUi\Pages\Calendar.razor"
                                                      AfficherCalendrier

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "Date", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#nullable restore
#line 3 "C:\exoBlazor\Telerik\BlazorForTelerik\BlazorForTelerikUi\Pages\Calendar.razor"
                                                                                       actuelle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "DateChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.DateTime>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTime>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => actuelle = __value, actuelle))));
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n<br>\r\n");
            __builder.AddContent(8, 
#nullable restore
#line 7 "C:\exoBlazor\Telerik\BlazorForTelerik\BlazorForTelerikUi\Pages\Calendar.razor"
 Message

#line default
#line hidden
#nullable disable
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\exoBlazor\Telerik\BlazorForTelerik\BlazorForTelerikUi\Pages\Calendar.razor"
       
    DateTime min = new DateTime(2000,1,1);
    DateTime max = new DateTime(2050,12,31);
    DateTime actuelle { get; set; } = DateTime.Now;
    string Message;

    private void AfficherCalendrier(DateTime TheDate) 
    {
        Message = TheDate.ToString("dd MMM yyyy");
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
