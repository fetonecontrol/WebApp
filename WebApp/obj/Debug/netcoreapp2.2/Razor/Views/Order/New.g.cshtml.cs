#pragma checksum "/Users/frederickernest/Desktop/WebApp.Solution/WebApp/Views/Order/New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04af4730690325bc346f89cb3649c9a3fff02f43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_New), @"mvc.1.0.view", @"/Views/Order/New.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/New.cshtml", typeof(AspNetCore.Views_Order_New))]
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
#line 1 "/Users/frederickernest/Desktop/WebApp.Solution/WebApp/Views/Order/New.cshtml"
using WebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04af4730690325bc346f89cb3649c9a3fff02f43", @"/Views/Order/New.cshtml")]
    public class Views_Order_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 24, true);
            WriteLiteral("\n<h1>Add a new Order to ");
            EndContext();
            BeginContext(47, 10, false);
#line 3 "/Users/frederickernest/Desktop/WebApp.Solution/WebApp/Views/Order/New.cshtml"
                  Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(57, 12, true);
            WriteLiteral("</h1>\n\n<form");
            EndContext();
            BeginWriteAttribute("action", " action=\"", 69, "\"", 101, 3);
            WriteAttributeValue("", 78, "/vendor/", 78, 8, true);
#line 5 "/Users/frederickernest/Desktop/WebApp.Solution/WebApp/Views/Order/New.cshtml"
WriteAttributeValue("", 86, Model.Id, 86, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 95, "/order", 95, 6, true);
            EndWriteAttribute();
            BeginContext(102, 68, true);
            WriteLiteral(" method=\"post\">\n  <input id=\"vendorId\" name=\"vendorId\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 170, "\"", 187, 1);
#line 6 "/Users/frederickernest/Desktop/WebApp.Solution/WebApp/Views/Order/New.cshtml"
WriteAttributeValue("", 178, Model.Id, 178, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(188, 141, true);
            WriteLiteral(">\n  <label for=\"title\">Order Title</label>\n  <input id=\"title\" name=\"title\" type=\"text\">\n  <input id=\"vendorId\" name=\"vendorId\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 329, "\"", 346, 1);
#line 9 "/Users/frederickernest/Desktop/WebApp.Solution/WebApp/Views/Order/New.cshtml"
WriteAttributeValue("", 337, Model.Id, 337, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(347, 165, true);
            WriteLiteral(">\n  <label for=\"description\">Order Description</label>\n  <input id=\"description\" name=\"description\" type=\"text\">\n  <input id=\"vendorId\" name=\"vendorId\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 512, "\"", 529, 1);
#line 12 "/Users/frederickernest/Desktop/WebApp.Solution/WebApp/Views/Order/New.cshtml"
WriteAttributeValue("", 520, Model.Id, 520, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(530, 135, true);
            WriteLiteral(">\n  <label for=\"date\">Order Date</label>\n  <input id=\"date\" name=\"date\" type=\"text\">\n  <button type=\'submit\'>Add Order</button>\n</form>");
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
