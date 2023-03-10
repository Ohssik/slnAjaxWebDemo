using System;
using System.Collections.Generic;

namespace AjaxWebDemo.Models1
{
    public partial class Order
    {
        public int Fid { get; set; }
        public int? NFid { get; set; }
        public int? BFid { get; set; }
        public string? BMemberName { get; set; }
        public string? BMemberPhone { get; set; }
        public DateTime? PickUpDate { get; set; }
        public TimeSpan? PickUpTime { get; set; }
        public string? PickUpType { get; set; }
        public string? PlasticBag { get; set; }
        public string? PickUpPerson { get; set; }
        public string? PickUpPersonPhone { get; set; }
        public string? PaymentTerm { get; set; }
        public string? TaxIdnum { get; set; }
        public string? OrderState { get; set; }
        public string? Memo { get; set; }
        public DateTime? OrderTime { get; set; }
        public decimal? TotalAmount { get; set; }
        public string? OrderPrefix { get; set; }
        public string? OrderISerialId { get; set; }
    }
}
