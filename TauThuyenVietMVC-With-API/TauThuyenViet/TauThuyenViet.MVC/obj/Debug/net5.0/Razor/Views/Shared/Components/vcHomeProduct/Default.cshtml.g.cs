#pragma checksum "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\Shared\Components\vcHomeProduct\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c24f7b88982aad2d5092c8d578b8c050ed3e428"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_vcHomeProduct_Default), @"mvc.1.0.view", @"/Views/Shared/Components/vcHomeProduct/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c24f7b88982aad2d5092c8d578b8c050ed3e428", @"/Views/Shared/Components/vcHomeProduct/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f94b9d1567c7dc752329d99a99054216d4f9e207", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_vcHomeProduct_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductMainCategory>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route", "ProductList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-cid", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route", "ProductDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<section id=\"product-home\">\r\n");
#nullable restore
#line 4 "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\Shared\Components\vcHomeProduct\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"wrapper\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c24f7b88982aad2d5092c8d578b8c050ed3e4285582", async() => {
                WriteLiteral("\r\n                <img class=\"img-fluid\"");
                BeginWriteAttribute("src", " src=\"", 433, "\"", 451, 1);
#nullable restore
#line 11 "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\Shared\Components\vcHomeProduct\Default.cshtml"
WriteAttributeValue("", 439, item.Avatar, 439, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <img class=\"overlay\"");
                BeginWriteAttribute("src", " src=\"", 493, "\"", 510, 1);
#nullable restore
#line 12 "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\Shared\Components\vcHomeProduct\Default.cshtml"
WriteAttributeValue("", 499, item.Thumb, 499, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-mid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 8 "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\Shared\Components\vcHomeProduct\Default.cshtml"
                                 WriteLiteral(item.ProductMainCategoryID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-mid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-cid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cid"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 10 "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\Shared\Components\vcHomeProduct\Default.cshtml"
                                   WriteLiteral(item.Title.ToUrlFormat());

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["title"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-title", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["title"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            <div class=\"full\">\r\n                <!-- Slider main container -->\r\n                <div class=\"swiper-container\">\r\n                    <!-- Additional required wrapper -->\r\n                    <div class=\"swiper-wrapper\">\r\n");
#nullable restore
#line 20 "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\Shared\Components\vcHomeProduct\Default.cshtml"
                         foreach (var cat in item.ProductCategories)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\Shared\Components\vcHomeProduct\Default.cshtml"
                             foreach (var product in cat.Products)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"swiper-slide\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c24f7b88982aad2d5092c8d578b8c050ed3e42811314", async() => {
                WriteLiteral("\r\n                                        <img");
                BeginWriteAttribute("src", " src=\"", 1300, "\"", 1340, 1);
#nullable restore
#line 28 "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\Shared\Components\vcHomeProduct\Default.cshtml"
WriteAttributeValue("", 1306, product.ImageList.GetFirstImage(), 1306, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                        <span>");
#nullable restore
#line 29 "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\Shared\Components\vcHomeProduct\Default.cshtml"
                                         Write(product.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                    ");
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
#line 25 "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\Shared\Components\vcHomeProduct\Default.cshtml"
                                         WriteLiteral(product.ProductID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\Shared\Components\vcHomeProduct\Default.cshtml"
                                            WriteLiteral(product.Title.ToUrlFormat());

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["title"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-title", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["title"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 32 "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\Shared\Components\vcHomeProduct\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\Shared\Components\vcHomeProduct\Default.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                    <!-- If we need pagination -->
                    <div class=""swiper-pagination""></div>
                </div>
            </div>

            <div class=""thumb"">
                <!-- Slider main container -->
                <div class=""swiper-container"">
                    <!-- Additional required wrapper -->
                    <div class=""swiper-wrapper"">
");
#nullable restore
#line 45 "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\Shared\Components\vcHomeProduct\Default.cshtml"
                         foreach (var cat in item.ProductCategories)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\Shared\Components\vcHomeProduct\Default.cshtml"
                             foreach (var product in cat.Products)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"swiper-slide\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c24f7b88982aad2d5092c8d578b8c050ed3e42817237", async() => {
                WriteLiteral("\r\n                                        <img");
                BeginWriteAttribute("src", " src=\"", 2505, "\"", 2545, 1);
#nullable restore
#line 53 "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\Shared\Components\vcHomeProduct\Default.cshtml"
WriteAttributeValue("", 2511, product.ImageList.GetFirstImage(), 2511, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    ");
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
#line 50 "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\Shared\Components\vcHomeProduct\Default.cshtml"
                                         WriteLiteral(product.ProductID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\Shared\Components\vcHomeProduct\Default.cshtml"
                                            WriteLiteral(product.Title.ToUrlFormat());

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["title"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-title", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["title"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 56 "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\Shared\Components\vcHomeProduct\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\Shared\Components\vcHomeProduct\Default.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>

                    <!-- If we need navigation buttons -->
                    <div class=""swiper-button-prev""></div>
                    <div class=""swiper-button-next""></div>
                </div>
            </div>
        </div>
");
#nullable restore
#line 66 "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\Shared\Components\vcHomeProduct\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProductMainCategory>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591