#pragma checksum "/Users/frederickernest/Desktop/Epicodus/WebApp.Solution/WebApp/Views/Vendor/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "063a87e0f557b17e4f3b5f4ece6a32d55c869405"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendor_Show), @"mvc.1.0.view", @"/Views/Vendor/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vendor/Show.cshtml", typeof(AspNetCore.Views_Vendor_Show))]
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
#line 1 "/Users/frederickernest/Desktop/Epicodus/WebApp.Solution/WebApp/Views/Vendor/Show.cshtml"
using WebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"063a87e0f557b17e4f3b5f4ece6a32d55c869405", @"/Views/Vendor/Show.cshtml")]
    public class Views_Vendor_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 65, true);
            WriteLiteral("\n<h3>Here are all the Orders for the Selected Vendor:</h3>\n\n<ol>\n");
            EndContext();
#line 6 "/Users/frederickernest/Desktop/Epicodus/WebApp.Solution/WebApp/Views/Vendor/Show.cshtml"
 foreach (Order order in @Model["order"])
{

#line default
#line hidden
            BeginContext(131, 8, true);
            WriteLiteral("  <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 139, "\'", 189, 4);
            WriteAttributeValue("", 146, "/vendor/", 146, 8, true);
#line 8 "/Users/frederickernest/Desktop/Epicodus/WebApp.Solution/WebApp/Views/Vendor/Show.cshtml"
WriteAttributeValue("", 154, Model["vendor"].Id, 154, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 173, "/order/", 173, 7, true);
#line 8 "/Users/frederickernest/Desktop/Epicodus/WebApp.Solution/WebApp/Views/Vendor/Show.cshtml"
WriteAttributeValue("", 180, order.Id, 180, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(190, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(192, 11, false);
#line 8 "/Users/frederickernest/Desktop/Epicodus/WebApp.Solution/WebApp/Views/Vendor/Show.cshtml"
                                                       Write(order.Title);

#line default
#line hidden
            EndContext();
            BeginContext(203, 10, true);
            WriteLiteral("</a></li>\n");
            EndContext();
#line 9 "/Users/frederickernest/Desktop/Epicodus/WebApp.Solution/WebApp/Views/Vendor/Show.cshtml"
}

#line default
#line hidden
            BeginContext(215, 12, true);
            WriteLiteral("</ol>\n\n<p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 227, "\'", 271, 3);
            WriteAttributeValue("", 234, "/vendor/", 234, 8, true);
#line 12 "/Users/frederickernest/Desktop/Epicodus/WebApp.Solution/WebApp/Views/Vendor/Show.cshtml"
WriteAttributeValue("", 242, Model["vendor"].Id, 242, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 261, "/order/new", 261, 10, true);
            EndWriteAttribute();
            BeginContext(272, 118, true);
            WriteLiteral(">Add a new order</a></p>\n<p><a href=\'/vendor\'>Return to vendor list</a></p>\n<p><a href=\'/\'>Return to Main Page</a></p>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
