#pragma checksum "D:\osele\Documents\code\bc_awareness_website\bc_awareness\Views\Questions\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2d5765505164f306fd39b797207f1da19b3aeab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Questions_Index), @"mvc.1.0.view", @"/Views/Questions/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2d5765505164f306fd39b797207f1da19b3aeab", @"/Views/Questions/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"926af9b8749e9ba29546a92066c12a0c63ea894f", @"/Views/_ViewImports.cshtml")]
    public class Views_Questions_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<bc_awareness.Models.QuestionViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\osele\Documents\code\bc_awareness_website\bc_awareness\Views\Questions\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"  text-xl-center align-middle\">\r\n    <h1 class=\"display-1\"> ");
#nullable restore
#line 7 "D:\osele\Documents\code\bc_awareness_website\bc_awareness\Views\Questions\Index.cshtml"
                      Write(Model.Question.Question);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 8 "D:\osele\Documents\code\bc_awareness_website\bc_awareness\Views\Questions\Index.cshtml"
     if (Model.Question.Source == "True or False")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <br />
        <a class=""btn btn-outline-primary btn-lg btn-block"" href=""/validate?userAnswer=TRUE"" role=""button"">  True  </a> <br />
        <a class=""btn btn-outline-primary btn-lg btn-block"" href=""/validate?userAnswer=FALSE"" role=""button"">  False  </a>
");
#nullable restore
#line 13 "D:\osele\Documents\code\bc_awareness_website\bc_awareness\Views\Questions\Index.cshtml"

    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 18 "D:\osele\Documents\code\bc_awareness_website\bc_awareness\Views\Questions\Index.cshtml"
         foreach (var item in Model.ShuffledAnswerOptions)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a class=\"btn btn-outline-primary btn-lg btn-block\"");
            BeginWriteAttribute("href", " href=\"", 694, "\"", 727, 2);
            WriteAttributeValue("", 701, "/validate?userAnswer=", 701, 21, true);
#nullable restore
#line 20 "D:\osele\Documents\code\bc_awareness_website\bc_awareness\Views\Questions\Index.cshtml"
WriteAttributeValue("", 722, item, 722, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\"> ");
#nullable restore
#line 20 "D:\osele\Documents\code\bc_awareness_website\bc_awareness\Views\Questions\Index.cshtml"
                                                                                                            Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a><br />\r\n");
#nullable restore
#line 21 "D:\osele\Documents\code\bc_awareness_website\bc_awareness\Views\Questions\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\osele\Documents\code\bc_awareness_website\bc_awareness\Views\Questions\Index.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<bc_awareness.Models.QuestionViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
