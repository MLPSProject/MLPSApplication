namespace MLPSApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRegisteredUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RegisteredUsers",
                c => new
                    {
                        RId = c.Int(nullable: false, identity: true),
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
                .PrimaryKey(t => t.RId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RegisteredUsers");
        }
    }
}
