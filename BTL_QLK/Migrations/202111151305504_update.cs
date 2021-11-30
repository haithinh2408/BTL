namespace BTL_QLK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HangHoa", "XuatXu", c => c.String());
            AddColumn("dbo.HangHoa", "NgaySX", c => c.DateTime(nullable: false));
            AddColumn("dbo.HangHoa", "HanSD", c => c.DateTime(nullable: false));
            AddColumn("dbo.HangHoa", "GiaBan", c => c.Int(nullable: false));
            AddColumn("dbo.HangHoa", "DonViTinh", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.HangHoa", "DonViTinh");
            DropColumn("dbo.HangHoa", "GiaBan");
            DropColumn("dbo.HangHoa", "HanSD");
            DropColumn("dbo.HangHoa", "NgaySX");
            DropColumn("dbo.HangHoa", "XuatXu");
        }
    }
}
