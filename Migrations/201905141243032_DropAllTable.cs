namespace MLPSApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropAllTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.LoanDetails", "PropertyDetailId", "dbo.PropertyDetails");
            DropForeignKey("dbo.LoanDetails", "RegisteredUserId", "dbo.RegisteredUsers");
            DropForeignKey("dbo.LoanDetails", "UnRegisteredUserId", "dbo.UnRegisteredUsers");
            DropForeignKey("dbo.Authorizers", "LoanDetail_LId", "dbo.LoanDetails");
            DropForeignKey("dbo.Authorizers", "PropertyDetailId", "dbo.PropertyDetails");
            DropForeignKey("dbo.MortgageOfficers", "LoanDetail_LId", "dbo.LoanDetails");
            DropForeignKey("dbo.MortgageOfficers", "PropertyDetailId", "dbo.PropertyDetails");
            DropForeignKey("dbo.Inspectors", "MortgageOfficerId", "dbo.MortgageOfficers");
            DropForeignKey("dbo.Inspectors", "RegisteredUserId", "dbo.RegisteredUsers");
            DropForeignKey("dbo.Inspectors", "UnRegisteredUserId", "dbo.UnRegisteredUsers");
            DropIndex("dbo.Authorizers", new[] { "PropertyDetailId" });
            DropIndex("dbo.Authorizers", new[] { "LoanDetail_LId" });
            DropIndex("dbo.LoanDetails", new[] { "RegisteredUserId" });
            DropIndex("dbo.LoanDetails", new[] { "UnRegisteredUserId" });
            DropIndex("dbo.LoanDetails", new[] { "PropertyDetailId" });
            DropIndex("dbo.Inspectors", new[] { "MortgageOfficerId" });
            DropIndex("dbo.Inspectors", new[] { "RegisteredUserId" });
            DropIndex("dbo.Inspectors", new[] { "UnRegisteredUserId" });
            DropIndex("dbo.MortgageOfficers", new[] { "PropertyDetailId" });
            DropIndex("dbo.MortgageOfficers", new[] { "LoanDetail_LId" });
            DropTable("dbo.Authorizers");
            DropTable("dbo.LoanDetails");
            DropTable("dbo.PropertyDetails");
            DropTable("dbo.RegisteredUsers");
            DropTable("dbo.UnRegisteredUsers");
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
                        LoanDetailId = c.Int(nullable: false),
                        PropertyDetailId = c.Int(nullable: false),
                        LoanDetail_LId = c.Int(),
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
                        MortgageOfficerId = c.Int(nullable: false),
                        RegisteredUserId = c.Int(nullable: false),
                        UnRegisteredUserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UnRegisteredUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        dtDateOfRegistration = c.DateTime(nullable: false),
                        vFirstName = c.String(),
                        vLastName = c.String(),
                        dtDOB = c.DateTime(nullable: false),
                        vGender = c.String(),
                        vMobile = c.String(),
                        vEmailID = c.String(),
                        vOccupation = c.String(),
                        vCity = c.String(),
                        vAddress = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RegisteredUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        dtDateOfRegistration = c.DateTime(nullable: false),
                        vFirstName = c.String(),
                        vLastName = c.String(),
                        dtDOB = c.DateTime(nullable: false),
                        vGender = c.String(),
                        vMobile = c.String(),
                        vEmailID = c.String(),
                        vOccupation = c.String(),
                        vCity = c.String(),
                        vAddress = c.String(),
                        vPassword = c.String(),
                        vConfirmPassword = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PropertyDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        vPropertyHolderName = c.String(),
                        vPropertyType = c.String(),
                        PropertyAddress = c.String(),
                        iMarketValue = c.Int(nullable: false),
                        vRemarks = c.String(),
                        IdProof = c.String(),
                        AddressProof = c.String(),
                        PropertyAgreement = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
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
                        PropertyDetailId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LId);
            
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
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.MortgageOfficers", "LoanDetail_LId");
            CreateIndex("dbo.MortgageOfficers", "PropertyDetailId");
            CreateIndex("dbo.Inspectors", "UnRegisteredUserId");
            CreateIndex("dbo.Inspectors", "RegisteredUserId");
            CreateIndex("dbo.Inspectors", "MortgageOfficerId");
            CreateIndex("dbo.LoanDetails", "PropertyDetailId");
            CreateIndex("dbo.LoanDetails", "UnRegisteredUserId");
            CreateIndex("dbo.LoanDetails", "RegisteredUserId");
            CreateIndex("dbo.Authorizers", "LoanDetail_LId");
            CreateIndex("dbo.Authorizers", "PropertyDetailId");
            AddForeignKey("dbo.Inspectors", "UnRegisteredUserId", "dbo.UnRegisteredUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Inspectors", "RegisteredUserId", "dbo.RegisteredUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Inspectors", "MortgageOfficerId", "dbo.MortgageOfficers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.MortgageOfficers", "PropertyDetailId", "dbo.PropertyDetails", "Id", cascadeDelete: true);
            AddForeignKey("dbo.MortgageOfficers", "LoanDetail_LId", "dbo.LoanDetails", "LId");
            AddForeignKey("dbo.Authorizers", "PropertyDetailId", "dbo.PropertyDetails", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Authorizers", "LoanDetail_LId", "dbo.LoanDetails", "LId");
            AddForeignKey("dbo.LoanDetails", "UnRegisteredUserId", "dbo.UnRegisteredUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.LoanDetails", "RegisteredUserId", "dbo.RegisteredUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.LoanDetails", "PropertyDetailId", "dbo.PropertyDetails", "Id", cascadeDelete: true);
        }
    }
}
