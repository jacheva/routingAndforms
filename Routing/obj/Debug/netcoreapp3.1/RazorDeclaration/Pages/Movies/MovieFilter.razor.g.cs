#pragma checksum "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Pages\Movies\MovieFilter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e40e00f42ba89b20832308a5e3f635e56285d44"
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
