// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MyBlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\pb\source\repos\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pb\source\repos\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pb\source\repos\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pb\source\repos\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\pb\source\repos\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\pb\source\repos\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\pb\source\repos\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\pb\source\repos\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\_Imports.razor"
using MyBlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\pb\source\repos\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\_Imports.razor"
using MyBlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\pb\source\repos\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\_Imports.razor"
using MyBlazorApp.UseCases.SearchMovieScreen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\pb\source\repos\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\_Imports.razor"
using MyBlazorApp.CoreBusiness.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\pb\source\repos\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\_Imports.razor"
using MyBlazorApp.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\pb\source\repos\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\_Imports.razor"
using MyBlazorApp.Store.CounterStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\pb\source\repos\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\_Imports.razor"
using MyBlazorApp.CoreBusiness.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\pb\source\repos\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\_Imports.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 115 "C:\Users\pb\source\repos\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\Blazor_Movie_E-Commerce_Tutorial\MyBlazorApp\Pages\Index.razor"
       
    private VisibilityComponent visibilityComponent;
    private int selectedMovieId = 0;
    private List<Movie> movies = new List<Movie>
    {
        new Movie { Id = 1, Title="Iron Man", YearReleased = "2008", ImageLink="https://m.media-amazon.com/images/I/517EnJmL7+L._AC_UY218_.jpg", Description="After being held captive in an Afghan cave, billionaire engineer Tony Stark creates a unique weaponized suit of armor to fight evil."},
        new Movie { Id = 2, Title="Hercules", YearReleased = "2012", ImageLink="https://m.media-amazon.com/images/I/915zrle1jhL._AC_UY218_.jpg", Description="Having endured his legendary twelve labors, Hercules, the Greek demigod, has his life as a sword-for-hire tested when the King of Thrace and his daughter seek his aid in defeating a tyrannical warlord."},
        new Movie { Id = 3, Title="2012", YearReleased = "2009", ImageLink="https://m.media-amazon.com/images/I/91gj8w+frzL._AC_UY218_.jpg", Description="A frustrated writer struggles to keep his family alive when a series of global catastrophes threatens to annihilate mankind."}

    };
    private int selectedGroup;
    private bool isActive = false;
    private Movie movie = new Movie { Id = 4, Title = "Movie 4", YearReleased = "2011", ImageLink = "http://", Description = "Description Movie 4" };

    void Toggle()
    {
        this.visibilityComponent.SetVisibility();
    }

    Person person = new Person();

    class Person
    {
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [Range(1,1000)]
        public int EmployeeNumber { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }

    private void ValidFormSubmitted()
    {

    }

    //Customer Service Section
    private Customer customer;

    protected override void OnInitialized()
    {
        base.OnInitialized();

        customer = customerService.GetCustomerById(4);
    }
    public void Dispose()
    {

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICustomerService customerService { get; set; }
    }
}
#pragma warning restore 1591
