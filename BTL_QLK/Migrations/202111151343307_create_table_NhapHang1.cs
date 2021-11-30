namespace BTL_QLK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_NhapHang1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KiemKeHang",
                c => new
                    {
                        MaHang = c.String(nullable: false, maxLength: 128),
                        TenHang = c.String(),
                        SoLuong = c.Int(nullable: false),
                        NhaSX = c.String(),
                        TinhTrang = c.String(),
                        DonGia = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaHang);
            
            CreateTable(
                "dbo.PhieuXuatHang",
                c => new
                    {
                        MaSoPhieu = c.String(nullable: false, maxLength: 128),
                        NguoiTao = c.String(),
                        NgayTao = c.DateTime(nullable: false),
                        MaHang = c.String(),
                        TenHang = c.String(),
                        SoLuong = c.Int(nullable: false),
                        NhaSX = c.String(),
                        LiDoXuat = c.String(),
                    })
                .PrimaryKey(t => t.MaSoPhieu);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PhieuXuatHang");
            DropTable("dbo.KiemKeHang");
        }
    }
}
