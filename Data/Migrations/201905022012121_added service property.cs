namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedserviceproperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transactions", "Service", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Transactions", "Service");
        }
    }
}
