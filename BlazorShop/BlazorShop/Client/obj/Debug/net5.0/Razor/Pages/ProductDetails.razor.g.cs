#pragma checksum "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "434b9fb313beb69423f60116eeb5ad82a49c0ba5"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorShop.Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/product/{id:int}")]
    public partial class ProductDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "views");
            __builder.AddAttribute(2, "b-lzryr83p8h");
            __builder.AddMarkupContent(3, "<i class=\"oi oi-eye\" b-lzryr83p8h></i> ");
#nullable restore
#line 8 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
__builder.AddContent(4, GetViewString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "media");
            __builder.AddAttribute(8, "b-lzryr83p8h");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "media-img-big-wrapper mr-2");
            __builder.AddAttribute(11, "b-lzryr83p8h");
            __builder.OpenElement(12, "img");
            __builder.AddAttribute(13, "class", "media-img-big");
            __builder.AddAttribute(14, "src", 
#nullable restore
#line 12 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                                         product.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "alt", 
#nullable restore
#line 12 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                                                              product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(16, "b-lzryr83p8h");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "media-body");
            __builder.AddAttribute(20, "b-lzryr83p8h");
            __builder.OpenElement(21, "h2");
            __builder.AddAttribute(22, "class", "mb-0");
            __builder.AddAttribute(23, "b-lzryr83p8h");
#nullable restore
#line 15 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
__builder.AddContent(24, product.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenElement(26, "p");
            __builder.AddAttribute(27, "b-lzryr83p8h");
#nullable restore
#line 16 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
__builder.AddContent(28, product.Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 17 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
         if (product.Variants != null && product.Variants.Count > 1)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "form-group");
            __builder.AddAttribute(31, "b-lzryr83p8h");
            __builder.OpenElement(32, "select");
            __builder.AddAttribute(33, "class", "form-control");
            __builder.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                                                    currentEditionId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => currentEditionId = __value, currentEditionId));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(36, "b-lzryr83p8h");
#nullable restore
#line 21 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                     foreach(var variant in product.Variants)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(37, "option");
            __builder.AddAttribute(38, "value", 
#nullable restore
#line 23 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                                        variant.EditionId

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(39, "b-lzryr83p8h");
#nullable restore
#line 23 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
__builder.AddContent(40, variant.Edition.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 24 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 27 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
         if (GetSelectedVariant() != null) { 
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
         if (GetSelectedVariant().OriginalPrice > GetSelectedVariant().Price)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(41, "h6");
            __builder.AddAttribute(42, "class", "text-text-muted original-price");
            __builder.AddAttribute(43, "b-lzryr83p8h");
#nullable restore
#line 31 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
__builder.AddContent(44, GetSelectedVariant().OriginalPrice);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 32 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(45, "h4");
            __builder.AddAttribute(46, "class", "price");
            __builder.AddAttribute(47, "b-lzryr83p8h");
            __builder.AddMarkupContent(48, "\r\n            $");
#nullable restore
#line 34 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
__builder.AddContent(49, GetSelectedVariant().Price);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 36 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(50);
            __builder.AddAttribute(51, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 37 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                         cartItem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "form-group");
                __builder2.AddAttribute(55, "b-lzryr83p8h");
                __Blazor.BlazorShop.Client.Pages.ProductDetails.TypeInference.CreateInputNumber_0(__builder2, 56, 57, "quantity", 58, "form-control", 59, "width: 70px;", 60, 
#nullable restore
#line 39 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                                                        cartItem.Quantity

#line default
#line hidden
#nullable disable
                , 61, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cartItem.Quantity = __value, cartItem.Quantity)), 62, () => cartItem.Quantity);
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(63, "\r\n        ");
            __builder.OpenElement(64, "button");
            __builder.AddAttribute(65, "class", "btn btn-primary");
            __builder.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                                                  AddToCart

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "b-lzryr83p8h");
            __builder.AddMarkupContent(68, "<i class=\"oi oi-cart\" b-lzryr83p8h></i>&nbsp;&nbsp;&nbsp;Add to Cart");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\College Work\Year 4\Project\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
       
    private Product product = new Product();

    [Parameter]
    public int Id { get; set; }

    public int currentEditionId = 1;

    private CartItem cartItem = new CartItem { Quantity = 1 };

    protected override async Task OnParametersSetAsync()
    {
        //  if(ProductService.Products == null || ProductService.Products.Count == 0)
        // {
        //     ProductService.LoadProducts();
        // }
        product = await ProductService.GetProduct(Id); //Products.FirstOrDefault(p => p.Id == Int32.Parse(Id));
        if(product.Variants.Count > 0)
        {
            currentEditionId = product.Variants[0].EditionId;
        } 
    }

    private ProductVariant GetSelectedVariant()
    {
        var variant = product.Variants.FirstOrDefault(v => v.EditionId == currentEditionId);
        return variant;
    }

    private async Task AddToCart()
    {
        var productVariant = GetSelectedVariant();
        cartItem.EditionId = productVariant.EditionId;
        cartItem.EditionName = productVariant.Edition.Name;
        cartItem.Image = product.Image;
        cartItem.Price = productVariant.Price;
        cartItem.ProductId = productVariant.ProductId;
        cartItem.ProductTitle = product.Title;



        await CartService.AddToCart(cartItem);
    }

    private string GetViewString()
    {
        if (product.Views > 1000000)
            return $"{((float)product.Views / 1000000).ToString("#.##")}M";
        if (product.Views > 100000)
            return $"{((float)product.Views / 1000).ToString("#.##")}K";
        if (product.Views > 1000)
            return $"{((float)product.Views / 1000).ToString("#.##")}K";

        return product.Views.ToString("0##");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService ToastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICartService CartService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService LocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
    }
}
namespace __Blazor.BlazorShop.Client.Pages.ProductDetails
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "style", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
