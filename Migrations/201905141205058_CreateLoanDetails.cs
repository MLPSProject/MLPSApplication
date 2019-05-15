namespace MLPSApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateLoanDetails : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LoanDetails",
                c => new
                    {
                        LId = c.Int(nullable: false, identity: true),
                        vName = c.String(),
                        vMobile = c.String(),
                        vEmail = c.String(),
                        vCity = c.String(),
                        iAge = c.Int(nullable: false),
                        vOccupation = c.String(),
                        vAddress = c.String(),
                        dLoanAmount = c.Double(nullable: false),
                        iRateOfInterest = c.Int(nullable: false),
                        dtLoanAppliedDate = c.DateTime(nullable: false),
                        dtLoanApprovedDate = c.DateTime(nullable: false),
                        iDuration = c.Int(nullable: false),
                        vStatus = c.String(),
                        RegisteredUserId = c.Int(nullable: false),
                        UnRegisteredUserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LId)
                .ForeignKey("dbo.RegisteredUsers", t => t.RegisteredUserId, cascadeDelete: true)
                .ForeignKey("dbo.UnRegisteredUsers", t => t.UnRegisteredUserId, cascadeDelete: true)
                .Index(t => t.RegisteredUserId)
                .Index(t => t.UnRegisteredUserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LoanDetails", "UnRegisteredUserId", "dbo.UnRegisteredUsers");
            DropForeignKey("dbo.LoanDetails", "RegisteredUserId", "dbo.RegisteredUsers");
            DropIndex("dbo.LoanDetails", new[] { "UnRegisteredUserId" });
            DropIndex("dbo.LoanDetails", new[] { "RegisteredUserId" });
            DropTable("dbo.LoanDetails");
        }
    }
}
