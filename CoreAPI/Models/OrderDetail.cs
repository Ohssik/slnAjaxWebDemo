using System;
using System.Collections.Generic;

namespace CoreAPI.Models
{
    public partial class OrderDetail
    {
        public string? ItemId { get; set; }
        public int? ProductFid { get; set; }
        public int? OptionFid { get; set; }
        public int? OptionGroupFid { get; set; }
        public string? ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? Qty { get; set; }
    }
}
