using System;
using System.Collections.Generic;

namespace AjaxWebDemo.Models1
{
    public partial class Menu
    {
        public int Fid { get; set; }
        public string? MenuName { get; set; }
        public int? BFid { get; set; }
        public string? IsForSale { get; set; }
        public string? Memo { get; set; }
    }
}
