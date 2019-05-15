namespace MLPSApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateInspector : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Inspectors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        vName = c.String(),
                        vMobile = c.String(),
                        vEmail = c.String(),
                        MortgageOfficerId = c.Int(nullable: false),
                        RegisteredUserId = c.Int(nullable: false),
                        UnRegisteredUserId = c.Int(nullable: false),
                        PropertyDetailId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MortgageOfficers", t => t.MortgageOfficerId, cascadeDelete: true)
                .ForeignKey("dbo.PropertyDetails", t => t.PropertyDetailId, cascadeDelete: true)
                .ForeignKey("dbo.RegisteredUsers", t => t.RegisteredUserId, cascadeDelete: true)
                .ForeignKey("dbo.UnRegisteredUsers", t => t.UnRegisteredUserId, cascadeDelete: true)
                .Index(t => t.MortgageOfficerId)
                .Index(t => t.RegisteredUserId)
                .Index(t => t.UnRegisteredUserId)
                .Index(t => t.PropertyDetailId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Inspectors", "UnRegisteredUserId", "dbo.UnRegisteredUsers");
            DropForeignKey("dbo.Inspectors", "RegisteredUserId", "dbo.RegisteredUsers");
            DropForeignKey("dbo.Inspectors", "PropertyDetailId", "dbo.PropertyDetails");
            DropForeignKey("dbo.Inspectors", "MortgageOfficerId", "dbo.MortgageOfficers");
            DropIndex("dbo.Inspectors", new[] { "PropertyDetailId" });
            DropIndex("dbo.Inspectors", new[] { "UnRegisteredUserId" });
            DropIndex("dbo.Inspectors", new[] { "RegisteredUserId" });
            DropIndex("dbo.Inspectors", new[] { "MortgageOfficerId" });
            DropTable("dbo.Inspectors");
        }
    }
}
