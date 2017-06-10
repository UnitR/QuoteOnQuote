namespace QuoteOnQuote.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedUserEntity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Quotes", "UserId", "dbo.Users");
            DropIndex("dbo.Quotes", new[] { "UserId" });
            DropTable("dbo.Users");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Password = c.String(),
                        Username = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateIndex("dbo.Quotes", "UserId");
            AddForeignKey("dbo.Quotes", "UserId", "dbo.Users", "UserId", cascadeDelete: true);
        }
    }
}
