#pragma checksum "C:\Users\Akila\source\repos\Practice\IdentityExample\Views\Home\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "659a17b4a9ae9c0c869831eb1b0bf1a1697570d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Register), @"mvc.1.0.view", @"/Views/Home/Register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"659a17b4a9ae9c0c869831eb1b0bf1a1697570d1", @"/Views/Home/Register.cshtml")]
    public class Views_Home_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Register Page</h1>\n\n<form action=\"/Home/Register\" method=\"post\">\n    <input type=\"text\" name=\"username\"");
            BeginWriteAttribute("value", " value=\"", 107, "\"", 115, 0);
            EndWriteAttribute();
            WriteLiteral(" />\n    <input type=\"text\" name=\"password\"");
            BeginWriteAttribute("value", " value=\"", 158, "\"", 166, 0);
            EndWriteAttribute();
            WriteLiteral(" />\n    <button type=\"submit\">Register</button>\n</form>\n");
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
