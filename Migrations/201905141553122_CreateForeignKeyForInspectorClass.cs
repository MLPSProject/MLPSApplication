namespace MLPSApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateForeignKeyForInspectorClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Inspectors", "RegisteredUserId", c => c.Int(nullable: false));
            AddColumn("dbo.Inspectors", "UnRegisteredUserId", c => c.Int(nullable: false));
            AddColumn("dbo.Inspectors", "PropertyDetailId", c => c.Int(nullable: false));
            CreateIndex("dbo.Inspectors", "RegisteredUserId");
            CreateIndex("dbo.Inspectors", "UnRegisteredUserId");
            CreateIndex("dbo.Inspectors", "PropertyDetailId");
            AddForeignKey("dbo.Inspectors", "PropertyDetailId", "dbo.PropertyDetails", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Inspectors", "RegisteredUserId", "dbo.RegisteredUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Inspectors", "UnRegisteredUserId", "dbo.UnRegisteredUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Inspectors", "UnRegisteredUserId", "dbo.UnRegisteredUsers");
            DropForeignKey("dbo.Inspectors", "RegisteredUserId", "dbo.RegisteredUsers");
            DropForeignKey("dbo.Inspectors", "PropertyDetailId", "dbo.PropertyDetails");
            DropIndex("dbo.Inspectors", new[] { "PropertyDetailId" });
            DropIndex("dbo.Inspectors", new[] { "UnRegisteredUserId" });
            DropIndex("dbo.Inspectors", new[] { "RegisteredUserId" });
            DropColumn("dbo.Inspectors", "PropertyDetailId");
            DropColumn("dbo.Inspectors", "UnRegisteredUserId");
            DropColumn("dbo.Inspectors", "RegisteredUserId");
        }
    }
}
