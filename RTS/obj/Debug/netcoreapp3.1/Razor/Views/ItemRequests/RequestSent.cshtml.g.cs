#pragma checksum "C:\Users\DELL\RTS\RTS\Views\ItemRequests\RequestSent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f39dee5624358d45aeac5960a1826229c98e27ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ItemRequests_RequestSent), @"mvc.1.0.view", @"/Views/ItemRequests/RequestSent.cshtml")]
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
#line 1 "C:\Users\DELL\RTS\RTS\Views\_ViewImports.cshtml"
using RTS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\RTS\RTS\Views\_ViewImports.cshtml"
using RTS.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\DELL\RTS\RTS\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f39dee5624358d45aeac5960a1826229c98e27ca", @"/Views/ItemRequests/RequestSent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05abde3f223b0cc44267d0d2c2e5a4a2f843ec76", @"/Views/_ViewImports.cshtml")]
    public class Views_ItemRequests_RequestSent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RTS.DataAccess.Models.Transaction>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\DELL\RTS\RTS\Views\ItemRequests\RequestSent.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "_LayoutWithLeftMenu";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Requests Sent</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n");
            WriteLiteral("                To\r\n            </th>\r\n            <th>\r\n");
            WriteLiteral("                Item\r\n            </th>\r\n            <th>\r\n");
            WriteLiteral("                Status\r\n            </th>            \r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 29 "C:\Users\DELL\RTS\RTS\Views\ItemRequests\RequestSent.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 32 "C:\Users\DELL\RTS\RTS\Views\ItemRequests\RequestSent.cshtml"
           Write(Html.DisplayFor(modelItem => item.Employee.EmployeeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 35 "C:\Users\DELL\RTS\RTS\Views\ItemRequests\RequestSent.cshtml"
           Write(Html.DisplayFor(modelItem => item.ItemRequest.Item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "C:\Users\DELL\RTS\RTS\Views\ItemRequests\RequestSent.cshtml"
           Write(Html.DisplayFor(modelItem => item.Status.StatusType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>           \r\n");
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 46 "C:\Users\DELL\RTS\RTS\Views\ItemRequests\RequestSent.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RTS.DataAccess.Models.Transaction>> Html { get; private set; }
    }
}
#pragma warning restore 1591