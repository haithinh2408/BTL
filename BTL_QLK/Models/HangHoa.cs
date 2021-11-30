using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTL_QLK.Models
{
    [Table("HangHoa")]
    public class HangHoa
    {
        [Key]
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string ChungLoai { get; set; }
        public string XuatXu { get; set; }
        public DateTime NgaySX { get; set; }
        public DateTime HanSD { get; set; }
        public int GiaBan { get; set; }
        public string DonViTinh { get; set; }
    }
}