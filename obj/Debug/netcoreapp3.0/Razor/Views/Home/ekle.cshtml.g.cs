#pragma checksum "c:\Users\Coder\FirstProject\Views\Home\ekle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff224d15f99ca646cb9145581298b9e81e6694bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ekle), @"mvc.1.0.view", @"/Views/Home/ekle.cshtml")]
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
#line 1 "c:\Users\Coder\FirstProject\Views\_ViewImports.cshtml"
using FirstProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\Coder\FirstProject\Views\_ViewImports.cshtml"
using FirstProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff224d15f99ca646cb9145581298b9e81e6694bc", @"/Views/Home/ekle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfa503ef3de3887ad277480ed4d6261c659b6922", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ekle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FirstProject.Models.ogrenciler>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "c:\Users\Coder\FirstProject\Views\Home\ekle.cshtml"
  
    ViewData["Title"] = "Kayıt Ekle";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "c:\Users\Coder\FirstProject\Views\Home\ekle.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\Coder\FirstProject\Views\Home\ekle.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <h4>Yeni Kayıt</h4>\r\n        <hr />\r\n        ");
#nullable restore
#line 13 "c:\Users\Coder\FirstProject\Views\Home\ekle.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <label class=\"control-label col-md-2\">Ad</label>\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 17 "c:\Users\Coder\FirstProject\Views\Home\ekle.cshtml"
           Write(Html.EditorFor(model => model.ad, new { htmlAttributes = new { @class = "form-control col-md-5" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <label class=\"control-label col-md-2\">Soyad</label>\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 21 "c:\Users\Coder\FirstProject\Views\Home\ekle.cshtml"
           Write(Html.EditorFor(model => model.soyad, new { htmlAttributes = new { @class = "form-control col-md-5" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <label class=\"control-label col-md-2\">No</label>\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 25 "c:\Users\Coder\FirstProject\Views\Home\ekle.cshtml"
           Write(Html.EditorFor(model => model.no, new { htmlAttributes = new { @class = "form-control col-md-5" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
            
        </div>
        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <input type=""submit"" value=""Oluştur"" class=""btn btn-default"" />
            </div>
        </div>
    </div>
");
#nullable restore
#line 35 "c:\Users\Coder\FirstProject\Views\Home\ekle.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 38 "c:\Users\Coder\FirstProject\Views\Home\ekle.cshtml"
Write(Html.ActionLink("Geri Dön", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FirstProject.Models.ogrenciler> Html { get; private set; }
    }
}
#pragma warning restore 1591
