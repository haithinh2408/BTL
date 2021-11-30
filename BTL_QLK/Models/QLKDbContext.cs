using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BTL_QLK.Models
{
    public partial class QLKDbContext : DbContext

    {
        public QLKDbContext() : base("name= QLKDbcontext")
        {
        }
        public virtual DbSet<HangHoa> HangHoas { get; set; }
        public virtual DbSet<KiemKeHang> KiemKeHangs { get; set; }
        public virtual DbSet<NhapHang> NhapHangs { get; set; }
        public virtual DbSet<XuatHang> XuatHangs { get; set; }
         public virtual DbSet<PhieuNhapHang> PhieuNhapHangs { get; set; }
        public virtual DbSet<PhieuXuatHang> PhieuXuatHangs { get; set; }
        public virtual DbSet<PhieuTraHang> PhieuTraHangs { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HangHoa>()
         .Property(e => e.MaHang)
         .IsUnicode(false);
            // modelBuilder.Entity<Student>().Property(e => e.StudentID).IsUnicode(false);
        }

      
    }
}






