#pragma checksum "C:\Users\USER\source\repos\WebApplication3\WebApplication3\Areas\Admin\Views\AdminMessage\ComposeMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4003bf9dcb3b42c0b92cc89603b5eaabd49abe0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminMessage_ComposeMessage), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminMessage/ComposeMessage.cshtml")]
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
#nullable restore
#line 1 "C:\Users\USER\source\repos\WebApplication3\WebApplication3\Areas\Admin\Views\AdminMessage\ComposeMessage.cshtml"
using WebApplication3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4003bf9dcb3b42c0b92cc89603b5eaabd49abe0d", @"/Areas/Admin/Views/AdminMessage/ComposeMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b42bc885b832b8d506fd245e3a4848a9a000e765", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminMessage_ComposeMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SendMessageModelView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\USER\source\repos\WebApplication3\WebApplication3\Areas\Admin\Views\AdminMessage\ComposeMessage.cshtml"
  
    ViewData["Title"] = "ComposeMessage";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""row"">

    <div class=""col-lg-12 animated fadeInRight"">
        <div class=""mail-box-header"">
            <h2>
                Yeni Mesaj Oluştur
            </h2>
        </div>
        <div class=""mail-box"">
            <div class=""mail-body"">
");
#nullable restore
#line 21 "C:\Users\USER\source\repos\WebApplication3\WebApplication3\Areas\Admin\Views\AdminMessage\ComposeMessage.cshtml"
                 using (Html.BeginForm("ComposeMessage", "AdminMessage", FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"form-group row\">\r\n                        <label class=\"col-sm-1 col-form-label\">Alıcı:</label>\r\n                        <div class=\"col-sm-11\">");
#nullable restore
#line 25 "C:\Users\USER\source\repos\WebApplication3\WebApplication3\Areas\Admin\Views\AdminMessage\ComposeMessage.cshtml"
                                          Write(Html.TextBoxFor(x => x.Email, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"form-group row\">\r\n                        <label class=\"col-sm-1 col-form-label\">Konu:</label>\r\n                        <div class=\"col-sm-11\">");
#nullable restore
#line 29 "C:\Users\USER\source\repos\WebApplication3\WebApplication3\Areas\Admin\Views\AdminMessage\ComposeMessage.cshtml"
                                          Write(Html.TextBoxFor(x => x.Subject, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"form-group row\">\r\n                        <label class=\"col-sm-1 col-form-label\">Mesaj:</label>\r\n                        <div class=\"col-sm-11\">");
#nullable restore
#line 33 "C:\Users\USER\source\repos\WebApplication3\WebApplication3\Areas\Admin\Views\AdminMessage\ComposeMessage.cshtml"
                                          Write(Html.TextAreaFor(x => x.Detail, 14, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                    <br />\r\n");
            WriteLiteral(@"                    <div class=""col-12 row"">


                        <div class=""col-10"">
                            <button type=""submit"" class=""btn btn-sm btn-primary"">Gönder</button>

                        </div>

                        <div class=""mail-body text-right tooltip-demo"">

");
            WriteLiteral(@"                            <a href=""/Admin/AdminMessage/InBox/"" class=""btn btn-white btn-sm"" data-toggle=""tooltip"" data-placement=""top"" title=""Vazgeç""><i class=""fa fa-times text-danger""></i> Vazgeç</a>
                            <a href=""#"" class=""btn btn-white btn-sm"" data-toggle=""tooltip"" data-placement=""top"" title=""Taslaklara kaydet""><i class=""fa fa-pencil""></i> Taslak</a>
                        </div>
                    </div>
");
#nullable restore
#line 52 "C:\Users\USER\source\repos\WebApplication3\WebApplication3\Areas\Admin\Views\AdminMessage\ComposeMessage.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n                             ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SendMessageModelView> Html { get; private set; }
    }
}
#pragma warning restore 1591