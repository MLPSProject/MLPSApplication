namespace MLPSApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateForeignKeyForMortgageOfficer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MortgageOfficers", "AuthorizerId", c => c.Int(nullable: false));
            CreateIndex("dbo.MortgageOfficers", "AuthorizerId");
            AddForeignKey("dbo.MortgageOfficers", "AuthorizerId", "dbo.Authorizers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MortgageOfficers", "AuthorizerId", "dbo.Authorizers");
            DropIndex("dbo.MortgageOfficers", new[] { "AuthorizerId" });
            DropColumn("dbo.MortgageOfficers", "AuthorizerId");
        }
    }
}
