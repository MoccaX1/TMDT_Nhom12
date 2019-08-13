using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BraintreeHttp;
using Microsoft.AspNetCore.Mvc;
using PayPal.Core;
using PayPal.v1.Payments;
using WebOnline.Helper;
using WebOnline.Models;


namespace WebOnline.Controllers
{
    //public static int mahoadon;
    public class PaypalController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        //private readonly MyPhamContext db;

        public List<CartItem> Cart
        {
            get
            {
                var data = HttpContext.Session.GetObject<List<CartItem>>("GioHang");
                if (data == null)
                {
                    data = new List<CartItem>();
                }

                return data;
            }
        }

        public async Task<IActionResult> Checkout()
        {
            //SandboxEnvironment(clientId, clientSerect)
            var environment = new SandboxEnvironment("AUNjhKSRWAeuGkhZiirkb4WTumWTiHNqDA8VhKJTBGSdkStz_yeaUSDUuXPRdB4xaRUBH8hF-RN5VV_7", "EK_MlatUODbTy9j245slG18LLqs26mWaEMnqn40Clw99oc0EZND-YYow1MMaq3WiLNFFPgPacZyHzwxy");
            var client = new PayPalHttpClient(environment);

            //Đọc thông tin đơn hàng từ Session
            var itemList = new ItemList()
            {
                Items = new List<Item>()
            };

            var tongTien = Cart.Sum(p => p.ThanhTien);
            foreach (var item in Cart)
            {
                itemList.Items.Add(new Item()
                {
                    Name = item.TenHh,
                    Currency = "USD",
                    Price = item.GiaBan.ToString(),
                    Quantity = item.SoLuong.ToString(),
                    Sku = "sku",
                    Tax = "0"
                });
            }

            var payment = new Payment()
            {
                Intent = "sale",
                Transactions = new List<Transaction>()
                {
                    new Transaction()
                    {
                        Amount = new Amount()
                        {
                            Total = tongTien.ToString(),
                            Currency = "USD",
                            Details = new AmountDetails
                            {
                                Tax = "0",
                                Shipping = "0",
                                Subtotal = tongTien.ToString()
                            }
                        },
                        ItemList = itemList,
                        Description = "Don hang 01",
                        InvoiceNumber = DateTime.Now.Ticks.ToString()
                    }
                },
                RedirectUrls = new RedirectUrls()
                {
                    CancelUrl = "http://localhost:54396/Paypal/Fail",
                    ReturnUrl = "http://localhost:54396/Paypal/Success"
                },
                Payer = new Payer()
                {
                    PaymentMethod = "paypal"
                }
            };

            PaymentCreateRequest request = new PaymentCreateRequest();
            request.RequestBody(payment);

            try
            {
                HttpResponse response = await client.Execute(request);
                var statusCode = response.StatusCode;
                Payment result = response.Result<Payment>();

                var links = result.Links.GetEnumerator();
                string paypalRedirectUrl = null;
                while (links.MoveNext())
                {
                    LinkDescriptionObject lnk = links.Current;
                    if (lnk.Rel.ToLower().Trim().Equals("approval_url"))
                    {
                        //saving the payapalredirect URL to which user will be redirected for payment  
                        paypalRedirectUrl = lnk.Href;
                    }
                }

                return Redirect(paypalRedirectUrl);

            }
            catch (HttpException httpException)
            {
                var statusCode = httpException.StatusCode;
                var debugId = httpException.Headers.GetValues("PayPal-Debug-Id").FirstOrDefault();

                return RedirectToAction("Fail");
            }

            // return View();
        }

        public IActionResult Success()/*(int maHH, string tenkh, string tenHH, int soluong, string pttt)*/
        {
            //Tạo đơn hàng trong CSDL với trạng thái : Đã thanh toán, phương thức: Paypal
            //Lưu đơn hàng

            //HoaDon dh = new HoaDon
            //{
                
            //};
            //Insert(dh);
            //db.DonHangs.Add(dh);
            ////Lưu chi tiết đơn hàng
            //foreach (var item in Cart)
            //{
            //    ChitietDH ct = db.ChitietDHs.SingleOrDefault(p => p.MaHh == item.HangHoa.MaHh);

            //    ChitietDH ctdh = new ChitietDH
            //    {
            //        MaDH = dh.MaDH,
            //        MaHh = item.HangHoa.MaHh,
            //        TenHH = ct.TenHH,
            //        SL = item.SoLuong,
            //        ThanhTien = 1000,
            //        TrangThai = 1,
            //        PTTT = "PayPal"
            //    };
            //    db.ChitietDHs.Add(ctdh);
            //    db.SaveChanges();
            //}

            return Content("Thanh toán thành công");
        }

        public IActionResult Fail()
        {
            //Tạo đơn hàng trong CSDL với trạng thái : Chưa thanh toán, phương thức: 
            return Content("Thanh toán thất bại");
        }

    }
}