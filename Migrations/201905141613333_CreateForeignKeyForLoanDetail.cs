namespace MLPSApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateForeignKeyForLoanDetail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LoanDetails", "RegisteredUserId", c => c.Int(nullable: false));
            AddColumn("dbo.LoanDetails", "UnRegisteredUserId", c => c.Int(nullable: false));
            CreateIndex("dbo.LoanDetails", "RegisteredUserId");
            CreateIndex("dbo.LoanDetails", "UnRegisteredUserId");
            AddForeignKey("dbo.LoanDetails", "RegisteredUserId", "dbo.RegisteredUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.LoanDetails", "UnRegisteredUserId", "dbo.UnRegisteredUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LoanDetails", "UnRegisteredUserId", "dbo.UnRegisteredUsers");
            DropForeignKey("dbo.LoanDetails", "RegisteredUserId", "dbo.RegisteredUsers");
            DropIndex("dbo.LoanDetails", new[] { "UnRegisteredUserId" });
            DropIndex("dbo.LoanDetails", new[] { "RegisteredUserId" });
            DropColumn("dbo.LoanDetails", "UnRegisteredUserId");
            DropColumn("dbo.LoanDetails", "RegisteredUserId");
        }
    }
}
