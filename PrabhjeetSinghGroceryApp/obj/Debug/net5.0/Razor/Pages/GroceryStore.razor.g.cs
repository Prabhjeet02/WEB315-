#pragma checksum "E:\Semester 2\Intro to Asp.net\WEB315-\PrabhjeetSinghGroceryApp\Pages\GroceryStore.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28a713caf4e10ebeb98f9e3a9466ceda89363f26"
// <auto-generated/>
#pragma warning disable 1591
namespace PrabhjeetSinghGroceryApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Semester 2\Intro to Asp.net\WEB315-\PrabhjeetSinghGroceryApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Semester 2\Intro to Asp.net\WEB315-\PrabhjeetSinghGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Semester 2\Intro to Asp.net\WEB315-\PrabhjeetSinghGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Semester 2\Intro to Asp.net\WEB315-\PrabhjeetSinghGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Semester 2\Intro to Asp.net\WEB315-\PrabhjeetSinghGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Semester 2\Intro to Asp.net\WEB315-\PrabhjeetSinghGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Semester 2\Intro to Asp.net\WEB315-\PrabhjeetSinghGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Semester 2\Intro to Asp.net\WEB315-\PrabhjeetSinghGroceryApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Semester 2\Intro to Asp.net\WEB315-\PrabhjeetSinghGroceryApp\_Imports.razor"
using PrabhjeetSinghGroceryApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Semester 2\Intro to Asp.net\WEB315-\PrabhjeetSinghGroceryApp\_Imports.razor"
using PrabhjeetSinghGroceryApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/GroceryStore")]
    public partial class GroceryStore : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "GroceryStore (");
            __builder.AddContent(2, 
#nullable restore
#line 2 "E:\Semester 2\Intro to Asp.net\WEB315-\PrabhjeetSinghGroceryApp\Pages\GroceryStore.razor"
                   GroceryStoreList.Count(GroceryIsle => !GroceryIsle.IsDone)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(3, ")");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "placeholder", "Search here");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 4 "E:\Semester 2\Intro to Asp.net\WEB315-\PrabhjeetSinghGroceryApp\Pages\GroceryStore.razor"
                                        newGroceryStoreTitle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newGroceryStoreTitle = __value, newGroceryStoreTitle));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "E:\Semester 2\Intro to Asp.net\WEB315-\PrabhjeetSinghGroceryApp\Pages\GroceryStore.razor"
                  AddGroceryStore

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(12, "Add Items");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n");
            __builder.OpenElement(14, "ul");
#nullable restore
#line 8 "E:\Semester 2\Intro to Asp.net\WEB315-\PrabhjeetSinghGroceryApp\Pages\GroceryStore.razor"
     foreach (var GroceryIsle in GroceryStoreList)
    {
         

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Semester 2\Intro to Asp.net\WEB315-\PrabhjeetSinghGroceryApp\Pages\GroceryStore.razor"
          if (!GroceryIsle.IsDone) 
        {
        

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "li");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "type", "checkbox");
            __builder.AddAttribute(18, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "E:\Semester 2\Intro to Asp.net\WEB315-\PrabhjeetSinghGroceryApp\Pages\GroceryStore.razor"
                                          GroceryIsle.IsDone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => GroceryIsle.IsDone = __value, GroceryIsle.IsDone));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "E:\Semester 2\Intro to Asp.net\WEB315-\PrabhjeetSinghGroceryApp\Pages\GroceryStore.razor"
                          GroceryIsle.Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => GroceryIsle.Title = __value, GroceryIsle.Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "div");
            __builder.AddContent(26, 
#nullable restore
#line 16 "E:\Semester 2\Intro to Asp.net\WEB315-\PrabhjeetSinghGroceryApp\Pages\GroceryStore.razor"
                  GroceryIsle.foodName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            \r\n            ");
            __builder.AddContent(28, 
#nullable restore
#line 18 "E:\Semester 2\Intro to Asp.net\WEB315-\PrabhjeetSinghGroceryApp\Pages\GroceryStore.razor"
             quantity

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "class", "btn btn-primary");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "E:\Semester 2\Intro to Asp.net\WEB315-\PrabhjeetSinghGroceryApp\Pages\GroceryStore.razor"
                                                      IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(33, "+");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "class", "btn btn-primary");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "E:\Semester 2\Intro to Asp.net\WEB315-\PrabhjeetSinghGroceryApp\Pages\GroceryStore.razor"
                                                      DecrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(38, "-");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 22 "E:\Semester 2\Intro to Asp.net\WEB315-\PrabhjeetSinghGroceryApp\Pages\GroceryStore.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "E:\Semester 2\Intro to Asp.net\WEB315-\PrabhjeetSinghGroceryApp\Pages\GroceryStore.razor"
           
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "E:\Semester 2\Intro to Asp.net\WEB315-\PrabhjeetSinghGroceryApp\Pages\GroceryStore.razor"
     foreach (var FoodItem in GroceryIsle)
    {
         

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "E:\Semester 2\Intro to Asp.net\WEB315-\PrabhjeetSinghGroceryApp\Pages\GroceryStore.razor"
          if (!FoodItem.IsDone) 
        {
        

#line default
#line hidden
#nullable disable
            __builder.OpenElement(39, "li");
            __builder.OpenElement(40, "input");
            __builder.AddAttribute(41, "type", "checkbox");
            __builder.AddAttribute(42, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "E:\Semester 2\Intro to Asp.net\WEB315-\PrabhjeetSinghGroceryApp\Pages\GroceryStore.razor"
                                          FoodItem.IsDone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FoodItem.IsDone = __value, FoodItem.IsDone));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "E:\Semester 2\Intro to Asp.net\WEB315-\PrabhjeetSinghGroceryApp\Pages\GroceryStore.razor"
                          FoodItem.Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FoodItem.Title = __value, FoodItem.Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.OpenElement(49, "div");
            __builder.AddContent(50, 
#nullable restore
#line 32 "E:\Semester 2\Intro to Asp.net\WEB315-\PrabhjeetSinghGroceryApp\Pages\GroceryStore.razor"
                  FoodItem.foodName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n            \r\n            ");
            __builder.AddContent(52, 
#nullable restore
#line 34 "E:\Semester 2\Intro to Asp.net\WEB315-\PrabhjeetSinghGroceryApp\Pages\GroceryStore.razor"
             quantity

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(53, "\r\n            ");
            __builder.OpenElement(54, "button");
            __builder.AddAttribute(55, "class", "btn btn-primary");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "E:\Semester 2\Intro to Asp.net\WEB315-\PrabhjeetSinghGroceryApp\Pages\GroceryStore.razor"
                                                      IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(57, "+");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n            ");
            __builder.OpenElement(59, "button");
            __builder.AddAttribute(60, "class", "btn btn-primary");
            __builder.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "E:\Semester 2\Intro to Asp.net\WEB315-\PrabhjeetSinghGroceryApp\Pages\GroceryStore.razor"
                                                      DecrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(62, "-");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "E:\Semester 2\Intro to Asp.net\WEB315-\PrabhjeetSinghGroceryApp\Pages\GroceryStore.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "E:\Semester 2\Intro to Asp.net\WEB315-\PrabhjeetSinghGroceryApp\Pages\GroceryStore.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "E:\Semester 2\Intro to Asp.net\WEB315-\PrabhjeetSinghGroceryApp\Pages\GroceryStore.razor"
       
        private List<GroceryIsle> GroceryStoreList = new List<GroceryIsle>{
            new GroceryIsle
        {
         Title = "bakery",
         IsDone = false,
         IsleNumber = 1,
         foodName = "cake, pastry",
         
            
       
        },
            new GroceryIsle
        {
         Title = "fruits",
         IsDone = false,
         IsleNumber = 2,
         foodName = "Apple, Banana",
         
        },
        new GroceryIsle
        {
         Title = "vegetables",
         IsDone = false,
         IsleNumber = 3,
         foodName = "ladyfinger, cabage",  
        },
        new GroceryIsle
        {
         Title = "Frozen Food",
         IsDone = false,
         IsleNumber = 4, 
         foodName = "fries, patty", 
        },
        };
            private int quantity ;

    private void IncrementCount()
    {
        quantity++;
    }
    private void DecrementCount()
    {
        quantity--;
    }
            private string newGroceryStoreTitle = "";
            private List<FoodItem> GroceryIsle = new ();
            private void AddGroceryStore()
        {
        GroceryIsle newItem;
        if (!string.IsNullOrWhiteSpace(newGroceryStoreTitle))
        {
            newItem = new GroceryIsle
            {
                Title = newGroceryStoreTitle,
                IsDone = false,
                foodName = "some default value",
                IsleNumber = 1,
            };
            GroceryStoreList.Add(newItem );
            
            
            newGroceryStoreTitle = ""; 
        }
    }
    
    private bool GroceryStoreIsDone(GroceryIsle GroceryStore)
    {
        return !GroceryStore.IsDone;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
