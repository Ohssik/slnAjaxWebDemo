using System;
using System.Collections.Generic;

namespace AjaxWebDemo.Models1
{
    public partial class BusinessMember
    {
        public int Fid { get; set; }
        public string? MemberName { get; set; }
        public string? Brand { get; set; }
        public string? Phone { get; set; }
        public string? Password { get; set; }
        public string? OpenTime { get; set; }
        public string? CloseTime { get; set; }
        public string? Address { get; set; }
        public string? ShopType { get; set; }
        public string? Email { get; set; }
        public decimal? DeliveryAmount { get; set; }
        public DateTime? RegisterTime { get; set; }
        public string? ContactPerson { get; set; }
        public string? MemberId { get; set; }
    }
}
