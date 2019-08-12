using System;
using System.Collections.Generic;

namespace WebOnline.Models
{
    public partial class LoaiBlog
    {
        public LoaiBlog()
        {
            Blog = new HashSet<Blog>();
        }

        public int MaLoaiBlog { get; set; }
        public string TenLoaiBlog { get; set; }
        public string MoTa { get; set; }
        public ICollection<Blog> Blog { get; set; }
    }
}
