#pragma checksum "C:\Users\MELIKAA\source\repos\MelikaSuperMarket\EndPoint.Site\Views\Orders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "860d874c448bd30415f7a6c8f2208d4b46a1e13d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Index), @"mvc.1.0.view", @"/Views/Orders/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\MELIKAA\source\repos\MelikaSuperMarket\EndPoint.Site\Views\_ViewImports.cshtml"
using EndPoint.Site;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MELIKAA\source\repos\MelikaSuperMarket\EndPoint.Site\Views\_ViewImports.cshtml"
using EndPoint.Site.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\MELIKAA\source\repos\MelikaSuperMarket\EndPoint.Site\Views\Orders\Index.cshtml"
using MelikaSuperMarket.Application.Services.Orders.Queries.GetUserOrders;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"860d874c448bd30415f7a6c8f2208d4b46a1e13d", @"/Views/Orders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87685c89e84078b3e134b89a928accf3d0f04a39", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GetUserOrdersDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n");
#nullable restore
#line 4 "C:\Users\MELIKAA\source\repos\MelikaSuperMarket\EndPoint.Site\Views\Orders\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>سفارشات شما</h1>

<table style=""border:dashed"" class=""table table-responsive table-active table-bordered"">
    <thead>
        <tr style=""border:solid"">
            <th>شماره سفارش</th>
            <th>شماره فاکتور</th>
            <th>وضعیت سفارش</th>
            <th>محصولات در این سفارش</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 21 "C:\Users\MELIKAA\source\repos\MelikaSuperMarket\EndPoint.Site\Views\Orders\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr style=\"border:solid\">\r\n                <td>");
#nullable restore
#line 24 "C:\Users\MELIKAA\source\repos\MelikaSuperMarket\EndPoint.Site\Views\Orders\Index.cshtml"
               Write(item.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\MELIKAA\source\repos\MelikaSuperMarket\EndPoint.Site\Views\Orders\Index.cshtml"
               Write(item.OrderState);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\MELIKAA\source\repos\MelikaSuperMarket\EndPoint.Site\Views\Orders\Index.cshtml"
               Write(item.RequestPayId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\r\n                <td>\r\n                    <table>\r\n");
#nullable restore
#line 30 "C:\Users\MELIKAA\source\repos\MelikaSuperMarket\EndPoint.Site\Views\Orders\Index.cshtml"
                         foreach (var detail in item.OrderDetails)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                         <tr  style=\"border:outset\">\r\n                             <td> ");
#nullable restore
#line 33 "C:\Users\MELIKAA\source\repos\MelikaSuperMarket\EndPoint.Site\Views\Orders\Index.cshtml"
                             Write(detail.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                             <td> ");
#nullable restore
#line 34 "C:\Users\MELIKAA\source\repos\MelikaSuperMarket\EndPoint.Site\Views\Orders\Index.cshtml"
                             Write(detail.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                             <td> ");
#nullable restore
#line 35 "C:\Users\MELIKAA\source\repos\MelikaSuperMarket\EndPoint.Site\Views\Orders\Index.cshtml"
                             Write(detail.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                         </tr>\r\n");
#nullable restore
#line 37 "C:\Users\MELIKAA\source\repos\MelikaSuperMarket\EndPoint.Site\Views\Orders\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </table>\r\n\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 42 "C:\Users\MELIKAA\source\repos\MelikaSuperMarket\EndPoint.Site\Views\Orders\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GetUserOrdersDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591