namespace QuanLySinhVien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KetQuaThis",
                c => new
                    {
                        MaSV = c.String(nullable: false, maxLength: 10),
                        MaMH = c.String(nullable: false, maxLength: 10),
                        DiemThi = c.Single(nullable: false),
                    })
                .PrimaryKey(t => new { t.MaSV, t.MaMH })
                .ForeignKey("dbo.MonHocs", t => t.MaMH, cascadeDelete: true)
                .ForeignKey("dbo.SinhViens", t => t.MaSV, cascadeDelete: true)
                .Index(t => t.MaSV)
                .Index(t => t.MaMH);
            
            CreateTable(
                "dbo.MonHocs",
                c => new
                    {
                        MaMH = c.String(nullable: false, maxLength: 10),
                        TenMon = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.MaMH);
            
            CreateTable(
                "dbo.SinhViens",
                c => new
                    {
                        MSSV = c.String(nullable: false, maxLength: 10),
                        HoTen = c.String(nullable: false, maxLength: 50),
                        NgaySinh = c.DateTime(nullable: false),
                        GioiTinh = c.Boolean(nullable: false),
                        MaLop = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.MSSV)
                .ForeignKey("dbo.Lops", t => t.MaLop)
                .Index(t => t.MaLop);
            
            CreateTable(
                "dbo.Lops",
                c => new
                    {
                        MaLop = c.String(nullable: false, maxLength: 10),
                        TenLop = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.MaLop);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SinhViens", "MaLop", "dbo.Lops");
            DropForeignKey("dbo.KetQuaThis", "MaSV", "dbo.SinhViens");
            DropForeignKey("dbo.KetQuaThis", "MaMH", "dbo.MonHocs");
            DropIndex("dbo.SinhViens", new[] { "MaLop" });
            DropIndex("dbo.KetQuaThis", new[] { "MaMH" });
            DropIndex("dbo.KetQuaThis", new[] { "MaSV" });
            DropTable("dbo.Lops");
            DropTable("dbo.SinhViens");
            DropTable("dbo.MonHocs");
            DropTable("dbo.KetQuaThis");
        }
    }
}
