namespace Vod.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIdentityCardNumberToApplicationUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "IdentityCardNumber", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "IdentityCardNumber");
        }
    }
}
