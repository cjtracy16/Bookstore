#pragma checksum "C:\Users\Conner Tracy\source\repos\Bookstore\Bookstore\Bookstore\Pages\Purchase.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea780bc945ed6fe9630d7027329423479560584b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Purchase), @"mvc.1.0.razor-page", @"/Pages/Purchase.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea780bc945ed6fe9630d7027329423479560584b", @"/Pages/Purchase.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Purchase : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h2>Your Cart</h2>

<table class=""table table-bordered table-striped"">

    <thead>
        <tr>
            <th>Book</th>
            <th>Quantity</th>
            <th>Cost</th>
            <th>Subtotal</th>
        </tr>
    </thead>

    <tbody>
");
#nullable restore
#line 20 "C:\Users\Conner Tracy\source\repos\Bookstore\Bookstore\Bookstore\Pages\Purchase.cshtml"
         foreach (var i in Model.cart.Items)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\Conner Tracy\source\repos\Bookstore\Bookstore\Bookstore\Pages\Purchase.cshtml"
               Write(i.Book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\Conner Tracy\source\repos\Bookstore\Bookstore\Bookstore\Pages\Purchase.cshtml"
               Write(i.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\Conner Tracy\source\repos\Bookstore\Bookstore\Bookstore\Pages\Purchase.cshtml"
               Write(i.Book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\Conner Tracy\source\repos\Bookstore\Bookstore\Bookstore\Pages\Purchase.cshtml"
                Write(i.Quantity * i.Book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 28 "C:\Users\Conner Tracy\source\repos\Bookstore\Bookstore\Bookstore\Pages\Purchase.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n\r\n    <tfoot>\r\n        <tr>\r\n            <td colspan=\"3\">Total:</td>\r\n            <td>");
#nullable restore
#line 34 "C:\Users\Conner Tracy\source\repos\Bookstore\Bookstore\Bookstore\Pages\Purchase.cshtml"
           Write(Model.cart.CalculateTotal().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </tfoot>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bookstore.Pages.PurchaseModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Bookstore.Pages.PurchaseModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Bookstore.Pages.PurchaseModel>)PageContext?.ViewData;
        public Bookstore.Pages.PurchaseModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
