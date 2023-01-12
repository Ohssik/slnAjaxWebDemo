using System;
using System.Collections.Generic;

namespace CoreAPI.Models
{
    public partial class Coupon
    {
        public int Id { get; set; }
        public string? CouponCode { get; set; }
        public decimal? Price { get; set; }
        public int? IsUsed { get; set; }
        public string? Memo { get; set; }
    }
}
