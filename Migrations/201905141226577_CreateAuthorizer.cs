namespace MLPSApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAuthorizer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authorizers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        vName = c.String(),
                        vMobile = c.String(),
                        vEmailID = c.String(),
                        iApprovedLoanAmount = c.Int(nullable: false),
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
            DropForeignKey("dbo.Authorizers", "PropertyDetailId", "dbo.PropertyDetails");
            DropForeignKey("dbo.Authorizers", "LoanDetail_LId", "dbo.LoanDetails");
            DropIndex("dbo.Authorizers", new[] { "LoanDetail_LId" });
            DropIndex("dbo.Authorizers", new[] { "PropertyDetailId" });
            DropTable("dbo.Authorizers");
        }
    }
}
