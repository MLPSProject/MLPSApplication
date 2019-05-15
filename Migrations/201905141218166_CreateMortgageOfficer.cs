namespace MLPSApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMortgageOfficer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MortgageOfficers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        vName = c.String(),
                        vEmail = c.String(),
                        Password = c.String(),
                        LoanDetailId = c.Int(nullable: false),
                        PropertyDetailId = c.Int(nullable: false),
                        LoanDetail_LId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.LoanDetails", t => t.LoanDetail_LId)
                .ForeignKey("dbo.PropertyDetails", t => t.PropertyDetailId, cascadeDelete: true)
                .Index(t => t.PropertyDetailId)
                .Index(t => t.LoanDetail_LId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MortgageOfficers", "PropertyDetailId", "dbo.PropertyDetails");
            DropForeignKey("dbo.MortgageOfficers", "LoanDetail_LId", "dbo.LoanDetails");
            DropIndex("dbo.MortgageOfficers", new[] { "LoanDetail_LId" });
            DropIndex("dbo.MortgageOfficers", new[] { "PropertyDetailId" });
            DropTable("dbo.MortgageOfficers");
        }
    }
}
