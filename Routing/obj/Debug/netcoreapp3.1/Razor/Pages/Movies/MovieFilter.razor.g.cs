#pragma checksum "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Pages\Movies\MovieFilter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e40e00f42ba89b20832308a5e3f635e56285d44"
// <auto-generated/>
#pragma warning disable 1591
namespace Routing.Pages.Movies
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\_Imports.razor"
using Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\_Imports.razor"
using Routing.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\_Imports.razor"
using Routing.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\_Imports.razor"
using Routing.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\_Imports.razor"
using Routing.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\_Imports.razor"
using Share.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies/search")]
    public partial class MovieFilter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Search Movie</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Pages\Movies\MovieFilter.razor"
                 filterMoviesDTO

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form-inline");
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "form-group  mb-2");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.AddMarkupContent(10, "<label for=\"title\" class=\"sr-only\">Title</label>\r\n        ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "text");
            __builder.AddAttribute(13, "class", "form-control");
            __builder.AddAttribute(14, "id", "title");
            __builder.AddAttribute(15, "placeholder", "Movie Title");
            __builder.AddAttribute(16, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Pages\Movies\MovieFilter.razor"
                              (KeyboardEventArgs e)=> TitleKeyPress(e)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Pages\Movies\MovieFilter.razor"
                            filterMoviesDTO.Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => filterMoviesDTO.Title = __value, filterMoviesDTO.Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "form-group mx-sm-3 mb-2");
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "select");
            __builder.AddAttribute(25, "class", "form-control");
            __builder.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Pages\Movies\MovieFilter.razor"
                                            filterMoviesDTO.GenreId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => filterMoviesDTO.GenreId = __value, filterMoviesDTO.GenreId));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.OpenElement(29, "option");
            __builder.AddAttribute(30, "value", "0");
            __builder.AddMarkupContent(31, "\r\n                --Select a Genre\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
#nullable restore
#line 23 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Pages\Movies\MovieFilter.razor"
             foreach (var genre in Genres)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(33, "                ");
            __builder.OpenElement(34, "option");
            __builder.AddAttribute(35, "value", 
#nullable restore
#line 25 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Pages\Movies\MovieFilter.razor"
                                genre.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(36, 
#nullable restore
#line 25 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Pages\Movies\MovieFilter.razor"
                                           genre.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 26 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Pages\Movies\MovieFilter.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "form-group mx-sm-3 mb-2");
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.OpenElement(44, "input");
            __builder.AddAttribute(45, "type", "checkbox");
            __builder.AddAttribute(46, "class", "form-check-input");
            __builder.AddAttribute(47, "id", "upcomingReleases");
            __builder.AddAttribute(48, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Pages\Movies\MovieFilter.razor"
                      filterMoviesDTO.UpcomingReleases

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => filterMoviesDTO.UpcomingReleases = __value, filterMoviesDTO.UpcomingReleases));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.AddMarkupContent(51, "<label class=\"form-check-label\" for=\"upcomingReleases\">\r\n            Upcoimng Releases\r\n        </label>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n    ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "form-group mx-sm-3 mb-2");
            __builder.AddMarkupContent(55, "\r\n        ");
            __builder.OpenElement(56, "input");
            __builder.AddAttribute(57, "type", "checkbox");
            __builder.AddAttribute(58, "class", "form-check-input");
            __builder.AddAttribute(59, "id", "upcomingReleases");
            __builder.AddAttribute(60, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Pages\Movies\MovieFilter.razor"
                      filterMoviesDTO.InTheaters

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => filterMoviesDTO.InTheaters = __value, filterMoviesDTO.InTheaters));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n        ");
            __builder.AddMarkupContent(63, "<label class=\"form-check-label\" for=\"upcomingReleases\">\r\n            In Theaters\r\n        </label>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n    ");
            __builder.OpenElement(65, "button");
            __builder.AddAttribute(66, "type", "button");
            __builder.AddAttribute(67, "class", "btn btn-primary mb-2 mx-sm-3");
            __builder.AddAttribute(68, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Pages\Movies\MovieFilter.razor"
                                                                         SearchForMovies

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(69, "Filter");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, " \r\n    ");
            __builder.OpenElement(71, "button");
            __builder.AddAttribute(72, "type", "button");
            __builder.AddAttribute(73, "class", "btn btn-danger mb-2 ");
            __builder.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Pages\Movies\MovieFilter.razor"
                                                                 Clear

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(75, "Clear");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, " \r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n\r\n");
            __builder.OpenComponent<Routing.Shared.MovieList>(78);
            __builder.AddAttribute(79, "Movies", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Routing.Entities.Movie>>(
#nullable restore
#line 47 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Pages\Movies\MovieFilter.razor"
                   Movies

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(80, "\r\n\r\n");
            __builder.OpenComponent<Routing.Shared.Pagination>(81);
            __builder.AddAttribute(82, "CurrentPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 49 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Pages\Movies\MovieFilter.razor"
                         filterMoviesDTO.Page

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(83, "TotalAmountPages", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 49 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Pages\Movies\MovieFilter.razor"
                                                                 totalAmountPages

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(84, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 50 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Pages\Movies\MovieFilter.razor"
                          SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Pages\Movies\MovieFilter.razor"
       
    private List<Movie> Movies;
    private FilterMoviesDTO filterMoviesDTO = new FilterMoviesDTO();
    private int totalAmountPages;
    private List<Genre> Genres = new List<Genre>();


    protected async Task OnInitializedAsync()
    {
        var queryStrings = navigationManager.GetQueryStrings(navigationManager.Uri);

        Genres = await genreRepository.GetGenres();
        if (queryStrings != null)
        {
            FillFilterWithQueryStrings(queryStrings);
            
        }
        await LoadMovies();
        
        base.OnInitialized();
    }

    private void FillFilterWithQueryStrings(Dictionary<string, string> queryStrings)
    {
        if (queryStrings.ContainsKey("genreId"))
        {
            filterMoviesDTO.GenreId = int.Parse(queryStrings["genreId"]);
        }
        if (queryStrings.ContainsKey("title"))
        {
            filterMoviesDTO.Title = queryStrings["title"];
        }
        if (queryStrings.ContainsKey("inTheaters"))
        {
            filterMoviesDTO.UpcomingReleases = bool.Parse(queryStrings["inTheaters"]);
        }
        if (queryStrings.ContainsKey("upcomingReleases"))
        {
            filterMoviesDTO.UpcomingReleases = bool.Parse(queryStrings["ucpomingReleases"]);
        }
        if (queryStrings.ContainsKey("page"))
        {
            filterMoviesDTO.Page = int.Parse(queryStrings["page"]);
        }
    }


    private async Task SelectedPage(int page)
    {
        filterMoviesDTO.Page = page;
        await LoadMovies();
    }

    private async Task LoadMovies()
    {
        var queryString =GenerateQueryString();
        if (!string.IsNullOrWhiteSpace(queryString))
        {
            queryString = $"?{queryString}";
            navigationManager.NavigateTo("movies/search" + queryString);

        }
        var paginatedResponse = await moviesRepository.GetMoviesFiltered(filterMoviesDTO);
        Movies = paginatedResponse.Response;
        totalAmountPages = paginatedResponse.TotalAmountPages;
    }


    private string GenerateQueryString()
    {
        var queryStringDict = new Dictionary<string, string>();
        queryStringDict["genreId"] = filterMoviesDTO.GenreId.ToString();
        queryStringDict["title"] = filterMoviesDTO.Title ?? "";
        queryStringDict["inTheaters"] = filterMoviesDTO.InTheaters.ToString();
        queryStringDict["upcomingReleases"] = filterMoviesDTO.UpcomingReleases.ToString();
        queryStringDict["page"] = filterMoviesDTO.Page.ToString();

        var defaultValue = new List<string>() { "false", "", "0"};

        // genreId =4 & title =spider....

        return string.Join("&", queryStringDict
            .Where(x => !defaultValue.Contains(x.Value.ToLower()))
            .Select(x => $"{x.Key}={System.Web.HttpUtility.UrlEncode(x.Value)}").ToArray());

    }

    private async Task SearchForMovies()
    {
        await LoadMovies();
    }
    private async Task Clear()
    {

        filterMoviesDTO.Title = "";
        filterMoviesDTO.GenreId = 0;
        filterMoviesDTO.UpcomingReleases = false;
        filterMoviesDTO.InTheaters = false;
        await LoadMovies();
    }



    private async Task TitleKeyPress(KeyboardEventArgs e)
    {
        if (e.Key == "Enter")
        {
            await SearchForMovies();
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGenreRepository genreRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMoviesRepository moviesRepository { get; set; }
    }
}
#pragma warning restore 1591
