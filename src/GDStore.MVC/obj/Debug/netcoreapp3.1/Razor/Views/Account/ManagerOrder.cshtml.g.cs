#pragma checksum "G:\Web\GDStore\src\GDStore.MVC\Views\Account\ManagerOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a72a9ced71621b898e3e6908a38816162dada26b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ManagerOrder), @"mvc.1.0.view", @"/Views/Account/ManagerOrder.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a72a9ced71621b898e3e6908a38816162dada26b", @"/Views/Account/ManagerOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74c963f7eff9981e5d68544477c0ed8fcb0fd6c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ManagerOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "G:\Web\GDStore\src\GDStore.MVC\Views\Account\ManagerOrder.cshtml"
  
    ViewData["Title"] = "ManagerOrder";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""breadcrumb-rg"">
    <div class=""container p-0"">
        <nav aria-label=""breadcrumb"">
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item""><a href=""#""><i class=""fas fa-home""></i> Trang chủ</a></li>
                <li class=""breadcrumb-item""><a href=""#"">Tài khoản</a></li>
                <li class=""breadcrumb-item active"" aria-current=""page"">Đơn hàng của tôi</li>
            </ol>
        </nav>
    </div>
</div>
<section class=""your-account mt-4 mb-4"">
    <div class=""container"">
        <div class=""d-flex"">
            <nav class=""navbar"">
                <ul class=""navbar-nav"">
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Account/ManagerAccount""><i class=""fa fa-user""></i> Thông tin tài khoản</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Account/ManagerOrder""><i class=""fas fa-clipboard""></i> Quản lý đơn hàng</a>
           ");
            WriteLiteral(@"         </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Account/AddressBook""><i class=""fa fa-map-marker""></i> Sổ địa chỉ</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#""><i class=""fas fa-bell""></i> Thông báo</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#""><i class=""fas fa-eye""></i> Sản phẩm đã xem</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#""><i class=""fas fa-heart""></i> Sản phẩm yêu thích</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#""><i class=""fas fa-question""></i> Hỏi đáp</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#""><i class=""fas fa-sign-out-alt""></i> Đăng");
            WriteLiteral(@" xuất</a>
                    </li>
                </ul>
            </nav>
            <div class=""content pl-4 flex-fill"">
                <h3>Đơn hàng của tôi</h3>
                <hr>
                <table class=""table table-borderless"">
                    <thead>
                        <tr>
                            <th>Mã đơn hàng</th>
                            <th>Ngày mua</th>
                            <th>Sản phẩm</th>
                            <th>Tổng tiền</th>
                            <th>Trạng thái đơn hàng</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>1111</td>
                            <td>03/11/2020</td>
                            <td>
                                <div style=""width: 100px; display: inline-block;"">
                                    <a");
            BeginWriteAttribute("href", " href=\"", 3074, "\"", 3081, 0);
            EndWriteAttribute();
            WriteLiteral("><img src=\"/img/product/male/product-1.webp\"");
            BeginWriteAttribute("alt", " alt=\"", 3126, "\"", 3132, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"w-100\"></a>\r\n                                </div>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 3228, "\"", 3235, 0);
            EndWriteAttribute();
            WriteLiteral(@">Giày Bitis A</a>
                            </td>
                            <td>500.000₫</td>
                            <td>Đang giao hàng</td>
                        </tr>
                        <tr>
                            <td>1112</td>
                            <td>03/11/2020</td>
                            <td>
                                <div style=""width: 100px; display: inline-block;"">
                                    <a");
            BeginWriteAttribute("href", " href=\"", 3699, "\"", 3706, 0);
            EndWriteAttribute();
            WriteLiteral("><img src=\"/img/product/male/product-3.webp\"");
            BeginWriteAttribute("alt", " alt=\"", 3751, "\"", 3757, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"w-100\"></a>\r\n                                </div>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 3853, "\"", 3860, 0);
            EndWriteAttribute();
            WriteLiteral(@">Giày Bitis B</a>
                            </td>
                            <td>500.000₫</td>
                            <td>Đã hủy</td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</section>

");
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