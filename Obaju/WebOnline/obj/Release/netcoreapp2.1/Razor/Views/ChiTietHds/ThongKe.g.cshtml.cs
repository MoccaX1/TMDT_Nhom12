#pragma checksum "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\ChiTietHds\ThongKe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af805c19e26b3615f45c2b2e0daaccc4e9b36508"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ChiTietHds_ThongKe), @"mvc.1.0.view", @"/Views/ChiTietHds/ThongKe.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ChiTietHds/ThongKe.cshtml", typeof(AspNetCore.Views_ChiTietHds_ThongKe))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af805c19e26b3615f45c2b2e0daaccc4e9b36508", @"/Views/ChiTietHds/ThongKe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31d990892514bb951e8dd271a1ae062f382d88f2", @"/Views/_ViewImports.cshtml")]
    public class Views_ChiTietHds_ThongKe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebOnline.Models.ChiTietHd>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\ChiTietHds\ThongKe.cshtml"
  
    ViewData["Title"] = "| Doanh thu";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(143, 618, true);
            WriteLiteral(@"<div class=""row"">
    <div class=""col-lg-12"">
        <h1 class=""page-header"">Thống kê sản phẩm đã bán</h1>
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
            BeginContext(762, 40, false);
#line 25 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\ChiTietHds\ThongKe.cshtml"
                           Write(Html.DisplayNameFor(model => model.MaSp));

#line default
#line hidden
            EndContext();
            BeginContext(802, 38, true);
            WriteLiteral("</th>\n                            <th>");
            EndContext();
            BeginContext(841, 56, false);
#line 26 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\ChiTietHds\ThongKe.cshtml"
                           Write(Html.DisplayNameFor(model => model.MaSpNavigation.TenSp));

#line default
#line hidden
            EndContext();
            BeginContext(897, 38, true);
            WriteLiteral("</th>\n                            <th>");
            EndContext();
            BeginContext(936, 42, false);
#line 27 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\ChiTietHds\ThongKe.cshtml"
                           Write(Html.DisplayNameFor(model => model.DonGia));

#line default
#line hidden
            EndContext();
            BeginContext(978, 38, true);
            WriteLiteral("</th>\n                            <th>");
            EndContext();
            BeginContext(1017, 43, false);
#line 28 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\ChiTietHds\ThongKe.cshtml"
                           Write(Html.DisplayNameFor(model => model.SoLuong));

#line default
#line hidden
            EndContext();
            BeginContext(1060, 93, true);
            WriteLiteral("</th>\n                        </tr>\n                    </thead>\n                    <tbody>\n");
            EndContext();
#line 32 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\ChiTietHds\ThongKe.cshtml"
                          
                            MyPhamContext db = new MyPhamContext();
                            int dem = db.SanPham.Count();
                            double? tongtien = 0;
                            for (int i = 1; i <= dem; i++)
                            {
                                var tk = db.ChiTietHd.Where(m => m.MaSp == i).Where(p => p.MaHdNavigation.MaTrangThai != 0);
                                var sp = db.SanPham.Where(m => m.MaSp == i);
                                int? sl = 0;
                                

#line default
#line hidden
#line 41 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\ChiTietHds\ThongKe.cshtml"
                                 foreach (var Tk in tk)
                                {
                                    sl += Tk.SoLuong;
                                }

#line default
#line hidden
#line 44 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\ChiTietHds\ThongKe.cshtml"
                                 
                                if (tk != null && sl > 0)
                                {
                                    foreach (var Sp in sp)
                                    {
                                        tongtien += Sp.DonGia * sl;

#line default
#line hidden
            BeginContext(2127, 93, true);
            WriteLiteral("                                        <tr>\n                                            <td>");
            EndContext();
            BeginContext(2221, 37, false);
#line 51 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\ChiTietHds\ThongKe.cshtml"
                                           Write(Html.DisplayFor(modelItem => Sp.MaSp));

#line default
#line hidden
            EndContext();
            BeginContext(2258, 54, true);
            WriteLiteral("</td>\n                                            <td>");
            EndContext();
            BeginContext(2313, 38, false);
#line 52 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\ChiTietHds\ThongKe.cshtml"
                                           Write(Html.DisplayFor(modelItem => Sp.TenSp));

#line default
#line hidden
            EndContext();
            BeginContext(2351, 54, true);
            WriteLiteral("</td>\n                                            <td>");
            EndContext();
            BeginContext(2406, 39, false);
#line 53 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\ChiTietHds\ThongKe.cshtml"
                                           Write(Html.DisplayFor(modelItem => Sp.DonGia));

#line default
#line hidden
            EndContext();
            BeginContext(2445, 54, true);
            WriteLiteral("</td>\n                                            <td>");
            EndContext();
            BeginContext(2500, 2, false);
#line 54 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\ChiTietHds\ThongKe.cshtml"
                                           Write(sl);

#line default
#line hidden
            EndContext();
            BeginContext(2502, 52, true);
            WriteLiteral("</td>\n                                        </tr>\n");
            EndContext();
#line 56 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\ChiTietHds\ThongKe.cshtml"
                                    }
                                }
                            }
                        

#line default
#line hidden
            BeginContext(2682, 138, true);
            WriteLiteral("                    </tbody>\n                </table>\n                <!-- /.table-responsive -->\n                <pre><b>Tổng doanh thu: ");
            EndContext();
            BeginContext(2821, 32, false);
#line 63 "C:\Users\DELL\Desktop\Obaju\WebOnline\Views\ChiTietHds\ThongKe.cshtml"
                                   Write(tongtien.Value.ToString("#,##0"));

#line default
#line hidden
            EndContext();
            BeginContext(2853, 166, true);
            WriteLiteral(" VNĐ</b></pre>\n            </div>\n            <!-- /.panel-body -->\n        </div>\n        <!-- /.panel -->\n    </div>\n    <!-- /.col-lg-12 -->\n</div>\n<!-- /.row -->\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebOnline.Models.ChiTietHd>> Html { get; private set; }
    }
}
#pragma warning restore 1591
