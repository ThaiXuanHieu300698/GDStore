#pragma checksum "G:\Web\GDStore\src\GDStore.MVC\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d48fb788cf0207444988f6c225158997c4077bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
#line 2 "G:\Web\GDStore\src\GDStore.MVC\Views\_ViewImports.cshtml"
using GDStore.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\Web\GDStore\src\GDStore.MVC\Views\_ViewImports.cshtml"
using GDStore.MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\Web\GDStore\src\GDStore.MVC\Views\_ViewImports.cshtml"
using GDStore.Domain.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d48fb788cf0207444988f6c225158997c4077bb", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74c963f7eff9981e5d68544477c0ed8fcb0fd6c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "G:\Web\GDStore\src\GDStore.MVC\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""products-male"" style=""padding-top: 80px;"">
    <div class=""container"">
        <div class=""title"">Nam</div>
        <div class=""row mt-2"">
            <div class=""col-md-3 filter"">
                <div class=""filter-price mb-3"">
                    <div class=""card"">
                        <div class=""card-header"">Lọc theo Giá</div>
                        <div class=""card-body"">
                            <p><a");
            BeginWriteAttribute("href", " href=\"", 534, "\"", 541, 0);
            EndWriteAttribute();
            WriteLiteral(">Dưới 300.000₫</a></p>\r\n                            <p><a");
            BeginWriteAttribute("href", " href=\"", 599, "\"", 606, 0);
            EndWriteAttribute();
            WriteLiteral(">300.000₫ - 500.000₫</a></p>\r\n                            <p><a");
            BeginWriteAttribute("href", " href=\"", 670, "\"", 677, 0);
            EndWriteAttribute();
            WriteLiteral(">500.000₫ - 1.000.000₫</a></p>\r\n                            <p><a");
            BeginWriteAttribute("href", " href=\"", 743, "\"", 750, 0);
            EndWriteAttribute();
            WriteLiteral(@">Trên 1.000.000₫</a></p>
                        </div>
                    </div>
                </div>
                <div class=""filter-size mb-3"">
                    <div class=""card"">
                        <div class=""card-header"">Size</div>
                        <div class=""card-body"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 1089, "\"", 1096, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"mr-2\">37</a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1149, "\"", 1156, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"mr-2\">38</a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1209, "\"", 1216, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"mr-2\">39</a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1269, "\"", 1276, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"mr-2\">40</a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1329, "\"", 1336, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"mr-2\">41</a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1389, "\"", 1396, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""mr-2"">42</a>
                        </div>
                    </div>
                </div>
                <div class=""filter-brand mb-3"">
                    <div class=""card"">
                        <div class=""card-header"">Nhãn hiệu</div>
                        <div class=""card-body"">
                            <p><a");
            BeginWriteAttribute("href", " href=\"", 1740, "\"", 1747, 0);
            EndWriteAttribute();
            WriteLiteral(">Nike</a></p>\r\n                            <p><a");
            BeginWriteAttribute("href", " href=\"", 1796, "\"", 1803, 0);
            EndWriteAttribute();
            WriteLiteral(">Adidas</a></p>\r\n                            <p><a");
            BeginWriteAttribute("href", " href=\"", 1854, "\"", 1861, 0);
            EndWriteAttribute();
            WriteLiteral(">Puma</a></p>\r\n                            <p><a");
            BeginWriteAttribute("href", " href=\"", 1910, "\"", 1917, 0);
            EndWriteAttribute();
            WriteLiteral(@">Biti's</a></p>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-9"">
                <div class=""filter-categories"">
                    <div class=""row"">
                        <div class=""col-md-3 mb-3"">
                            <select");
            BeginWriteAttribute("name", " name=\"", 2251, "\"", 2258, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2259, "\"", 2264, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d48fb788cf0207444988f6c225158997c4077bb8116", async() => {
                WriteLiteral("Bán chạy nhất");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d48fb788cf0207444988f6c225158997c4077bb9314", async() => {
                WriteLiteral("Mới nhất");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d48fb788cf0207444988f6c225158997c4077bb10507", async() => {
                WriteLiteral("Cũ nhất");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d48fb788cf0207444988f6c225158997c4077bb11700", async() => {
                WriteLiteral("Giá: Tăng dần");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d48fb788cf0207444988f6c225158997c4077bb12899", async() => {
                WriteLiteral("Giá: Giảm dần");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </select>\r\n                        </div>\r\n                        <div class=\"col-md-9\">\r\n                            <div class=\"categories-child\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2856, "\"", 2863, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Giày thể thao</a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2942, "\"", 2949, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Giày tây</a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 3023, "\"", 3030, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Giày lười</a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 3105, "\"", 3112, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Giày boots</a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 3188, "\"", 3195, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary"">Dép</a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-md-4 col-4"">
                        <div class=""product"">
                            <label class=""badge badge-warning"">-50%</label><br>
                            <label class=""badge badge-danger"">Khuyến mãi</label>
                            <a href=""/Product/Detail"">
                                <img class=""thumbnail-img"" src=""/img/product/male/product-1.webp""");
            BeginWriteAttribute("alt", " alt=\"", 3798, "\"", 3804, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                            <hr>
                            <h1 class=""product-name""><a href=""/Product/Detail"">Tên sản phẩm</a></h1>
                            <div>
                                <span class=""price""><strong>790.000₫</strong></span>
                                <del class=""original-price float-right"">990.000₫</del>
                            </div>
                            <button class=""btn btn-success btn-addToCart w-100 mt-3"">Thêm vào giỏ hàng</button>
                        </div>
                    </div>
                    <div class=""col-md-4 col-4"">
                        <div class=""product"">
                            <label class=""badge badge-warning"">-50%</label><br>
                            <label class=""badge badge-danger"">Khuyến mãi</label>
                            <a href=""/Product/Detail"">
                                <img class=""thumbnail-img"" src=""/img/product/male/product-2.webp""");
            BeginWriteAttribute("alt", " alt=\"", 4809, "\"", 4815, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                            <hr>
                            <h1 class=""product-name""><a href=""/Product/Detail"">Tên sản phẩm</a></h1>
                            <div>
                                <span class=""price""><strong>790.000₫</strong></span>
                                <del class=""original-price float-right"">990.000₫</del>
                            </div>
                            <button class=""btn btn-success btn-addToCart w-100 mt-3"">Thêm vào giỏ hàng</button>
                        </div>
                    </div>
                    <div class=""col-md-4 col-4"">
                        <div class=""product"">
                            <label class=""badge badge-warning"">-50%</label><br>
                            <label class=""badge badge-danger"">Khuyến mãi</label>
                            <a href=""/Product/Detail"">
                                <img class=""thumbnail-img"" src=""/img/product/male/product-3.webp""");
            BeginWriteAttribute("alt", " alt=\"", 5820, "\"", 5826, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                            <hr>
                            <h1 class=""product-name""><a href=""/Product/Detail"">Tên sản phẩm</a></h1>
                            <div>
                                <span class=""price""><strong>790.000₫</strong></span>
                                <del class=""original-price float-right"">990.000₫</del>
                            </div>
                            <button class=""btn btn-success btn-addToCart w-100 mt-3"">Thêm vào giỏ hàng</button>
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-md-4 col-4"">
                        <div class=""product"">
                            <label class=""badge badge-warning"">-50%</label><br>
                            <label class=""badge badge-danger"">Khuyến mãi</label>
                            <a href=""/Product/Detail"">
                                <img class=""thumbnail-img""");
            WriteLiteral(" src=\"/img/product/male/product-1.webp\"");
            BeginWriteAttribute("alt", " alt=\"", 6890, "\"", 6896, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                            <hr>
                            <h1 class=""product-name""><a href=""/Product/Detail"">Tên sản phẩm</a></h1>
                            <div>
                                <span class=""price""><strong>790.000₫</strong></span>
                                <del class=""original-price float-right"">990.000₫</del>
                            </div>
                            <button class=""btn btn-success btn-addToCart w-100 mt-3"">Thêm vào giỏ hàng</button>
                        </div>
                    </div>
                    <div class=""col-md-4 col-4"">
                        <div class=""product"">
                            <label class=""badge badge-warning"">-50%</label><br>
                            <label class=""badge badge-danger"">Khuyến mãi</label>
                            <a href=""/Product/Detail"">
                                <img class=""thumbnail-img"" src=""/img/product/male/product-2.webp""");
            BeginWriteAttribute("alt", " alt=\"", 7901, "\"", 7907, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                            <hr>
                            <h1 class=""product-name""><a href=""/Product/Detail"">Tên sản phẩm</a></h1>
                            <div>
                                <span class=""price""><strong>790.000₫</strong></span>
                                <del class=""original-price float-right"">990.000₫</del>
                            </div>
                            <button class=""btn btn-success btn-addToCart w-100 mt-3"">Thêm vào giỏ hàng</button>
                        </div>
                    </div>
                    <div class=""col-md-4 col-4"">
                        <div class=""product"">
                            <label class=""badge badge-warning"">-50%</label><br>
                            <label class=""badge badge-danger"">Khuyến mãi</label>
                            <a href=""/Product/Detail"">
                                <img class=""thumbnail-img"" src=""/img/product/male/product-3.webp""");
            BeginWriteAttribute("alt", " alt=\"", 8912, "\"", 8918, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                            <hr>
                            <h1 class=""product-name""><a href=""/Product/Detail"">Tên sản phẩm</a></h1>
                            <div>
                                <span class=""price""><strong>790.000₫</strong></span>
                                <del class=""original-price float-right"">990.000₫</del>
                            </div>
                            <button class=""btn btn-success btn-addToCart w-100 mt-3"">Thêm vào giỏ hàng</button>
                        </div>
                    </div>
                </div>
                <div class=""text-center mt-3"">
                    <a");
            BeginWriteAttribute("href", " href=\"", 9604, "\"", 9611, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-see-more\">Xem thêm</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
