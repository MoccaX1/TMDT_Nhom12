#pragma checksum "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\HoaDons\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cdeb7a724cbfbe91148b6a2155cf791fb0dd1b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HoaDons_Details), @"mvc.1.0.view", @"/Views/HoaDons/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HoaDons/Details.cshtml", typeof(AspNetCore.Views_HoaDons_Details))]
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
#line 1 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\_ViewImports.cshtml"
using WebOnline;

#line default
#line hidden
#line 2 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\_ViewImports.cshtml"
using WebOnline.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cdeb7a724cbfbe91148b6a2155cf791fb0dd1b4", @"/Views/HoaDons/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31d990892514bb951e8dd271a1ae062f382d88f2", @"/Views/_ViewImports.cshtml")]
    public class Views_HoaDons_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebOnline.Models.HoaDon>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(31, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\HoaDons\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(123, 112, true);
            WriteLiteral("\n<h2>Details</h2>\n\n<div>\n    <h4>HoaDon</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(236, 43, false);
#line 15 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\HoaDons\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NgayDat));

#line default
#line hidden
            EndContext();
            BeginContext(279, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(320, 39, false);
#line 18 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\HoaDons\Details.cshtml"
       Write(Html.DisplayFor(model => model.NgayDat));

#line default
#line hidden
            EndContext();
            BeginContext(359, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(400, 44, false);
#line 21 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\HoaDons\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NgayGiao));

#line default
#line hidden
            EndContext();
            BeginContext(444, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(485, 40, false);
#line 24 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\HoaDons\Details.cshtml"
       Write(Html.DisplayFor(model => model.NgayGiao));

#line default
#line hidden
            EndContext();
            BeginContext(525, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(566, 41, false);
#line 27 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\HoaDons\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(607, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(648, 37, false);
#line 30 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\HoaDons\Details.cshtml"
       Write(Html.DisplayFor(model => model.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(685, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(726, 42, false);
#line 33 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\HoaDons\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(768, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(809, 38, false);
#line 36 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\HoaDons\Details.cshtml"
       Write(Html.DisplayFor(model => model.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(847, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(888, 49, false);
#line 39 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\HoaDons\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CachThanhToan));

#line default
#line hidden
            EndContext();
            BeginContext(937, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(978, 45, false);
#line 42 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\HoaDons\Details.cshtml"
       Write(Html.DisplayFor(model => model.CachThanhToan));

#line default
#line hidden
            EndContext();
            BeginContext(1023, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1064, 49, false);
#line 45 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\HoaDons\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CachVanChuyen));

#line default
#line hidden
            EndContext();
            BeginContext(1113, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1154, 45, false);
#line 48 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\HoaDons\Details.cshtml"
       Write(Html.DisplayFor(model => model.CachVanChuyen));

#line default
#line hidden
            EndContext();
            BeginContext(1199, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1240, 48, false);
#line 51 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\HoaDons\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhiVanChuyen));

#line default
#line hidden
            EndContext();
            BeginContext(1288, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1329, 44, false);
#line 54 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\HoaDons\Details.cshtml"
       Write(Html.DisplayFor(model => model.PhiVanChuyen));

#line default
#line hidden
            EndContext();
            BeginContext(1373, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1414, 42, false);
#line 57 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\HoaDons\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GhiChu));

#line default
#line hidden
            EndContext();
            BeginContext(1456, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1497, 38, false);
#line 60 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\HoaDons\Details.cshtml"
       Write(Html.DisplayFor(model => model.GhiChu));

#line default
#line hidden
            EndContext();
            BeginContext(1535, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1576, 45, false);
#line 63 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\HoaDons\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DienThoai));

#line default
#line hidden
            EndContext();
            BeginContext(1621, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1662, 41, false);
#line 66 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\HoaDons\Details.cshtml"
       Write(Html.DisplayFor(model => model.DienThoai));

#line default
#line hidden
            EndContext();
            BeginContext(1703, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1744, 45, false);
#line 69 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\HoaDons\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TenNgNhan));

#line default
#line hidden
            EndContext();
            BeginContext(1789, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1830, 41, false);
#line 72 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\HoaDons\Details.cshtml"
       Write(Html.DisplayFor(model => model.TenNgNhan));

#line default
#line hidden
            EndContext();
            BeginContext(1871, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1912, 44, false);
#line 75 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\HoaDons\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DtngNhan));

#line default
#line hidden
            EndContext();
            BeginContext(1956, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1997, 40, false);
#line 78 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\HoaDons\Details.cshtml"
       Write(Html.DisplayFor(model => model.DtngNhan));

#line default
#line hidden
            EndContext();
            BeginContext(2037, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(2078, 48, false);
#line 81 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\HoaDons\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DiaChiNgNhan));

#line default
#line hidden
            EndContext();
            BeginContext(2126, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(2167, 44, false);
#line 84 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\HoaDons\Details.cshtml"
       Write(Html.DisplayFor(model => model.DiaChiNgNhan));

#line default
#line hidden
            EndContext();
            BeginContext(2211, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(2252, 50, false);
#line 87 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\HoaDons\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaKhNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2302, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(2343, 51, false);
#line 90 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\HoaDons\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaKhNavigation.MaKh));

#line default
#line hidden
            EndContext();
            BeginContext(2394, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(2435, 50, false);
#line 93 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\HoaDons\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaNvNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2485, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(2526, 51, false);
#line 96 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\HoaDons\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaNvNavigation.MaNv));

#line default
#line hidden
            EndContext();
            BeginContext(2577, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(2618, 57, false);
#line 99 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\HoaDons\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaTrangThaiNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2675, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(2716, 65, false);
#line 102 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\HoaDons\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaTrangThaiNavigation.MaTrangThai));

#line default
#line hidden
            EndContext();
            BeginContext(2781, 42, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(2823, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6549fdee870e45d3a92b7215b97268c1", async() => {
                BeginContext(2871, 4, true);
                WriteLiteral("Edit");
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
#line 107 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\HoaDons\Details.cshtml"
                           WriteLiteral(Model.MaHd);

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
            BeginContext(2879, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(2886, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3779b88c93f74e8da82ff1ebc779b8f1", async() => {
                BeginContext(2908, 12, true);
                WriteLiteral("Back to List");
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
            BeginContext(2924, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebOnline.Models.HoaDon> Html { get; private set; }
    }
}
#pragma warning restore 1591