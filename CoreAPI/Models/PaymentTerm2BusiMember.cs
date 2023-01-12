using System;
using System.Collections.Generic;

namespace CoreAPI.Models
{
    public partial class PaymentTerm2BusiMember
    {
        public int? BFid { get; set; }
        public int? PayTermCatId { get; set; }
        public decimal? PayAmountLimit { get; set; }
    }
}
