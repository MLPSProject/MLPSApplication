namespace MLPSApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableEmployee : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        vName = c.String(nullable: false, maxLength: 100),
                        vDesignation = c.String(nullable: false),
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
            DropTable("dbo.Employees");
        }
    }
}
