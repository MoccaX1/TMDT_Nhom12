#pragma checksum "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\ThanhToan\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8714ebb64b4eb20b1f096d00ef41f2530d381312"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ThanhToan_Index), @"mvc.1.0.view", @"/Views/ThanhToan/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ThanhToan/Index.cshtml", typeof(AspNetCore.Views_ThanhToan_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8714ebb64b4eb20b1f096d00ef41f2530d381312", @"/Views/ThanhToan/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31d990892514bb951e8dd271a1ae062f382d88f2", @"/Views/_ViewImports.cshtml")]
    public class Views_ThanhToan_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebOnline.Models.CartItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ThanhToan1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ThanhToan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link flex-sm-fill text-sm-center active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link flex-sm-fill text-sm-center disabled"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "GioHang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Them", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DangNhap", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DangNhap", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\ThanhToan\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Frontend.cshtml";

#line default
#line hidden
            BeginContext(125, 539, true);
            WriteLiteral(@"


<div id=""content"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <!-- breadcrumb-->
                <nav aria-label=""breadcrumb"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item""><a href=""#"">Trang chủ</a></li>
                        <li aria-current=""page"" class=""breadcrumb-item active"">Thanh toán bước 1</li>
                    </ol>
                </nav>
            </div>
            <div id=""checkout"" class=""col-lg-9"">
");
            EndContext();
#line 22 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\ThanhToan\Index.cshtml"
                  
                    double tong = 0;

                

#line default
#line hidden
            BeginContext(739, 169, true);
            WriteLiteral("\n\n                <div class=\"box\">\n\n                    <h1>Thông tin giao hàng</h1>\n                    <div class=\"nav flex-column flex-md-row nav-pills text-center\">");
            EndContext();
            BeginContext(908, 185, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe29f608d534400b99e9a3559e30612a", async() => {
                BeginContext(1014, 75, true);
                WriteLiteral("  <i class=\"fa fa-map-marker\">                      </i>Thông tin giao hàng");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1093, 165, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c4a4b8691b84155930d1ffa97274d42", async() => {
                BeginContext(1196, 58, true);
                WriteLiteral("<i class=\"fa fa-eye\">                  </i>Hóa đơn của bạn");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1258, 7, true);
            WriteLiteral("</div>\n");
            EndContext();
#line 32 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\ThanhToan\Index.cshtml"
                     if (Context.Session.Get<KhachHang>("TaiKhoan") != null)
                    {
                        KhachHang kh = Context.Session.Get<KhachHang>("TaiKhoan");


#line default
#line hidden
            BeginContext(1448, 343, true);
            WriteLiteral(@"                        <div class=""alert alert-info"">
                            <a href=""#"" class=""close"" data-dismiss=""alert"" aria-label=""close"">&times;</a>
                            * Vui lòng kiểm tra thông tin người nhận hàng. Nếu bạn có thay đổi vui lòng điển đầy đủ thông tin.
                        </div>
                        ");
            EndContext();
            BeginContext(1791, 2501, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a6e0368ce0e4fa09640405bab75f615", async() => {
                BeginContext(1856, 362, true);
                WriteLiteral(@"
                        <div class=""content py-3"">
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <label for=""firstname"">Họ tên người nhận</label>
                                        <input name=""tennn""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2218, "\"", 2235, 1);
#line 46 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\ThanhToan\Index.cshtml"
WriteAttributeValue("", 2226, kh.HoTen, 2226, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2236, 386, true);
                WriteLiteral(@"type=""text"" class=""form-control"">
                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <label for=""lastname"">Số điện thoại người nhận</label>
                                        <input name=""sdtnn""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2622, "\"", 2643, 1);
#line 52 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\ThanhToan\Index.cshtml"
WriteAttributeValue("", 2630, kh.DienThoai, 2630, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2644, 506, true);
                WriteLiteral(@" type=""text"" class=""form-control"">
                                    </div>
                                </div>
                            </div>
                            <!-- /.row-->
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <label for=""company"">Địa chỉ người nhận</label>
                                        <input name=""diachinn""");
                EndContext();
                BeginWriteAttribute("value", "  value=\"", 3150, "\"", 3169, 1);
#line 61 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\ThanhToan\Index.cshtml"
WriteAttributeValue("", 3159, kh.DiaChi, 3159, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3170, 785, true);
                WriteLiteral(@" type=""text"" class=""form-control"">
                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <label for=""ghichunn"">Ghi chú đơn đặt hàng</label>
                                        <textarea name=""ghichunn"" class=""form-control"" cols='50' rows='2'> </textarea>
                                    </div>
                                </div>
                            </div>

                            <!-- /.row-->
                            <!-- /.row-->
                        </div>

                        <div class=""box-footer d-flex justify-content-between"">
                            ");
                EndContext();
                BeginContext(3955, 136, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36958300f24049179a6db8b523bedc86", async() => {
                    BeginContext(4036, 51, true);
                    WriteLiteral("<i class=\"fa fa-chevron-left\"></i>Quay lại giỏ hàng");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4091, 194, true);
                WriteLiteral("\n                            <button type=\"submit\" class=\"btn btn-primary\">Tiếp tục thanh toán<i class=\"fa fa-chevron-right\"></i></button>\n                        </div>\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4292, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 81 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\ThanhToan\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(4362, 31, true);
            WriteLiteral("                        <br />\n");
            EndContext();
            BeginContext(4394, 83, true);
            WriteLiteral("                        <div class=\"alert alert-danger\" style=\"text-align:center\"> ");
            EndContext();
            BeginContext(4477, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d846e92827e4fe2849502c1a94a89a4", async() => {
                BeginContext(4528, 39, true);
                WriteLiteral("Bạn cần đăng nhập để tiếp tục mua hàng ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4571, 7, true);
            WriteLiteral("</div>\n");
            EndContext();
            BeginContext(4579, 108, true);
            WriteLiteral("                        <div class=\"box-footer d-flex justify-content-between\">\n                            ");
            EndContext();
            BeginContext(4687, 136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c13cd1e4ac444f01a8d0b2d4d6e37fb6", async() => {
                BeginContext(4768, 51, true);
                WriteLiteral("<i class=\"fa fa-chevron-left\"></i>Quay lại giỏ hàng");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4823, 33, true);
            WriteLiteral("\n\n                        </div>\n");
            EndContext();
#line 92 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\ThanhToan\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(4878, 550, true);
            WriteLiteral(@"
                </div>
                <!-- /.box-->
            </div>
            <!-- /.col-lg-9-->
            <div class=""col-lg-3"">
                <div id=""order-summary"" class=""card"">
                    <div class=""card-header"" style=""text-align:center"">
                        <h3 class=""mt-4 mb-4"">Thông tin hóa đơn</h3>
                    </div>
                    <div class=""card-body"">
                        <div class=""table-responsive"">
                            <table class=""table"">
                                <tbody>
");
            EndContext();
#line 107 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\ThanhToan\Index.cshtml"
                                     foreach (var item in Model)
                                    {
                                        tong = tong + item.ThanhTien;
                                    }

#line default
#line hidden
            BeginContext(5639, 153, true);
            WriteLiteral("                                    <tr>\n                                        <td>Tổng tiền giỏ hàng</td>\n                                        <th>");
            EndContext();
            BeginContext(5793, 22, false);
#line 113 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\ThanhToan\Index.cshtml"
                                       Write(tong.ToString("#,##0"));

#line default
#line hidden
            EndContext();
            BeginContext(5815, 606, true);
            WriteLiteral(@" đ</th>
                                    </tr>
                                    <tr>
                                        <td>Phí giao hàng</td>
                                        <th>Miễn phí</th>
                                    </tr>
                                    <tr>
                                        <td>Khuyến mãi</td>
                                        <th>0</th>
                                    </tr>
                                    <tr class=""total"">
                                        <td>Tổng cộng</td>
                                        <th>");
            EndContext();
            BeginContext(6422, 22, false);
#line 125 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\ThanhToan\Index.cshtml"
                                       Write(tong.ToString("#,##0"));

#line default
#line hidden
            EndContext();
            BeginContext(6444, 292, true);
            WriteLiteral(@" đ</th>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
            <!-- /.col-lg-3-->
        </div>
    </div>
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebOnline.Models.CartItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
