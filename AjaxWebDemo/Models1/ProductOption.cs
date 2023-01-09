﻿using System;
using System.Collections.Generic;

namespace AjaxWebDemo.Models1
{
    public partial class ProductOption
    {
        public int Fid { get; set; }
        public string? OptionName { get; set; }
        public int? OptionGroupFid { get; set; }
        public int? BFid { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? Qty { get; set; }
    }
}
