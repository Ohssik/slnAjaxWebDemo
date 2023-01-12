using System;
using System.Collections.Generic;

namespace CoreAPI.Models
{
    public partial class OrderItem
    {
        public int? OrderFid { get; set; }
        public string? ItemId { get; set; }
    }
}
