#pragma checksum "C:\Users\Ashirwad Satapathi\Downloads\Compressed\blazor-starter-main\blazor-starter-main\blazor-spa\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf30d8a6d0951492d3cc0d1f7ba72f80fba6cfd2"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Ashirwad Satapathi\Downloads\Compressed\blazor-starter-main\blazor-starter-main\blazor-spa\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ashirwad Satapathi\Downloads\Compressed\blazor-starter-main\blazor-starter-main\blazor-spa\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ashirwad Satapathi\Downloads\Compressed\blazor-starter-main\blazor-starter-main\blazor-spa\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ashirwad Satapathi\Downloads\Compressed\blazor-starter-main\blazor-starter-main\blazor-spa\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ashirwad Satapathi\Downloads\Compressed\blazor-starter-main\blazor-starter-main\blazor-spa\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ashirwad Satapathi\Downloads\Compressed\blazor-starter-main\blazor-starter-main\blazor-spa\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ashirwad Satapathi\Downloads\Compressed\blazor-starter-main\blazor-starter-main\blazor-spa\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ashirwad Satapathi\Downloads\Compressed\blazor-starter-main\blazor-starter-main\blazor-spa\Client\_Imports.razor"
using BlazorApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ashirwad Satapathi\Downloads\Compressed\blazor-starter-main\blazor-starter-main\blazor-spa\Client\_Imports.razor"
using BlazorApp.Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenComponent<BlazorApp.Client.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\n\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\n    ");
            __builder.AddMarkupContent(9, "<div class=\"top-row px-4\">\n        <a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\">About</a>\n    </div>\n\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "content px-4");
            __builder.AddMarkupContent(12, "\n        ");
            __builder.AddContent(13, 
#nullable restore
#line 13 "C:\Users\Ashirwad Satapathi\Downloads\Compressed\blazor-starter-main\blazor-starter-main\blazor-spa\Client\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(14, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
