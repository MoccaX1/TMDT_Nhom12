#pragma checksum "C:\Users\DELL\Desktop\WebOnline\WebOnline\Views\SanPhams\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e60fd0e7d0b6d63e8739a1eac37929eafd57e8f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SanPhams_Index), @"mvc.1.0.view", @"/Views/SanPhams/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SanPhams/Index.cshtml", typeof(AspNetCore.Views_SanPhams_Index))]
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
#line 1 "C:\Users\DELL\Desktop\WebOnline\WebOnline\Views\_ViewImports.cshtml"
using WebOnline;

#line default
#line hidden
#line 2 "C:\Users\DELL\Desktop\WebOnline\WebOnline\Views\_ViewImports.cshtml"
using WebOnline.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e60fd0e7d0b6d63e8739a1eac37929eafd57e8f8", @"/Views/SanPhams/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31d990892514bb951e8dd271a1ae062f382d88f2", @"/Views/_ViewImports.cshtml")]
    public class Views_SanPhams_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebOnline.Models.SanPham>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 100px; width: 100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\DELL\Desktop\WebOnline\WebOnline\Views\SanPhams\Index.cshtml"
  
    ViewData["Title"] = "| Sản phẩm";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(140, 220, true);
            WriteLiteral("<div class=\"row\">\n    <div class=\"col-lg-12\">\n        <h1 class=\"page-header\">Sản phẩm</h1>\n    </div>\n    <!-- /.col-lg-12 -->\n</div>\n<!-- /.row -->\n<div class=\"row\">\n    <div class=\"col-lg-12\">\n        <p>\n            ");
            EndContext();
            BeginContext(360, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9cf71d36bd34dc290e3f49b2fed03bf", async() => {
                BeginContext(383, 8, true);
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
            BeginContext(395, 420, true);
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
            BeginContext(816, 40, false);
#line 28 "C:\Users\DELL\Desktop\WebOnline\WebOnline\Views\SanPhams\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.MaSp));

#line default
#line hidden
            EndContext();
            BeginContext(856, 38, true);
            WriteLiteral("</th>\n                            <th>");
            EndContext();
            BeginContext(895, 41, false);
#line 29 "C:\Users\DELL\Desktop\WebOnline\WebOnline\Views\SanPhams\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.TenSp));

#line default
#line hidden
            EndContext();
            BeginContext(936, 38, true);
            WriteLiteral("</th>\n                            <th>");
            EndContext();
            BeginContext(975, 42, false);
#line 30 "C:\Users\DELL\Desktop\WebOnline\WebOnline\Views\SanPhams\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.MaLoai));

#line default
#line hidden
            EndContext();
            BeginContext(1017, 38, true);
            WriteLiteral("</th>\n                            <th>");
            EndContext();
            BeginContext(1056, 40, false);
#line 31 "C:\Users\DELL\Desktop\WebOnline\WebOnline\Views\SanPhams\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.MoTa));

#line default
#line hidden
            EndContext();
            BeginContext(1096, 38, true);
            WriteLiteral("</th>\n                            <th>");
            EndContext();
            BeginContext(1135, 42, false);
#line 32 "C:\Users\DELL\Desktop\WebOnline\WebOnline\Views\SanPhams\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.DonGia));

#line default
#line hidden
            EndContext();
            BeginContext(1177, 38, true);
            WriteLiteral("</th>\n                            <th>");
            EndContext();
            BeginContext(1216, 40, false);
#line 33 "C:\Users\DELL\Desktop\WebOnline\WebOnline\Views\SanPhams\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Hinh));

#line default
#line hidden
            EndContext();
            BeginContext(1256, 38, true);
            WriteLiteral("</th>\n                            <th>");
            EndContext();
            BeginContext(1295, 41, false);
#line 34 "C:\Users\DELL\Desktop\WebOnline\WebOnline\Views\SanPhams\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Hinh2));

#line default
#line hidden
            EndContext();
            BeginContext(1336, 38, true);
            WriteLiteral("</th>\n                            <th>");
            EndContext();
            BeginContext(1375, 41, false);
#line 35 "C:\Users\DELL\Desktop\WebOnline\WebOnline\Views\SanPhams\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.GiaCu));

#line default
#line hidden
            EndContext();
            BeginContext(1416, 169, true);
            WriteLiteral("</th>\n                            <th></th>\n                            <th></th>\n                        </tr>\n                    </thead>\n                    <tbody>\n");
            EndContext();
#line 41 "C:\Users\DELL\Desktop\WebOnline\WebOnline\Views\SanPhams\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1664, 80, true);
            WriteLiteral("                        <tr class=\"odd gradeX\">\n                            <td>");
            EndContext();
            BeginContext(1745, 39, false);
#line 44 "C:\Users\DELL\Desktop\WebOnline\WebOnline\Views\SanPhams\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.MaSp));

#line default
#line hidden
            EndContext();
            BeginContext(1784, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(1823, 40, false);
#line 45 "C:\Users\DELL\Desktop\WebOnline\WebOnline\Views\SanPhams\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.TenSp));

#line default
#line hidden
            EndContext();
            BeginContext(1863, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(1902, 41, false);
#line 46 "C:\Users\DELL\Desktop\WebOnline\WebOnline\Views\SanPhams\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.MaLoai));

#line default
#line hidden
            EndContext();
            BeginContext(1943, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(1982, 39, false);
#line 47 "C:\Users\DELL\Desktop\WebOnline\WebOnline\Views\SanPhams\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.MoTa));

#line default
#line hidden
            EndContext();
            BeginContext(2021, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(2060, 41, false);
#line 48 "C:\Users\DELL\Desktop\WebOnline\WebOnline\Views\SanPhams\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.DonGia));

#line default
#line hidden
            EndContext();
            BeginContext(2101, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(2139, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "487066f04c1f462592cfca980284b35c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2185, "~/Hinh/beauty/", 2185, 14, true);
#line 49 "C:\Users\DELL\Desktop\WebOnline\WebOnline\Views\SanPhams\Index.cshtml"
AddHtmlAttributeValue("", 2199, item.Hinh, 2199, 10, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2213, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(2251, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d5461a96ba0949739c400d9642c0d568", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2297, "~/Hinh/beauty/", 2297, 14, true);
#line 50 "C:\Users\DELL\Desktop\WebOnline\WebOnline\Views\SanPhams\Index.cshtml"
AddHtmlAttributeValue("", 2311, item.Hinh2, 2311, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2326, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(2365, 40, false);
#line 51 "C:\Users\DELL\Desktop\WebOnline\WebOnline\Views\SanPhams\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.GiaCu));

#line default
#line hidden
            EndContext();
            BeginContext(2405, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(2443, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e5ebccbcec9457cb1558757a2ba98f6", async() => {
                BeginContext(2490, 8, true);
                WriteLiteral("Cập nhật");
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
#line 52 "C:\Users\DELL\Desktop\WebOnline\WebOnline\Views\SanPhams\Index.cshtml"
                                                       WriteLiteral(item.MaSp);

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
            BeginContext(2502, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(2540, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1ad9e59b305442e94103c32c3e72a31", async() => {
                BeginContext(2589, 3, true);
                WriteLiteral("Xóa");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "C:\Users\DELL\Desktop\WebOnline\WebOnline\Views\SanPhams\Index.cshtml"
                                                         WriteLiteral(item.MaSp);

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
            BeginContext(2596, 36, true);
            WriteLiteral("</td>\n                        </tr>\n");
            EndContext();
#line 55 "C:\Users\DELL\Desktop\WebOnline\WebOnline\Views\SanPhams\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2658, 249, true);
            WriteLiteral("                    </tbody>\n                </table>\n                <!-- /.table-responsive -->\n            </div>\n            <!-- /.panel-body -->\n        </div>\n        <!-- /.panel -->\n    </div>\n    <!-- /.col-lg-12 -->\n</div>\n<!-- /.row -->\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebOnline.Models.SanPham>> Html { get; private set; }
    }
}
#pragma warning restore 1591
