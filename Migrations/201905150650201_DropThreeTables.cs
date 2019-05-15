namespace MLPSApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropThreeTables : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MortgageOfficers", "AuthorizerId", "dbo.Authorizers");
            DropForeignKey("dbo.MortgageOfficers", "InspectorId", "dbo.Inspectors");
            DropForeignKey("dbo.MortgageOfficers", "LoanDetailId", "dbo.LoanDetails");
            DropForeignKey("dbo.MortgageOfficers", "PropertyDetailId", "dbo.PropertyDetails");
            DropIndex("dbo.MortgageOfficers", new[] { "InspectorId" });
            DropIndex("dbo.MortgageOfficers", new[] { "LoanDetailId" });
            DropIndex("dbo.MortgageOfficers", new[] { "PropertyDetailId" });
            DropIndex("dbo.MortgageOfficers", new[] { "AuthorizerId" });
            DropTable("dbo.Authorizers");
            DropTable("dbo.Inspectors");
            DropTable("dbo.MortgageOfficers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.MortgageOfficers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        vName = c.String(),
                        vEmail = c.String(),
                        Password = c.String(),
                        InspectorId = c.Int(nullable: false),
                        LoanDetailId = c.Int(nullable: false),
                        PropertyDetailId = c.Int(nullable: false),
                        AuthorizerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Inspectors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        vName = c.String(),
                        vMobile = c.String(),
                        vEmail = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Authorizers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        vName = c.String(),
                        vMobile = c.String(),
                        vEmailID = c.String(),
                        iApprovedLoanAmount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.MortgageOfficers", "AuthorizerId");
            CreateIndex("dbo.MortgageOfficers", "PropertyDetailId");
            CreateIndex("dbo.MortgageOfficers", "LoanDetailId");
            CreateIndex("dbo.MortgageOfficers", "InspectorId");
            AddForeignKey("dbo.MortgageOfficers", "PropertyDetailId", "dbo.PropertyDetails", "Id", cascadeDelete: true);
            AddForeignKey("dbo.MortgageOfficers", "LoanDetailId", "dbo.LoanDetails", "Id", cascadeDelete: true);
            AddForeignKey("dbo.MortgageOfficers", "InspectorId", "dbo.Inspectors", "Id", cascadeDelete: true);
            AddForeignKey("dbo.MortgageOfficers", "AuthorizerId", "dbo.Authorizers", "Id", cascadeDelete: true);
        }
    }
}
