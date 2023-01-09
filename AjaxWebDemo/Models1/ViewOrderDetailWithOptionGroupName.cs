using System;
using System.Collections.Generic;

namespace AjaxWebDemo.Models1
{
    public partial class ViewOrderDetailWithOptionGroupName
    {
        public int? OrderFid { get; set; }
        public int? ProductFid { get; set; }
        public string? ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? Qty { get; set; }
        public string? OptionGroupName { get; set; }
        public string? OptionName { get; set; }
    }
}
