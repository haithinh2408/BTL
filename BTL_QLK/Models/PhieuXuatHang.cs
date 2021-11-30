using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTL_QLK.Models
{
    [Table("PhieuXuatHang")]
    public class PhieuXuatHang
    {
        [Key]
        public string MaSoPhieu { get; set; }
        public string NguoiTao { get; set; }
        public DateTime NgayTao { get; set; }
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public int SoLuong { get; set; }
        public string NhaSX { get; set; }
        public string LiDoXuat { get; set; }


    }
}