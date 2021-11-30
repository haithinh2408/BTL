namespace BTL_QLK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_table_HangHoa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HangHoa",
                c => new
                    {
                        MaHang = c.String(nullable: false, maxLength: 128, unicode: false),
                        TenHang = c.String(),
                        ChungLoai = c.String(),
                    })
                .PrimaryKey(t => t.MaHang);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HangHoa");
        }
    }
}
