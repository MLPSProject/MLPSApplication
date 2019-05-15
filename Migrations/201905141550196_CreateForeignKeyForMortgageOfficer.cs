namespace MLPSApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateForeignKeyForMortgageOfficer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MortgageOfficers", "InspectorId", c => c.Int(nullable: false));
            AddColumn("dbo.MortgageOfficers", "LoanDetailId", c => c.Int(nullable: false));
            AddColumn("dbo.MortgageOfficers", "PropertyDetailId", c => c.Int(nullable: false));
            AddColumn("dbo.MortgageOfficers", "AuthorizerId", c => c.Int(nullable: false));
            CreateIndex("dbo.MortgageOfficers", "InspectorId");
            CreateIndex("dbo.MortgageOfficers", "LoanDetailId");
            CreateIndex("dbo.MortgageOfficers", "PropertyDetailId");
            CreateIndex("dbo.MortgageOfficers", "AuthorizerId");
            AddForeignKey("dbo.MortgageOfficers", "AuthorizerId", "dbo.Authorizers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.MortgageOfficers", "InspectorId", "dbo.Inspectors", "Id", cascadeDelete: true);
            AddForeignKey("dbo.MortgageOfficers", "LoanDetailId", "dbo.LoanDetails", "Id", cascadeDelete: true);
            AddForeignKey("dbo.MortgageOfficers", "PropertyDetailId", "dbo.PropertyDetails", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MortgageOfficers", "PropertyDetailId", "dbo.PropertyDetails");
            DropForeignKey("dbo.MortgageOfficers", "LoanDetailId", "dbo.LoanDetails");
            DropForeignKey("dbo.MortgageOfficers", "InspectorId", "dbo.Inspectors");
            DropForeignKey("dbo.MortgageOfficers", "AuthorizerId", "dbo.Authorizers");
            DropIndex("dbo.MortgageOfficers", new[] { "AuthorizerId" });
            DropIndex("dbo.MortgageOfficers", new[] { "PropertyDetailId" });
            DropIndex("dbo.MortgageOfficers", new[] { "LoanDetailId" });
            DropIndex("dbo.MortgageOfficers", new[] { "InspectorId" });
            DropColumn("dbo.MortgageOfficers", "AuthorizerId");
            DropColumn("dbo.MortgageOfficers", "PropertyDetailId");
            DropColumn("dbo.MortgageOfficers", "LoanDetailId");
            DropColumn("dbo.MortgageOfficers", "InspectorId");
        }
    }
}
