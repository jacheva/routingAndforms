#pragma checksum "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Shared\GenericList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e8000730c92e6b40f14edc57f1784f2fdf7d295"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Routing.Shared
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
    public partial class GenericList<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\ReDent\Desktop\sandra\Udemy\routingAndforms\Routing\Shared\GenericList.razor"
       
    [Parameter] public RenderFragment NullTemplate { get; set; }
    [Parameter] public RenderFragment EmptyTemplate { get; set; }
    [Parameter] public RenderFragment<TItem> ElementTemplate { get; set; }
    [Parameter] public RenderFragment WholeListTemplate { get; set; }
    [Parameter] public List<TItem> List { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
