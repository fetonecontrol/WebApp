#pragma checksum "/Users/frederickernest/Desktop/WebApp.Solution/WebApp/Views/Order/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36b203ca2555abf551ef7f740d29cbee74857e57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Show), @"mvc.1.0.view", @"/Views/Order/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Show.cshtml", typeof(AspNetCore.Views_Order_Show))]
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
#line 1 "/Users/frederickernest/Desktop/WebApp.Solution/WebApp/Views/Order/Show.cshtml"
using WebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36b203ca2555abf551ef7f740d29cbee74857e57", @"/Views/Order/Show.cshtml")]
    public class Views_Order_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 32, true);
            WriteLiteral("\n<h1> Order Details: </h1>\n\n<h2>");
            EndContext();
            BeginContext(55, 20, false);
#line 5 "/Users/frederickernest/Desktop/WebApp.Solution/WebApp/Views/Order/Show.cshtml"
Write(Model["order"].Title);

#line default
#line hidden
            EndContext();
            BeginContext(75, 10, true);
            WriteLiteral("</h2>\n<h2>");
            EndContext();
            BeginContext(86, 32, false);
#line 6 "/Users/frederickernest/Desktop/WebApp.Solution/WebApp/Views/Order/Show.cshtml"
Write(Model["Description"].Description);

#line default
#line hidden
            EndContext();
            BeginContext(118, 10, true);
            WriteLiteral("</h2>\n<h2>");
            EndContext();
            BeginContext(129, 18, false);
#line 7 "/Users/frederickernest/Desktop/WebApp.Solution/WebApp/Views/Order/Show.cshtml"
Write(Model["Date"].Date);

#line default
#line hidden
            EndContext();
            BeginContext(147, 18, true);
            WriteLiteral("</h2>\n<h3>Vendor: ");
            EndContext();
            BeginContext(166, 20, false);
#line 8 "/Users/frederickernest/Desktop/WebApp.Solution/WebApp/Views/Order/Show.cshtml"
       Write(Model["vendor"].Name);

#line default
#line hidden
            EndContext();
            BeginContext(186, 9, true);
            WriteLiteral("</h3>\n\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 195, "\'", 239, 3);
            WriteAttributeValue("", 202, "/vendor/", 202, 8, true);
#line 10 "/Users/frederickernest/Desktop/WebApp.Solution/WebApp/Views/Order/Show.cshtml"
WriteAttributeValue("", 210, Model["vendor"].Id, 210, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 229, "/order/new", 229, 10, true);
            EndWriteAttribute();
            BeginContext(240, 61, true);
            WriteLiteral(">Add another order</a>\n<a href=\'/vendor\'>View all Vendors</a>");
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
