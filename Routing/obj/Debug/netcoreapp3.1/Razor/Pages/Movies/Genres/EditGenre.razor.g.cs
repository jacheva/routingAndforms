#pragma checksum "C:\Users\ReDent\source\repos\Routing\Routing\Pages\Movies\Genres\EditGenre.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e700f95f01dabf0a24374a1acdf4481d676cb9f6"
// <auto-generated/>
#pragma warning disable 1591
namespace Routing.Pages.Movies.Genres
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/genre/edit/{GenreId:int}")]
    public partial class EditGenre : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>EditGenre</h3>\r\n\r\n");
#nullable restore
#line 5 "C:\Users\ReDent\source\repos\Routing\Routing\Pages\Movies\Genres\EditGenre.razor"
 if (genre != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenComponent<Routing.Pages.Movies.Genres.GenreForm>(2);
            __builder.AddAttribute(3, "Genre", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Routing.Entities.Genre>(
#nullable restore
#line 7 "C:\Users\ReDent\source\repos\Routing\Routing\Pages\Movies\Genres\EditGenre.razor"
                      genre

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 7 "C:\Users\ReDent\source\repos\Routing\Routing\Pages\Movies\Genres\EditGenre.razor"
                                            Edit 

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 8 "C:\Users\ReDent\source\repos\Routing\Routing\Pages\Movies\Genres\EditGenre.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\ReDent\source\repos\Routing\Routing\Pages\Movies\Genres\EditGenre.razor"
       

    [Parameter] public int GenreId { get; set; }
    public Genre genre;

    protected override void OnInitialized()
    {
        base.OnInitialized();
        genre = new Genre() { Id = GenreId, Name = "Comedy" };
    }
    private void Edit()
    {
        Console.WriteLine("Edit methode");
        Console.WriteLine($"Id = {genre.Id}");
        Console.WriteLine($"Name = {genre.Name}");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
