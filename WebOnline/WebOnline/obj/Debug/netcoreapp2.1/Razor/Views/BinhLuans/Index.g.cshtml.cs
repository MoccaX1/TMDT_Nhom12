#pragma checksum "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\BinhLuans\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92e2f724852639e87a59555cd15d23484eddb8b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BinhLuans_Index), @"mvc.1.0.view", @"/Views/BinhLuans/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BinhLuans/Index.cshtml", typeof(AspNetCore.Views_BinhLuans_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92e2f724852639e87a59555cd15d23484eddb8b3", @"/Views/BinhLuans/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a85df1676a2737903bf96fadd45101644718e46a", @"/Views/_ViewImports.cshtml")]
    public class Views_BinhLuans_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebOnline.Models.BinhLuan>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\BinhLuans\Index.cshtml"
  
    ViewData["Title"] = "| Bình luận";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(148, 621, true);
            WriteLiteral(@"<div class=""row"">
    <div class=""col-lg-12"">
        <h1 class=""page-header"">Bình luận</h1>
    </div>
    <!-- /.col-lg-12 -->
</div>
<!-- /.row -->
<div class=""row"">
    <div class=""col-lg-12"">
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
            BeginContext(770, 42, false);
#line 25 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\BinhLuans\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.NgayBl));

#line default
#line hidden
            EndContext();
            BeginContext(812, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(852, 40, false);
#line 26 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\BinhLuans\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.MaKh));

#line default
#line hidden
            EndContext();
            BeginContext(892, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(932, 41, false);
#line 27 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\BinhLuans\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(973, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1013, 40, false);
#line 28 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\BinhLuans\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.MaSp));

#line default
#line hidden
            EndContext();
            BeginContext(1053, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1093, 56, false);
#line 29 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\BinhLuans\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.MaSpNavigation.TenSp));

#line default
#line hidden
            EndContext();
            BeginContext(1149, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1189, 43, false);
#line 30 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\BinhLuans\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.NoiDung));

#line default
#line hidden
            EndContext();
            BeginContext(1232, 138, true);
            WriteLiteral("</th>\r\n\r\n                            <th></th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 36 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\BinhLuans\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1451, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1514, 41, false);
#line 39 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\BinhLuans\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.NgayBl));

#line default
#line hidden
            EndContext();
            BeginContext(1555, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1595, 39, false);
#line 40 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\BinhLuans\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.MaKh));

#line default
#line hidden
            EndContext();
            BeginContext(1634, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1674, 40, false);
#line 41 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\BinhLuans\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(1714, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1754, 39, false);
#line 42 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\BinhLuans\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.MaSp));

#line default
#line hidden
            EndContext();
            BeginContext(1793, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1833, 55, false);
#line 43 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\BinhLuans\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.MaSpNavigation.TenSp));

#line default
#line hidden
            EndContext();
            BeginContext(1888, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1928, 42, false);
#line 44 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\BinhLuans\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.NoiDung));

#line default
#line hidden
            EndContext();
            BeginContext(1970, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2009, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29fa67592b6e4fb88d74a656bc7df344", async() => {
                BeginContext(2058, 3, true);
                WriteLiteral("Xóa");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 45 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\BinhLuans\Index.cshtml"
                                                         WriteLiteral(item.MaBl);

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
            BeginContext(2065, 38, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n");
            EndContext();
#line 47 "C:\Users\vi\Desktop\TMDT_Nhom12\WebOnline\WebOnline\Views\BinhLuans\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2130, 258, true);
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
<!-- /.row -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebOnline.Models.BinhLuan>> Html { get; private set; }
    }
}
#pragma warning restore 1591
