namespace MLPSApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateForeignKeyForInspector : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Inspectors", "PropertyDetailId", c => c.Int(nullable: false));
            CreateIndex("dbo.Inspectors", "PropertyDetailId");
            AddForeignKey("dbo.Inspectors", "PropertyDetailId", "dbo.PropertyDetails", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Inspectors", "PropertyDetailId", "dbo.PropertyDetails");
            DropIndex("dbo.Inspectors", new[] { "PropertyDetailId" });
            DropColumn("dbo.Inspectors", "PropertyDetailId");
        }
    }
}
