#pragma checksum "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhoHangs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc5e6c8a28a7c658c127359c84b67c4097157756"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_KhoHangs_Index), @"mvc.1.0.view", @"/Views/KhoHangs/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/KhoHangs/Index.cshtml", typeof(AspNetCore.Views_KhoHangs_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc5e6c8a28a7c658c127359c84b67c4097157756", @"/Views/KhoHangs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a85df1676a2737903bf96fadd45101644718e46a", @"/Views/_ViewImports.cshtml")]
    public class Views_KhoHangs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebOnline.Models.KhoHang>>
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
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhoHangs\Index.cshtml"
  
    ViewData["Title"] = "| Kho hàng";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(146, 230, true);
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-lg-12\">\r\n        <h1 class=\"page-header\">Kho hàng</h1>\r\n    </div>\r\n    <!-- /.col-lg-12 -->\r\n</div>\r\n<!-- /.row -->\r\n<div class=\"row\">\r\n    <div class=\"col-lg-12\">\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(376, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0296ef32cc5436387c4e46f6ae1eff0", async() => {
                BeginContext(399, 8, true);
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
            BeginContext(411, 431, true);
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
            BeginContext(843, 40, false);
#line 28 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhoHangs\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.MaSp));

#line default
#line hidden
            EndContext();
            BeginContext(883, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(923, 56, false);
#line 29 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhoHangs\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.MaSpNavigation.TenSp));

#line default
#line hidden
            EndContext();
            BeginContext(979, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1019, 43, false);
#line 30 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhoHangs\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.SoLuong));

#line default
#line hidden
            EndContext();
            BeginContext(1062, 175, true);
            WriteLiteral("</th>\r\n                            <th></th>\r\n                            <th></th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 36 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhoHangs\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1318, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(1389, 39, false);
#line 39 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhoHangs\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MaSp));

#line default
#line hidden
            EndContext();
            BeginContext(1428, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1472, 55, false);
#line 40 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhoHangs\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.MaSpNavigation.TenSp));

#line default
#line hidden
            EndContext();
            BeginContext(1527, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 41 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhoHangs\Index.cshtml"
                                 if (item.SoLuong > 0)
                                {

#line default
#line hidden
            BeginContext(1625, 40, true);
            WriteLiteral("                                    <td>");
            EndContext();
            BeginContext(1666, 42, false);
#line 43 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhoHangs\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.SoLuong));

#line default
#line hidden
            EndContext();
            BeginContext(1708, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 44 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhoHangs\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(1823, 55, true);
            WriteLiteral("                                    <td>Hết hàng</td>\r\n");
            EndContext();
#line 48 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhoHangs\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(1913, 36, true);
            WriteLiteral("                                <td>");
            EndContext();
            BeginContext(1949, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9db91acc8874f46b889056359ea1b90", async() => {
                BeginContext(1997, 8, true);
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
#line 49 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhoHangs\Index.cshtml"
                                                           WriteLiteral(item.MaKho);

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
            BeginContext(2009, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2052, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d083305a0ed4dc0b1592b902bd2f616", async() => {
                BeginContext(2102, 3, true);
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
#line 50 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhoHangs\Index.cshtml"
                                                             WriteLiteral(item.MaKho);

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
            BeginContext(2109, 42, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n");
            EndContext();
#line 52 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\KhoHangs\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2178, 262, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebOnline.Models.KhoHang>> Html { get; private set; }
    }
}
#pragma warning restore 1591
