#pragma checksum "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\Shared\Components\vcProductRelated\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ce9a00af07432312678bcd5c2f991cd440b9843"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_vcProductRelated_Default), @"mvc.1.0.view", @"/Views/Shared/Components/vcProductRelated/Default.cshtml")]
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
#line 1 "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\_ViewImports.cshtml"
using TauThuyenViet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\_ViewImports.cshtml"
using TauThuyenViet.ClassHelpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\_ViewImports.cshtml"
using TauThuyenViet.ViewComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\_ViewImports.cshtml"
using TauThuyenViet.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ce9a00af07432312678bcd5c2f991cd440b9843", @"/Views/Shared/Components/vcProductRelated/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f94b9d1567c7dc752329d99a99054216d4f9e207", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_vcProductRelated_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route", "ProductDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<aside>\r\n    <h2>\r\n        CÁC SẢN PHẨM LIÊN QUAN\r\n    </h2>\r\n    <div class=\"product-other-swiper\">\r\n        <div class=\"swiper-container\">\r\n            <div class=\"swiper-wrapper\">\r\n");
#nullable restore
#line 10 "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\Shared\Components\vcProductRelated\Default.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"swiper-slide\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ce9a00af07432312678bcd5c2f991cd440b98434863", async() => {
                WriteLiteral("\r\n                            <img class=\"img-fluid\"");
                BeginWriteAttribute("src", " src=\"", 557, "\"", 594, 1);
#nullable restore
#line 16 "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\Shared\Components\vcProductRelated\Default.cshtml"
WriteAttributeValue("", 563, item.ImageList.GetFirstImage(), 563, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <span>");
#nullable restore
#line 17 "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\Shared\Components\vcProductRelated\Default.cshtml"
                             Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\Shared\Components\vcProductRelated\Default.cshtml"
                             WriteLiteral(item.ProductID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\Shared\Components\vcProductRelated\Default.cshtml"
                                WriteLiteral(item.Title.ToUrlFormat());

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["title"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-title", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["title"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 20 "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\Shared\Components\vcProductRelated\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</aside>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public MyConfig myconfig { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
