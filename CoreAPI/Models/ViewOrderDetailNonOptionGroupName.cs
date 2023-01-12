using System;
using System.Collections.Generic;

namespace CoreAPI.Models
{
    public partial class ViewOrderDetailNonOptionGroupName
    {
        public string? Itemid { get; set; }
        public int? ProductFId { get; set; }
        public string? ProductName { get; set; }
        public decimal? ProductUp { get; set; }
        public int? Qty { get; set; }
        public string? Options { get; set; }
        public decimal? OptionUp { get; set; }
    }
}
