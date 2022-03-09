#pragma checksum "C:\Users\Conner Tracy\source\repos\Bookstore\Bookstore\Bookstore\Pages\Admin\PurchaseTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21cdc49e3ac7bfaf732bd26ac0168ca2a76ba48f"
// <auto-generated/>
#pragma warning disable 1591
namespace Bookstore.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\Conner Tracy\source\repos\Bookstore\Bookstore\Bookstore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Conner Tracy\source\repos\Bookstore\Bookstore\Bookstore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Conner Tracy\source\repos\Bookstore\Bookstore\Bookstore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Conner Tracy\source\repos\Bookstore\Bookstore\Bookstore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Conner Tracy\source\repos\Bookstore\Bookstore\Bookstore\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Conner Tracy\source\repos\Bookstore\Bookstore\Bookstore\Pages\Admin\_Imports.razor"
using Bookstore.Models;

#line default
#line hidden
#nullable disable
    public partial class PurchaseTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-sm tables-striped table-bordered");
            __builder.AddMarkupContent(2, "\r\n\r\n    ");
            __builder.OpenElement(3, "thead");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenElement(5, "tr");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "th");
            __builder.AddAttribute(8, "colspan", "5");
            __builder.AddAttribute(9, "class", "text-center");
            __builder.AddContent(10, 
#nullable restore
#line 5 "C:\Users\Conner Tracy\source\repos\Bookstore\Bookstore\Bookstore\Pages\Admin\PurchaseTable.razor"
                                                 TableTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n    ");
            __builder.OpenElement(14, "tbody");
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 10 "C:\Users\Conner Tracy\source\repos\Bookstore\Bookstore\Bookstore\Pages\Admin\PurchaseTable.razor"
         if (Purchases?.Count() > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Conner Tracy\source\repos\Bookstore\Bookstore\Bookstore\Pages\Admin\PurchaseTable.razor"
             foreach (Purchase p in Purchases)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "                ");
            __builder.OpenElement(17, "tr");
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 15 "C:\Users\Conner Tracy\source\repos\Bookstore\Bookstore\Bookstore\Pages\Admin\PurchaseTable.razor"
                         p.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 16 "C:\Users\Conner Tracy\source\repos\Bookstore\Bookstore\Bookstore\Pages\Admin\PurchaseTable.razor"
                         p.Zip

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.AddMarkupContent(25, "<th>Book</th>\r\n                    ");
            __builder.AddMarkupContent(26, "<th>Quantity</th>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
#nullable restore
#line 21 "C:\Users\Conner Tracy\source\repos\Bookstore\Bookstore\Bookstore\Pages\Admin\PurchaseTable.razor"
                 foreach (CartLineItem cli in p.Lines)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(28, "                    ");
            __builder.OpenElement(29, "tr");
            __builder.AddMarkupContent(30, "\r\n                        <td colspan=\"2\"></td>\r\n                        ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 25 "C:\Users\Conner Tracy\source\repos\Bookstore\Bookstore\Bookstore\Pages\Admin\PurchaseTable.razor"
                             cli.Book.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                        ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 26 "C:\Users\Conner Tracy\source\repos\Bookstore\Bookstore\Bookstore\Pages\Admin\PurchaseTable.razor"
                             cli.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 28 "C:\Users\Conner Tracy\source\repos\Bookstore\Bookstore\Bookstore\Pages\Admin\PurchaseTable.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Conner Tracy\source\repos\Bookstore\Bookstore\Bookstore\Pages\Admin\PurchaseTable.razor"
                 
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Conner Tracy\source\repos\Bookstore\Bookstore\Bookstore\Pages\Admin\PurchaseTable.razor"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "            ");
            __builder.AddMarkupContent(39, "<tr>\r\n                <td colspan=\"5\" class=\"text-center\"></td>\r\n            </tr>\r\n");
#nullable restore
#line 36 "C:\Users\Conner Tracy\source\repos\Bookstore\Bookstore\Bookstore\Pages\Admin\PurchaseTable.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\Conner Tracy\source\repos\Bookstore\Bookstore\Bookstore\Pages\Admin\PurchaseTable.razor"
       

    [Parameter]
    public string TableTitle { get; set; } = "Purchases";

    [Parameter]
    public IEnumerable<Purchase> Purchases { get; set; }

    [Parameter]
    public string ButtonLabel { get; set; } = "Purchased";

    [Parameter]
    public EventCallback<int> PurchaseSelected { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
