#pragma checksum "C:\Users\USER\source\repos\WebApplication3\WebApplication3\Views\Shared\Components\BlogLast3Post\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f6a2ee63d8bba5a945824dff50ae25556dedef0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogLast3Post_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogLast3Post/Default.cshtml")]
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
#line 1 "C:\Users\USER\source\repos\WebApplication3\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\source\repos\WebApplication3\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\USER\source\repos\WebApplication3\WebApplication3\Views\Shared\Components\BlogLast3Post\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f6a2ee63d8bba5a945824dff50ae25556dedef0", @"/Views/Shared/Components/BlogLast3Post/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"463d1c12e8fc14b2589daa67feec3183fea97611", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_BlogLast3Post_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"tech-btm\">\r\n\t<h3>Son Gönderiler</h3>\r\n");
#nullable restore
#line 7 "C:\Users\USER\source\repos\WebApplication3\WebApplication3\Views\Shared\Components\BlogLast3Post\Default.cshtml"
     foreach(var item in Model)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"blog-grids row mb-3\">\r\n\t\t<div class=\"col-md-5 blog-grid-left\">\r\n\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 218, "\"", 255, 2);
            WriteAttributeValue("", 225, "/Blog/BlogReadAll/", 225, 18, true);
#nullable restore
#line 11 "C:\Users\USER\source\repos\WebApplication3\WebApplication3\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 243, item.BlogID, 243, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 267, "\"", 288, 1);
#nullable restore
#line 12 "C:\Users\USER\source\repos\WebApplication3\WebApplication3\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 273, item.BlogImage, 273, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 320, "\"", 326, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t</a>\r\n\t\t</div>\r\n\t\t\r\n\r\n\t\t<div class=\"col-md-7 blog-grid-right\">\r\n\r\n\t\t\t<h5>\r\n\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 415, "\"", 452, 2);
            WriteAttributeValue("", 422, "/Blog/BlogReadAll/", 422, 18, true);
#nullable restore
#line 20 "C:\Users\USER\source\repos\WebApplication3\WebApplication3\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 440, item.BlogID, 440, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 20 "C:\Users\USER\source\repos\WebApplication3\WebApplication3\Views\Shared\Components\BlogLast3Post\Default.cshtml"
                                                        Write(item.BlogContent.Substring(0, item.BlogContent.Substring(0, 50).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("... </a>\r\n\t\t\t</h5>\r\n\t\t\t<div class=\"sub-meta\">\r\n\t\t\t\t<span>\r\n\t\t\t\t\t\t<i class=\"far fa-clock\"></i>");
#nullable restore
#line 24 "C:\Users\USER\source\repos\WebApplication3\WebApplication3\Views\Shared\Components\BlogLast3Post\Default.cshtml"
                                                Write(((DateTime)item.CreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</span>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t\r\n\t</div>\r\n");
#nullable restore
#line 30 "C:\Users\USER\source\repos\WebApplication3\WebApplication3\Views\Shared\Components\BlogLast3Post\Default.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
