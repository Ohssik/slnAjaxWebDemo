using System;
using System.Collections.Generic;

namespace AjaxWebDemo.Models1
{
    public partial class ViewOrderDetailNonOptionGroupName
    {
        public int? OrderFId { get; set; }
        public int? ProductFId { get; set; }
        public string? ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? Qty { get; set; }
        public string? Options { get; set; }
    }
}
