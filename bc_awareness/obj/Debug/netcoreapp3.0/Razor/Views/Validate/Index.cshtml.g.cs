#pragma checksum "D:\osele\Documents\code\bc_awareness_website\bc_awareness\Views\Validate\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc6b3efff885de5651fdb650ca72f98ea038fc05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Validate_Index), @"mvc.1.0.view", @"/Views/Validate/Index.cshtml")]
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
#line 1 "D:\osele\Documents\code\bc_awareness_website\bc_awareness\Views\_ViewImports.cshtml"
using bc_awareness;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\osele\Documents\code\bc_awareness_website\bc_awareness\Views\_ViewImports.cshtml"
using bc_awareness.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc6b3efff885de5651fdb650ca72f98ea038fc05", @"/Views/Validate/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"926af9b8749e9ba29546a92066c12a0c63ea894f", @"/Views/_ViewImports.cshtml")]
    public class Views_Validate_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\osele\Documents\code\bc_awareness_website\bc_awareness\Views\Validate\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n");
#nullable restore
#line 7 "D:\osele\Documents\code\bc_awareness_website\bc_awareness\Views\Validate\Index.cshtml"
 if (ViewBag.result == true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>correct</p>\r\n");
#nullable restore
#line 10 "D:\osele\Documents\code\bc_awareness_website\bc_awareness\Views\Validate\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>wrong</p>\r\n");
#nullable restore
#line 14 "D:\osele\Documents\code\bc_awareness_website\bc_awareness\Views\Validate\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
