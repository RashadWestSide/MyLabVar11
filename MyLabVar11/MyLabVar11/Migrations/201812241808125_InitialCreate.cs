namespace MyLabVar11.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Descriptions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DescrText = c.String(),
                        FirmId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Firms", t => t.FirmId, cascadeDelete: true)
                .Index(t => t.FirmId);
            
            CreateTable(
                "dbo.Firms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameF = c.String(),
                        TypeFirm = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Descriptions", "FirmId", "dbo.Firms");
            DropIndex("dbo.Descriptions", new[] { "FirmId" });
            DropTable("dbo.Firms");
            DropTable("dbo.Descriptions");
        }
    }
}
