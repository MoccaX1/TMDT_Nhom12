using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebOnline.Models
{
    public partial class Loai
    {
        public Loai()
        {
            SanPham = new HashSet<SanPham>();
        }

        [Display(Name = "Mã loại")]
        public int MaLoai { get; set; }
        [Display(Name = "Tên loại")]
        public string TenLoai { get; set; }
        [Display(Name = "Tên loại không dấu")]
        public string TenLoaiAlias { get; set; }
        [Display(Name = "Mô tả")]
        public string MoTa { get; set; }

        public ICollection<SanPham> SanPham { get; set; }
    }
}
