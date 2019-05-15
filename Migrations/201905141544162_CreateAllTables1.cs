namespace MLPSApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAllTables1 : DbMigration
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
                "dbo.LoanDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
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
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MortgageOfficers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        vName = c.String(),
                        vEmail = c.String(),
                        Password = c.String(),
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UnRegisteredUsers");
            DropTable("dbo.RegisteredUsers");
            DropTable("dbo.PropertyDetails");
            DropTable("dbo.MortgageOfficers");
            DropTable("dbo.LoanDetails");
            DropTable("dbo.Inspectors");
            DropTable("dbo.Authorizers");
        }
    }
}
