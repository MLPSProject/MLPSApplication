namespace MLPSApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateForeignKeyForLoanDetailClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LoanDetails", "PropertyDetailId", c => c.Int(nullable: false));
            CreateIndex("dbo.LoanDetails", "PropertyDetailId");
            AddForeignKey("dbo.LoanDetails", "PropertyDetailId", "dbo.PropertyDetails", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LoanDetails", "PropertyDetailId", "dbo.PropertyDetails");
            DropIndex("dbo.LoanDetails", new[] { "PropertyDetailId" });
            DropColumn("dbo.LoanDetails", "PropertyDetailId");
        }
    }
}
