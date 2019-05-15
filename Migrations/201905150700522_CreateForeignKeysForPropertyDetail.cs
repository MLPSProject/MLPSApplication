namespace MLPSApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateForeignKeysForPropertyDetail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PropertyDetails", "OfficerId", c => c.Int());
            AddColumn("dbo.PropertyDetails", "InspectorId", c => c.Int());
            AddColumn("dbo.PropertyDetails", "AuthorizerId", c => c.Int());
            CreateIndex("dbo.PropertyDetails", "OfficerId");
            CreateIndex("dbo.PropertyDetails", "InspectorId");
            CreateIndex("dbo.PropertyDetails", "AuthorizerId");
            AddForeignKey("dbo.PropertyDetails", "AuthorizerId", "dbo.Employees", "Id");
            AddForeignKey("dbo.PropertyDetails", "InspectorId", "dbo.Employees", "Id");
            AddForeignKey("dbo.PropertyDetails", "OfficerId", "dbo.Employees", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PropertyDetails", "OfficerId", "dbo.Employees");
            DropForeignKey("dbo.PropertyDetails", "InspectorId", "dbo.Employees");
            DropForeignKey("dbo.PropertyDetails", "AuthorizerId", "dbo.Employees");
            DropIndex("dbo.PropertyDetails", new[] { "AuthorizerId" });
            DropIndex("dbo.PropertyDetails", new[] { "InspectorId" });
            DropIndex("dbo.PropertyDetails", new[] { "OfficerId" });
            DropColumn("dbo.PropertyDetails", "AuthorizerId");
            DropColumn("dbo.PropertyDetails", "InspectorId");
            DropColumn("dbo.PropertyDetails", "OfficerId");
        }
    }
}
