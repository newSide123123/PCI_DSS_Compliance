#pragma checksum "D:\HOKAIDO\KPI\5 SEM\.NET Web\ProductStorage\ProductStorage\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78d1e7b7b8ce0091feb38ca7d98a405201b30d7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\HOKAIDO\KPI\5 SEM\.NET Web\ProductStorage\ProductStorage\Views\_ViewImports.cshtml"
using ProductStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\HOKAIDO\KPI\5 SEM\.NET Web\ProductStorage\ProductStorage\Views\_ViewImports.cshtml"
using ProductStorage.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\HOKAIDO\KPI\5 SEM\.NET Web\ProductStorage\ProductStorage\Views\Home\Index.cshtml"
using ProductStorage.Service.ViewModels.CustomerProduct;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78d1e7b7b8ce0091feb38ca7d98a405201b30d7e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e043008d5657068634ed5ad34d1394de4f8c88c3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CustomerProductViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\HOKAIDO\KPI\5 SEM\.NET Web\ProductStorage\ProductStorage\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n\r\n<h1>Customers - products info:</h1>\r\n\r\n");
#nullable restore
#line 17 "D:\HOKAIDO\KPI\5 SEM\.NET Web\ProductStorage\ProductStorage\Views\Home\Index.cshtml"
 foreach(var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 19 "D:\HOKAIDO\KPI\5 SEM\.NET Web\ProductStorage\ProductStorage\Views\Home\Index.cshtml"
  Write(item.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" -- ");
#nullable restore
#line 19 "D:\HOKAIDO\KPI\5 SEM\.NET Web\ProductStorage\ProductStorage\Views\Home\Index.cshtml"
                        Write(item.CustomerPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral(" -- ");
#nullable restore
#line 19 "D:\HOKAIDO\KPI\5 SEM\.NET Web\ProductStorage\ProductStorage\Views\Home\Index.cshtml"
                                               Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" -- ");
#nullable restore
#line 19 "D:\HOKAIDO\KPI\5 SEM\.NET Web\ProductStorage\ProductStorage\Views\Home\Index.cshtml"
                                                                    Write(item.OrderedAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" -- ");
#nullable restore
#line 19 "D:\HOKAIDO\KPI\5 SEM\.NET Web\ProductStorage\ProductStorage\Views\Home\Index.cshtml"
                                                                                           Write(item.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 20 "D:\HOKAIDO\KPI\5 SEM\.NET Web\ProductStorage\ProductStorage\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CustomerProductViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591