namespace Vod.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MadeCustomerBirthdateNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Birthdate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Birthdate", c => c.DateTime(nullable: false));
        }
    }
}
