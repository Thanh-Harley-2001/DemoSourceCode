#pragma checksum "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\Product\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d65ed52f89db29f332e454f66a01aa9b20a3b89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Detail), @"mvc.1.0.view", @"/Views/Product/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d65ed52f89db29f332e454f66a01aa9b20a3b89", @"/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f94b9d1567c7dc752329d99a99054216d4f9e207", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    #nullable disable
    {
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
        private global::AspNetCore.Views_Product_Detail.__Generated__vcProductRelatedViewComponentTagHelper __vcProductRelatedViewComponentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<main>\r\n    <section id=\"product-detail\">\r\n        <aside class=\"avatar\">\r\n            <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 127, "\"", 146, 1);
#nullable restore
#line 6 "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\Product\Detail.cshtml"
WriteAttributeValue("", 133, Model.Avatar, 133, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </aside>\r\n        <aside class=\"info\">\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-12 col-md-6\">\r\n                        <h1>\r\n                            ");
#nullable restore
#line 13 "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\Product\Detail.cshtml"
                       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </h1>\r\n                        \r\n                        <div>\r\n                            ");
#nullable restore
#line 17 "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\Product\Detail.cshtml"
                       Write(Html.Raw(Model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""col-12 col-md-6"">
                        <div class=""product-imagelist-swiper"">
                            <div class=""swiper-container"">
                                <div class=""swiper-wrapper"">
");
#nullable restore
#line 24 "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\Product\Detail.cshtml"
                                     foreach (var item in Model.ImageList.Split('\n', StringSplitOptions.RemoveEmptyEntries))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"swiper-slide\">\r\n                                            <a href=\"product-detail.html\">\r\n                                                <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 1214, "\"", 1225, 1);
#nullable restore
#line 28 "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\Product\Detail.cshtml"
WriteAttributeValue("", 1220, item, 1220, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                            </a>\r\n                                        </div>\r\n");
#nullable restore
#line 31 "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\Product\Detail.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </div>
                                <div class=""swiper-pagination""></div>
                                <div class=""swiper-button-prev""></div>
                                <div class=""swiper-button-next""></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </aside>

        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:vc-product-related", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9d65ed52f89db29f332e454f66a01aa9b20a3b897496", async() => {
            }
            );
            __vcProductRelatedViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Product_Detail.__Generated__vcProductRelatedViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__vcProductRelatedViewComponentTagHelper);
#nullable restore
#line 43 "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\Product\Detail.cshtml"
__vcProductRelatedViewComponentTagHelper.categoryID = Model.ProductCategoryID.Value;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("category-id", __vcProductRelatedViewComponentTagHelper.categoryID, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 43 "E:\KhoaLapTrinhThayHieu\ProjectTauThuyenViet2021\TauThuyenVietMVC-With-API\TauThuyenViet\TauThuyenViet.MVC\Views\Product\Detail.cshtml"
__vcProductRelatedViewComponentTagHelper.ID = Model.ProductID;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("id", __vcProductRelatedViewComponentTagHelper.ID, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </section>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; } = default!;
        #nullable disable
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:vc-product-related")]
        public class __Generated__vcProductRelatedViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__vcProductRelatedViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public System.Int32 categoryID { get; set; }
            public System.Int32 ID { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("vcProductRelated", ProcessInvokeAsyncArgs(__context));
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
            private Dictionary<string, object> ProcessInvokeAsyncArgs(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context)
            {
                Dictionary<string, object> args = new Dictionary<string, object>();
                if (__context.AllAttributes.ContainsName("category-id"))
                {
                    args[nameof(categoryID)] = categoryID;
                }
                if (__context.AllAttributes.ContainsName("id"))
                {
                    args[nameof(ID)] = ID;
                }
                return args;
            }
        }
    }
}
#pragma warning restore 1591
