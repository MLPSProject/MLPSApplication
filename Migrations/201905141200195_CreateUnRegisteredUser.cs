namespace MLPSApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateUnRegisteredUser : DbMigration
    {
        public override void Up()
        {
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
        }
    }
}
