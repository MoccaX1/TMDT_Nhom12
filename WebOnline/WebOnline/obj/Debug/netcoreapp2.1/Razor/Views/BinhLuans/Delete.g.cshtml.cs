#pragma checksum "C:\Users\DELL\Desktop\WebOnline\WebOnline\Views\BinhLuans\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bd3d66fc2928ee20d722a05ef483c3224ee2f6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BinhLuans_Delete), @"mvc.1.0.view", @"/Views/BinhLuans/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BinhLuans/Delete.cshtml", typeof(AspNetCore.Views_BinhLuans_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bd3d66fc2928ee20d722a05ef483c3224ee2f6a", @"/Views/BinhLuans/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31d990892514bb951e8dd271a1ae062f382d88f2", @"/Views/_ViewImports.cshtml")]
    public class Views_BinhLuans_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebOnline.Models.BinhLuan>
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
            BeginContext(33, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\DELL\Desktop\WebOnline\WebOnline\Views\BinhLuans\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(124, 55, true);
            WriteLiteral("\n<br />\n<br />\n\n<h3>Bạn có chắc chắn xóa bình luận của ");
            EndContext();
            BeginContext(180, 37, false);
#line 11 "C:\Users\DELL\Desktop\WebOnline\WebOnline\Views\BinhLuans\Delete.cshtml"
                                  Write(Html.DisplayFor(model => model.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(217, 105, true);
            WriteLiteral(" ? </h3>\n<div>\n    <h4>Thông tin</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(323, 42, false);
#line 17 "C:\Users\DELL\Desktop\WebOnline\WebOnline\Views\BinhLuans\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NgayBl));

#line default
#line hidden
            EndContext();
            BeginContext(365, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(406, 38, false);
#line 20 "C:\Users\DELL\Desktop\WebOnline\WebOnline\Views\BinhLuans\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NgayBl));

#line default
#line hidden
            EndContext();
            BeginContext(444, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(485, 40, false);
#line 23 "C:\Users\DELL\Desktop\WebOnline\WebOnline\Views\BinhLuans\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MaKh));

#line default
#line hidden
            EndContext();
            BeginContext(525, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(566, 36, false);
#line 26 "C:\Users\DELL\Desktop\WebOnline\WebOnline\Views\BinhLuans\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MaKh));

#line default
#line hidden
            EndContext();
            BeginContext(602, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(643, 41, false);
#line 29 "C:\Users\DELL\Desktop\WebOnline\WebOnline\Views\BinhLuans\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(684, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(725, 37, false);
#line 32 "C:\Users\DELL\Desktop\WebOnline\WebOnline\Views\BinhLuans\Delete.cshtml"
       Write(Html.DisplayFor(model => model.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(762, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(803, 40, false);
#line 35 "C:\Users\DELL\Desktop\WebOnline\WebOnline\Views\BinhLuans\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MaSp));

#line default
#line hidden
            EndContext();
            BeginContext(843, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(884, 36, false);
#line 38 "C:\Users\DELL\Desktop\WebOnline\WebOnline\Views\BinhLuans\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MaSp));

#line default
#line hidden
            EndContext();
            BeginContext(920, 92, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            Tên sản phẩm\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1013, 52, false);
#line 44 "C:\Users\DELL\Desktop\WebOnline\WebOnline\Views\BinhLuans\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MaSpNavigation.TenSp));

#line default
#line hidden
            EndContext();
            BeginContext(1065, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1106, 43, false);
#line 47 "C:\Users\DELL\Desktop\WebOnline\WebOnline\Views\BinhLuans\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NoiDung));

#line default
#line hidden
            EndContext();
            BeginContext(1149, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1190, 39, false);
#line 50 "C:\Users\DELL\Desktop\WebOnline\WebOnline\Views\BinhLuans\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NoiDung));

#line default
#line hidden
            EndContext();
            BeginContext(1229, 30, true);
            WriteLiteral("\n        </dd>\n    </dl>\n\n    ");
            EndContext();
            BeginContext(1259, 209, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4320ff3b16644263b9a0e97fdcc37b8e", async() => {
                BeginContext(1285, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(1294, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d5dbfe5bc24444bf92b83f715e6c44e4", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 55 "C:\Users\DELL\Desktop\WebOnline\WebOnline\Views\BinhLuans\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MaBl);

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
                BeginContext(1332, 91, true);
                WriteLiteral("\n        <input type=\"submit\" value=\"Xóa\" class=\"btn btn-default\" /> <br /> <br />\n        ");
                EndContext();
                BeginContext(1423, 33, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08a310106bd043f58ab1703c76eac631", async() => {
                    BeginContext(1445, 7, true);
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
                BeginContext(1456, 5, true);
                WriteLiteral("\n    ");
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
            BeginContext(1468, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebOnline.Models.BinhLuan> Html { get; private set; }
    }
}
#pragma warning restore 1591