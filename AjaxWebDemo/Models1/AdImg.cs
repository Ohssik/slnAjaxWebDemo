using System;
using System.Collections.Generic;

namespace AjaxWebDemo.Models1
{
    public partial class AdImg
    {
        public int Fid { get; set; }
        public string? ImgName { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string? Hyperlink { get; set; }
        public int? BFid { get; set; }
    }
}
