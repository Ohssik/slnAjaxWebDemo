using System;
using System.Collections.Generic;

namespace CoreAPI.Models
{
    public partial class ProductImg
    {
        public int Fid { get; set; }
        public int? ProductFid { get; set; }
        public string? ImgPath { get; set; }
    }
}
