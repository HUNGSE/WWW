namespace EntityFrameWork_HungSE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SV1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LopHocPhans", "tenLopHocPhan", c => c.String());
            AddColumn("dbo.SinhViens", "tenSinhVien", c => c.String());
            AddColumn("dbo.SinhViens", "soDienThoai", c => c.String());
            DropColumn("dbo.LopHocPhans", "Name");
            DropColumn("dbo.SinhViens", "Name");
            DropColumn("dbo.SinhViens", "PhoneNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SinhViens", "PhoneNumber", c => c.String());
            AddColumn("dbo.SinhViens", "Name", c => c.String());
            AddColumn("dbo.LopHocPhans", "Name", c => c.String());
            DropColumn("dbo.SinhViens", "soDienThoai");
            DropColumn("dbo.SinhViens", "tenSinhVien");
            DropColumn("dbo.LopHocPhans", "tenLopHocPhan");
        }
    }
}
