namespace MLPSApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePropertyDetail : DbMigration
    {
        public override void Up()
        {
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
            
            AddColumn("dbo.LoanDetails", "PropertyDetailId", c => c.Int(nullable: false));
            CreateIndex("dbo.LoanDetails", "PropertyDetailId");
            AddForeignKey("dbo.LoanDetails", "PropertyDetailId", "dbo.PropertyDetails", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LoanDetails", "PropertyDetailId", "dbo.PropertyDetails");
            DropIndex("dbo.LoanDetails", new[] { "PropertyDetailId" });
            DropColumn("dbo.LoanDetails", "PropertyDetailId");
            DropTable("dbo.PropertyDetails");
        }
    }
}
