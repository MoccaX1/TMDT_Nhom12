#pragma checksum "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03ddf3583ef3fca0416a528042a724d79ed44bc5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_KhachHangs_Index), @"mvc.1.0.view", @"/Views/KhachHangs/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/KhachHangs/Index.cshtml", typeof(AspNetCore.Views_KhachHangs_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03ddf3583ef3fca0416a528042a724d79ed44bc5", @"/Views/KhachHangs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a85df1676a2737903bf96fadd45101644718e46a", @"/Views/_ViewImports.cshtml")]
    public class Views_KhachHangs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebOnline.Models.KhachHang>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Index.cshtml"
  
    ViewData["Title"] = "| Danh sách khách hàng";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(160, 232, true);
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-lg-12\">\r\n        <h1 class=\"page-header\">Khách hàng</h1>\r\n    </div>\r\n    <!-- /.col-lg-12 -->\r\n</div>\r\n<!-- /.row -->\r\n<div class=\"row\">\r\n    <div class=\"col-lg-12\">\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(392, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "242b30c7b9184e20bf6575112debafbd", async() => {
                BeginContext(415, 8, true);
                WriteLiteral("Thêm mới");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(427, 431, true);
            WriteLiteral(@"
        </p>
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                Danh sách
            </div>
            <!-- /.panel-heading -->
            <div class=""panel-body"">
                <table width=""100%"" class=""table table-striped table-bordered table-hover"" id=""dataTables-example"">
                    <thead>
                        <tr>
                            <th>");
            EndContext();
            BeginContext(859, 40, false);
#line 28 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.MaKh));

#line default
#line hidden
            EndContext();
            BeginContext(899, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(939, 43, false);
#line 29 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.MatKhau));

#line default
#line hidden
            EndContext();
            BeginContext(982, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1022, 41, false);
#line 30 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(1063, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1103, 44, false);
#line 31 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.GioiTinh));

#line default
#line hidden
            EndContext();
            BeginContext(1147, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1187, 44, false);
#line 32 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.NgaySinh));

#line default
#line hidden
            EndContext();
            BeginContext(1231, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1271, 42, false);
#line 33 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(1313, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1353, 45, false);
#line 34 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.DienThoai));

#line default
#line hidden
            EndContext();
            BeginContext(1398, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1438, 41, false);
#line 35 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1479, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1519, 43, false);
#line 36 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.HieuLuc));

#line default
#line hidden
            EndContext();
            BeginContext(1562, 175, true);
            WriteLiteral("</th>\r\n                            <th></th>\r\n                            <th></th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 42 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1818, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1881, 39, false);
#line 45 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.MaKh));

#line default
#line hidden
            EndContext();
            BeginContext(1920, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1960, 42, false);
#line 46 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.MatKhau));

#line default
#line hidden
            EndContext();
            BeginContext(2002, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2042, 40, false);
#line 47 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(2082, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 48 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Index.cshtml"
                             if (item.GioiTinh == false)
                            {

#line default
#line hidden
            BeginContext(2178, 45, true);
            WriteLiteral("                                <td>Nữ</td>\r\n");
            EndContext();
#line 51 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2319, 46, true);
            WriteLiteral("                                <td>Nam</td>\r\n");
            EndContext();
#line 55 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(2396, 32, true);
            WriteLiteral("                            <td>");
            EndContext();
            BeginContext(2429, 43, false);
#line 56 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.NgaySinh));

#line default
#line hidden
            EndContext();
            BeginContext(2472, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2512, 41, false);
#line 57 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(2553, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2593, 44, false);
#line 58 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.DienThoai));

#line default
#line hidden
            EndContext();
            BeginContext(2637, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2677, 40, false);
#line 59 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2717, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 60 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Index.cshtml"
                             if (item.HieuLuc == true)
                            {

#line default
#line hidden
            BeginContext(2811, 55, true);
            WriteLiteral("                                <td>Còn hiệu lực</td>\r\n");
            EndContext();
#line 63 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2962, 55, true);
            WriteLiteral("                                <td>Hết hiệu lực</td>\r\n");
            EndContext();
#line 67 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(3048, 32, true);
            WriteLiteral("                            <td>");
            EndContext();
            BeginContext(3080, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ba84743ec324814b62525bdea215b55", async() => {
                BeginContext(3127, 8, true);
                WriteLiteral("Cập nhật");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 68 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Index.cshtml"
                                                       WriteLiteral(item.MaKh);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3139, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3178, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8a15facd0d34e0684b36e9cd299050c", async() => {
                BeginContext(3227, 3, true);
                WriteLiteral("Xóa");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 69 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Index.cshtml"
                                                         WriteLiteral(item.MaKh);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3234, 38, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n");
            EndContext();
#line 71 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhachHangs\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(3299, 262, true);
            WriteLiteral(@"                    </tbody>
                </table>
                <!-- /.table-responsive -->
            </div>
            <!-- /.panel-body -->
        </div>
        <!-- /.panel -->
    </div>
    <!-- /.col-lg-12 -->
</div>
<!-- /.row -->

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebOnline.Models.KhachHang>> Html { get; private set; }
    }
}
#pragma warning restore 1591
