#pragma checksum "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be4bcf63c7f30dfd194d844efe04b7305e6703af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_KhachHangs_Delete), @"mvc.1.0.view", @"/Views/KhachHangs/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/KhachHangs/Delete.cshtml", typeof(AspNetCore.Views_KhachHangs_Delete))]
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
#line 1 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\_ViewImports.cshtml"
using WebOnline;

#line default
#line hidden
#line 2 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\_ViewImports.cshtml"
using WebOnline.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be4bcf63c7f30dfd194d844efe04b7305e6703af", @"/Views/KhachHangs/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a85df1676a2737903bf96fadd45101644718e46a", @"/Views/_ViewImports.cshtml")]
    public class Views_KhachHangs_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebOnline.Models.KhachHang>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Delete.cshtml"
  
    ViewData["Title"] = "| Xóa khách hàng";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(141, 43, true);
            WriteLiteral("<br />\r\n<br />\r\n\r\n<h3>Bạn có chắc chắn xóa ");
            EndContext();
            BeginContext(185, 37, false);
#line 10 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Delete.cshtml"
                    Write(Html.DisplayFor(model => model.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(222, 122, true);
            WriteLiteral(" ? </h3>\r\n<div>\r\n    <h4>Thông tin khách hàng</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(345, 40, false);
#line 16 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MaKh));

#line default
#line hidden
            EndContext();
            BeginContext(385, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(429, 36, false);
#line 19 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MaKh));

#line default
#line hidden
            EndContext();
            BeginContext(465, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(509, 43, false);
#line 22 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatKhau));

#line default
#line hidden
            EndContext();
            BeginContext(552, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(596, 39, false);
#line 25 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatKhau));

#line default
#line hidden
            EndContext();
            BeginContext(635, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(679, 41, false);
#line 28 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(720, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(764, 37, false);
#line 31 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(801, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(845, 44, false);
#line 34 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.GioiTinh));

#line default
#line hidden
            EndContext();
            BeginContext(889, 31, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n");
            EndContext();
#line 37 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Delete.cshtml"
             if (Model.GioiTinh == false)
            {

#line default
#line hidden
            BeginContext(978, 29, true);
            WriteLiteral("                <td>Nữ</td>\r\n");
            EndContext();
#line 40 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Delete.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1055, 30, true);
            WriteLiteral("                <td>Nam</td>\r\n");
            EndContext();
#line 44 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Delete.cshtml"
            }

#line default
#line hidden
            BeginContext(1100, 41, true);
            WriteLiteral("        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1142, 44, false);
#line 47 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NgaySinh));

#line default
#line hidden
            EndContext();
            BeginContext(1186, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1230, 40, false);
#line 50 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NgaySinh));

#line default
#line hidden
            EndContext();
            BeginContext(1270, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1314, 42, false);
#line 53 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(1356, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1400, 38, false);
#line 56 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(1438, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1482, 45, false);
#line 59 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DienThoai));

#line default
#line hidden
            EndContext();
            BeginContext(1527, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1571, 41, false);
#line 62 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DienThoai));

#line default
#line hidden
            EndContext();
            BeginContext(1612, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1656, 41, false);
#line 65 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1697, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1741, 37, false);
#line 68 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1778, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1822, 43, false);
#line 71 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.HieuLuc));

#line default
#line hidden
            EndContext();
            BeginContext(1865, 31, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n");
            EndContext();
#line 74 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Delete.cshtml"
             if (Model.HieuLuc == true)
            {

#line default
#line hidden
            BeginContext(1952, 39, true);
            WriteLiteral("                <td>Còn hiệu lực</td>\r\n");
            EndContext();
#line 77 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Delete.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(2039, 39, true);
            WriteLiteral("                <td>Hết hiệu lực</td>\r\n");
            EndContext();
#line 81 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Delete.cshtml"
            }

#line default
#line hidden
            BeginContext(2093, 32, true);
            WriteLiteral("        </dd>\r\n    </dl>\r\n\r\n    ");
            EndContext();
            BeginContext(2125, 213, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a0290ff9d134b739b82ca61445f173c", async() => {
                BeginContext(2151, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2161, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "be00166a8bbb49a9adb8a44e09f21e6d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 86 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MaKh);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2199, 93, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Xóa\" class=\"btn btn-default\" /> <br /> <br />\r\n        ");
                EndContext();
                BeginContext(2292, 33, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31b58f5e1c9d43798dbe57be251bf1a3", async() => {
                    BeginContext(2314, 7, true);
                    WriteLiteral("Quay về");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2325, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2338, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebOnline.Models.KhachHang> Html { get; private set; }
    }
}
#pragma warning restore 1591
