using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTL_QLK.Models
{
    [Table("KiemKeHang")]
    public class KiemKeHang
    {
        [Key]
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public int SoLuong { get; set; }
        public string NhaSX { get; set; }
        public string TinhTrang { get; set; }
        public int DonGia { get; set; }



    }
}