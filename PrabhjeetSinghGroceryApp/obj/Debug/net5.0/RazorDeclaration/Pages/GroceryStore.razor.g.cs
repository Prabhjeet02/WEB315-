// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "E:\Semester 2\Intro to Asp.net\WEB315-\PrabhjeetSinghGroceryApp\Pages\GroceryStore.razor"
       
        private List<GroceryIsle> GroceryStoreList = new List<GroceryIsle>{
            new GroceryIsle
        {
         Title = "bakery",
         IsDone = false,
         IsleNumber = 1,
       
        },
            new GroceryIsle
        {
         Title = "fruits",
         IsDone = false,
         IsleNumber = 2,
         
        }
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
            private List<FoodItem> GroceryIsle = new(){
                
                };
            private void AddGroceryStore()
        {
        GroceryIsle newItem;
        if (!string.IsNullOrWhiteSpace(newGroceryStoreTitle))
        {
            newItem = new GroceryIsle
            {
                Title = newGroceryStoreTitle,
                IsDone = false,
                
            };
            GroceryStoreList.Add(newItem);
            
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
