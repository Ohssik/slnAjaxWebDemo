﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CoreAPI.Models
{
    public partial class Coupons
    {
        public int Id { get; set; }
        public string CouponCode { get; set; }
        public int? Type { get; set; }
        public int? BFid { get; set; }
        public decimal? Price { get; set; }
    }
}