#pragma checksum "C:\Users\pb\source\repos\MyBlazorApp\MyBlazorApp\Pages\DynamicComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cc2b7846101456e4aa31e883bae3e71b1a2c4c3"
// <auto-generated/>
#pragma warning disable 1591
namespace MyBlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\pb\source\repos\MyBlazorApp\MyBlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pb\source\repos\MyBlazorApp\MyBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pb\source\repos\MyBlazorApp\MyBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pb\source\repos\MyBlazorApp\MyBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\pb\source\repos\MyBlazorApp\MyBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\pb\source\repos\MyBlazorApp\MyBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\pb\source\repos\MyBlazorApp\MyBlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\pb\source\repos\MyBlazorApp\MyBlazorApp\_Imports.razor"
using MyBlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\pb\source\repos\MyBlazorApp\MyBlazorApp\_Imports.razor"
using MyBlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\pb\source\repos\MyBlazorApp\MyBlazorApp\_Imports.razor"
using MyBlazorApp.UseCases.SearchMovieScreen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\pb\source\repos\MyBlazorApp\MyBlazorApp\_Imports.razor"
using MyBlazorApp.CoreBusiness.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\pb\source\repos\MyBlazorApp\MyBlazorApp\_Imports.razor"
using MyBlazorApp.Controls;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/dynamic")]
    public partial class DynamicComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Our First Dynamic Component</h3>\r\n\r\n<br>\r\n<br>\r\n\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\pb\source\repos\MyBlazorApp\MyBlazorApp\Pages\DynamicComponent.razor"
                  HandleBlazorServerClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(3, "Blazor Server");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\pb\source\repos\MyBlazorApp\MyBlazorApp\Pages\DynamicComponent.razor"
                  HandleBlazorWebAssemblyClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(7, "Blazor WebAssembly");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n<br>\r\n<br>\r\n\r\n");
            __builder.OpenElement(9, "h3");
#nullable restore
#line 13 "C:\Users\pb\source\repos\MyBlazorApp\MyBlazorApp\Pages\DynamicComponent.razor"
__builder.AddContent(10, title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.OpenElement(12, "p");
#nullable restore
#line 14 "C:\Users\pb\source\repos\MyBlazorApp\MyBlazorApp\Pages\DynamicComponent.razor"
__builder.AddContent(13, content);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\pb\source\repos\MyBlazorApp\MyBlazorApp\Pages\DynamicComponent.razor"
       

    private string title;
    private string content;

    private void HandleBlazorServerClick()
    {
        title = "Title Server";
        content = "Server Content";
    }

    private void HandleBlazorWebAssemblyClick()
    {
        title = "Title WebAssembly";
        content = "WebAssembly Content";
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591