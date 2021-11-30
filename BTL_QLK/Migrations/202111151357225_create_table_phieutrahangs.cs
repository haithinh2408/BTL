namespace BTL_QLK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_phieutrahangs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PhieuTraHang",
                c => new
                    {
                        MaPhieu = c.String(nullable: false, maxLength: 128),
                        NguoiTao = c.String(),
                        NgayTao = c.DateTime(nullable: false),
                        MaHang = c.String(),
                        TenHang = c.String(),
                        SoLuong = c.Int(nullable: false),
                        NhaSX = c.String(),
                        LyDoTraHang = c.String(),
                    })
                .PrimaryKey(t => t.MaPhieu);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PhieuTraHang");
        }
    }
}
