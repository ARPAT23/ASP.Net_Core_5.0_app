#pragma checksum "C:\Users\USER\source\repos\WebApplication3\WebApplication3\Areas\Admin\Views\Category\UpdateCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12d782523efcc22edcef281353ab72e12a456a99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_UpdateCategory), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/UpdateCategory.cshtml")]
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
#line 1 "C:\Users\USER\source\repos\WebApplication3\WebApplication3\Areas\Admin\Views\_ViewImports.cshtml"
using WebApplication3.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\source\repos\WebApplication3\WebApplication3\Areas\Admin\Views\_ViewImports.cshtml"
using WebApplication3.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12d782523efcc22edcef281353ab72e12a456a99", @"/Areas/Admin/Views/Category/UpdateCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b42bc885b832b8d506fd245e3a4848a9a000e765", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Category_UpdateCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\USER\source\repos\WebApplication3\WebApplication3\Areas\Admin\Views\Category\UpdateCategory.cshtml"
  
    ViewData["Title"] = "UpdateCategory";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Kategoei Güncelleme</h1>\r\n\r\n\r\n");
#nullable restore
#line 10 "C:\Users\USER\source\repos\WebApplication3\WebApplication3\Areas\Admin\Views\Category\UpdateCategory.cshtml"
 using (Html.BeginForm("UpdateCategory", "Category", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\USER\source\repos\WebApplication3\WebApplication3\Areas\Admin\Views\Category\UpdateCategory.cshtml"
Write(Html.HiddenFor(x => x.CategoryID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\USER\source\repos\WebApplication3\WebApplication3\Areas\Admin\Views\Category\UpdateCategory.cshtml"
Write(Html.Label("Kategori Adı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\USER\source\repos\WebApplication3\WebApplication3\Areas\Admin\Views\Category\UpdateCategory.cshtml"
Write(Html.TextBoxFor(x => x.CategoryName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 18 "C:\Users\USER\source\repos\WebApplication3\WebApplication3\Areas\Admin\Views\Category\UpdateCategory.cshtml"
Write(Html.Label("Kategori açıklama alanı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\USER\source\repos\WebApplication3\WebApplication3\Areas\Admin\Views\Category\UpdateCategory.cshtml"
Write(Html.TextBoxFor(x => x.CategoryDescription, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <button class=\"btn btn-outline-success\">Güncelle</button>\r\n");
#nullable restore
#line 25 "C:\Users\USER\source\repos\WebApplication3\WebApplication3\Areas\Admin\Views\Category\UpdateCategory.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("﻿\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
