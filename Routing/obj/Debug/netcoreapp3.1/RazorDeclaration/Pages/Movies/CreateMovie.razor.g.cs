#pragma checksum "C:\Users\ReDent\source\repos\Routing\Routing\Pages\Movies\CreateMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f594eb8728b581ed8fb63ca8cb00d68307af5244"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Routing.Pages.Movies
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ReDent\source\repos\Routing\Routing\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ReDent\source\repos\Routing\Routing\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ReDent\source\repos\Routing\Routing\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ReDent\source\repos\Routing\Routing\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ReDent\source\repos\Routing\Routing\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ReDent\source\repos\Routing\Routing\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ReDent\source\repos\Routing\Routing\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ReDent\source\repos\Routing\Routing\_Imports.razor"
using Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ReDent\source\repos\Routing\Routing\_Imports.razor"
using Routing.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ReDent\source\repos\Routing\Routing\_Imports.razor"
using Routing.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ReDent\source\repos\Routing\Routing\_Imports.razor"
using Routing.Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies/create")]
    public partial class CreateMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\ReDent\source\repos\Routing\Routing\Pages\Movies\CreateMovie.razor"
       


    private Movie Movie = new Movie();

    private List<Genre> NotSelectedGenres = new List<Genre>()
    {
        new Genre(){Id=1, Name = "Action"},
        new Genre(){Id=2, Name = "Comedy"},
        new Genre(){Id=3, Name = "Drama" }
    };

    private void SaveMovie()
    {
        //Savin movie
        Console.WriteLine("this works");
        //navigationManager.NavigateTo("movie");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
