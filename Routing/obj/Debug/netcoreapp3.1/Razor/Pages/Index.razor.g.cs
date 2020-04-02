#pragma checksum "C:\Users\ReDent\source\repos\Routing\Routing\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2409614bb957b0af9332ab147cd7e01f2473e184"
// <auto-generated/>
#pragma warning disable 1591
namespace Routing.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/index")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\r\n     ");
            __builder.AddMarkupContent(2, "<h3>Movie</h3>\r\n     ");
            __builder.OpenComponent<Routing.Shared.MovieList>(3);
            __builder.AddAttribute(4, "Movies", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Routing.Entities.Movie>>(
#nullable restore
#line 7 "C:\Users\ReDent\source\repos\Routing\Routing\Pages\Index.razor"
                        movies

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
            __Blazor.Routing.Pages.Index.TypeInference.CreateCustomTypeahead_0(__builder, 7, 8, 
#nullable restore
#line 9 "C:\Users\ReDent\source\repos\Routing\Routing\Pages\Index.razor"
                                SearchMethod

#line default
#line hidden
#nullable disable
            , 9, (context) => (__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.AddContent(11, 
#nullable restore
#line 11 "C:\Users\ReDent\source\repos\Routing\Routing\Pages\Index.razor"
         context

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(12, "\r\n    ");
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\ReDent\source\repos\Routing\Routing\Pages\Index.razor"
      
    private List<Movie> movies;
    protected async override Task OnInitializedAsync()
    {
        movies = repository.GetMovies();
    }
    private async Task<IEnumerable<string>> SearchMethod (string searchText)
    {
        await Task.Delay(2000);
        if (searchText == "Test") { return Enumerable.Empty<string>(); }
        return new List<string>() { "Sandra", "Jacheva2" };
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepository repository { get; set; }
    }
}
namespace __Blazor.Routing.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCustomTypeahead_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<global::System.String, global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<TItem>>> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg1)
        {
        __builder.OpenComponent<global::Routing.Shared.CustomTypeahead<TItem>>(seq);
        __builder.AddAttribute(__seq0, "SearchMethod", __arg0);
        __builder.AddAttribute(__seq1, "ResultTemplate", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
