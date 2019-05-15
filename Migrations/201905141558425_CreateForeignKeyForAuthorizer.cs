namespace MLPSApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateForeignKeyForAuthorizer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authorizers", "LoanDetailId", c => c.Int(nullable: false));
            AddColumn("dbo.Authorizers", "PropertyDetailId", c => c.Int(nullable: false));
            CreateIndex("dbo.Authorizers", "LoanDetailId");
            CreateIndex("dbo.Authorizers", "PropertyDetailId");
            AddForeignKey("dbo.Authorizers", "LoanDetailId", "dbo.LoanDetails", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Authorizers", "PropertyDetailId", "dbo.PropertyDetails", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Authorizers", "PropertyDetailId", "dbo.PropertyDetails");
            DropForeignKey("dbo.Authorizers", "LoanDetailId", "dbo.LoanDetails");
            DropIndex("dbo.Authorizers", new[] { "PropertyDetailId" });
            DropIndex("dbo.Authorizers", new[] { "LoanDetailId" });
            DropColumn("dbo.Authorizers", "PropertyDetailId");
            DropColumn("dbo.Authorizers", "LoanDetailId");
        }
    }
}
