#pragma checksum "D:\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c43b04e0bcf4a16f5a03061abb6216fa82d0ef9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
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
#line 1 "D:\ApexRestaurant\ApexRestaurant.Mvc\Views\_ViewImports.cshtml"
using ApexRestaurant.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ApexRestaurant\ApexRestaurant.Mvc\Views\_ViewImports.cshtml"
using ApexRestaurant.Mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c43b04e0bcf4a16f5a03061abb6216fa82d0ef9", @"/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0912f6181b28aef2927cb27b810eb7cbedfabc68", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApexRestaurant.Mvc.Models.CustomerViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Index</h2>\r\n<p>\r\n    ");
#nullable restore
#line 8 "D:\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
Write(Html.ActionLink("Create New", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 13 "D:\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 16 "D:\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 19 "D:\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 22 "D:\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneRes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 25 "D:\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneMob));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 28 "D:\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.EnrollDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 31 "D:\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n    <th></th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 36 "D:\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
     foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "D:\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "D:\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "D:\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "D:\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PhoneRes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 51 "D:\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PhoneMob));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 54 "D:\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EnrollDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 57 "D:\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 60 "D:\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id=item.Customer_Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 61 "D:\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id=item.Customer_Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 62 "D:\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id=item.Customer_Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 65 "D:\ApexRestaurant\ApexRestaurant.Mvc\Views\Customer\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApexRestaurant.Mvc.Models.CustomerViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
