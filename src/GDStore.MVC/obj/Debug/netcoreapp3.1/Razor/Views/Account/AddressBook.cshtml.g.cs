#pragma checksum "G:\Web\GDStore\src\GDStore.MVC\Views\Account\AddressBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6eb46232223f24fd4267ff7ae97ae97ee75e5d75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_AddressBook), @"mvc.1.0.view", @"/Views/Account/AddressBook.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6eb46232223f24fd4267ff7ae97ae97ee75e5d75", @"/Views/Account/AddressBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74c963f7eff9981e5d68544477c0ed8fcb0fd6c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_AddressBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "G:\Web\GDStore\src\GDStore.MVC\Views\Account\AddressBook.cshtml"
  
    ViewData["Title"] = "AddressBook";
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
                </ul>
            </nav>
            <div class=""content pl-4 flex-fill"">
                <h3>Sổ địa chỉ</h3>
      ");
            WriteLiteral(@"          <hr>
                <a href=""/Account/CreateAddressBook"" class=""btn btn-add-bookAddress""><i class=""fas fa-plus""></i> Thêm địa chỉ mới</a>
                <div class=""address-default d-flex mt-5 align-items-center justify-content-between"">
                    <div class=""address-info"">
                        <div class=""customer-name"">Thái Xuân Hiếu <span><i class=""fas fa-check-circle ml-3""></i>Địa chỉ mặc định</span></div>
                        <div class=""address""><span>Địa chỉ: </span>khối Tân phong, Phường Quỳnh Phương, Thị xã Hoàng Mai, Nghệ An</div>
                        <div class=""phone-number""><span>Số điện thoại: </span>0987145299</div>
                    </div>
                    <div class=""action-address"">
                        <a href=""#"">Chỉnh sửa</a>
                    </div>
                </div>
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
