#pragma checksum "C:\Users\pb\source\repos\MyBlazorApp\MyBlazorApp\Controls\SearchBarComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6bc0d387d3419ec0df7f847b2cf2f7a4b189963"
// <auto-generated/>
#pragma warning disable 1591
namespace MyBlazorApp.Controls
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
    public partial class SearchBarComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "form");
            __builder.AddAttribute(1, "class", "form-inline");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "form-group mx-sm-3 mb-2");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<label for=\"filter\">Search:&nbsp;</label>\r\n        ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "text");
            __builder.AddAttribute(9, "class", "form-control");
            __builder.AddAttribute(10, "id", "filter");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "C:\Users\pb\source\repos\MyBlazorApp\MyBlazorApp\Controls\SearchBarComponent.razor"
                                                                         filter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => filter = __value, filter));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "type", "button");
            __builder.AddAttribute(17, "class", "btn btn-primary mb-2");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\pb\source\repos\MyBlazorApp\MyBlazorApp\Controls\SearchBarComponent.razor"
                                                                 HandleSearch

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, "Search");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n<hr>");
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\pb\source\repos\MyBlazorApp\MyBlazorApp\Controls\SearchBarComponent.razor"
       

    private string filter;

    [Parameter]
    public EventCallback<string> OnSearch { get; set; }

    private void HandleSearch()
    {
        OnSearch.InvokeAsync(filter);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591