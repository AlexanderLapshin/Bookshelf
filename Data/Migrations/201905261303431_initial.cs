namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sum = c.Double(nullable: false),
                        Type = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Note = c.String(),
                        CurrentBalance = c.Double(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 30),
                        PasswordHash = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Balance = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Username, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "UserID", "dbo.Users");
            DropIndex("dbo.Users", new[] { "Username" });
            DropIndex("dbo.Transactions", new[] { "UserID" });
            DropTable("dbo.Users");
            DropTable("dbo.Transactions");
        }
    }
}
