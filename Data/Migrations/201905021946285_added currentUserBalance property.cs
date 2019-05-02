namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedcurrentUserBalanceproperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transactions", "currentBalance", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Transactions", "currentBalance");
        }
    }
}
