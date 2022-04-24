#pragma checksum "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\Shared\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f054146ed99f17f23f7b35d0b2dfce64e98b2fc"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorShop.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\_Imports.razor"
using BlazorShop.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\_Imports.razor"
using BlazorShop.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\_Imports.razor"
using BlazorShop.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\_Imports.razor"
using BlazorShop.Client.Services.ProductService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\_Imports.razor"
using BlazorShop.Client.Services.CategoryService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\_Imports.razor"
using BlazorShop.Client.Services.CartService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\_Imports.razor"
using BlazorShop.Client.Services.StatsService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "ul");
            __builder.AddAttribute(1, "class", "list-list-unstyled");
#nullable restore
#line 5 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\Shared\ProductList.razor"
     foreach(var product in  ProductService.Products)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "li");
            __builder.AddAttribute(3, "class", "media my-3");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "media-image-wrapper mr-2");
            __builder.OpenElement(6, "a");
            __builder.AddAttribute(7, "href", "/product/" + (
#nullable restore
#line 9 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\Shared\ProductList.razor"
                                   product.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(8, "img");
            __builder.AddAttribute(9, "class", "media-img");
            __builder.AddAttribute(10, "src", 
#nullable restore
#line 10 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\Shared\ProductList.razor"
                                                  product.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "alt", 
#nullable restore
#line 10 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\Shared\ProductList.razor"
                                                                       product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "media-body");
            __builder.OpenElement(15, "a");
            __builder.AddAttribute(16, "href", "/product/" + (
#nullable restore
#line 14 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\Shared\ProductList.razor"
                                   product.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(17, "h4");
            __builder.AddAttribute(18, "class", "mb-0");
#nullable restore
#line 15 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\Shared\ProductList.razor"
__builder.AddContent(19, product.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "p");
#nullable restore
#line 17 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\Shared\ProductList.razor"
__builder.AddContent(22, product.Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "h5");
            __builder.AddAttribute(25, "class", "price");
#nullable restore
#line 19 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\Shared\ProductList.razor"
__builder.AddContent(26, GetPriceText(product));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 23 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\Shared\ProductList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\Shared\ProductList.razor"
       
    //[Parameter]
    //public int? CategoryId { get; set; } = null;


    protected override void OnInitialized()
    {
        //await ProductService.LoadProducts();
        ProductService.OnChange += StateHasChanged;
    }

    public void Dispose()
    {
        ProductService.OnChange -= StateHasChanged;
    }

    private string GetPriceText(Product product)
    {
        var variants = product.Variants;
        if (variants.Count == 0)
        {
            return string.Empty;
        }
        else if (variants.Count == 1)
        {
            return $"${variants[0].Price}";
        }
        decimal minPrice = variants.Min(v => v.Price);
        return $"Starting at ${minPrice}";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591
