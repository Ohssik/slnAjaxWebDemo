﻿using System;
using System.Collections.Generic;

namespace CoreAPI.Models
{
    public partial class BusinessMember
    {
        public int Fid { get; set; }
        public string? MemberName { get; set; }
        public string? Brand { get; set; }
        public string? Phone { get; set; }
        public string? Password { get; set; }
        public TimeSpan? OpenTime { get; set; }
        public TimeSpan? CloseTime { get; set; }
        public string? Address { get; set; }
        public string? ShopType { get; set; }
        public string? Email { get; set; }
        public DateTime? RegisterTime { get; set; }
        public string? ContactPerson { get; set; }
        public string? MemberAccount { get; set; }
        public int? IsSuspensed { get; set; }
        public int? EmailCertified { get; set; }
        public string? Gps { get; set; }
    }
}
