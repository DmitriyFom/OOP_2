namespace OOP_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DJEquipments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Brand = c.String(),
                        Power = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Mixers",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        GainLevel = c.Int(nullable: false),
                        MixerType = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DJEquipments", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Speed = c.Int(nullable: false),
                        Scratch = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DJEquipments", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "Id", "dbo.DJEquipments");
            DropForeignKey("dbo.Mixers", "Id", "dbo.DJEquipments");
            DropIndex("dbo.Players", new[] { "Id" });
            DropIndex("dbo.Mixers", new[] { "Id" });
            DropTable("dbo.Players");
            DropTable("dbo.Mixers");
            DropTable("dbo.DJEquipments");
        }
    }
}
