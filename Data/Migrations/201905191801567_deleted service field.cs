namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletedservicefield : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Transactions", "Service");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "Service", c => c.Boolean(nullable: false));
        }
    }
}
