namespace QuoteOnQuote.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDbSets : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Quotes",
                c => new
                    {
                        QuoteId = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        Origin = c.String(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.QuoteId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Votes",
                c => new
                    {
                        VotesId = c.Int(nullable: false, identity: true),
                        Rating = c.Boolean(nullable: false),
                        QuoteId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VotesId)
                .ForeignKey("dbo.Quotes", t => t.QuoteId, cascadeDelete: true)
                .Index(t => t.QuoteId);
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Quotes", "UserId", "dbo.Users");
            DropForeignKey("dbo.Votes", "QuoteId", "dbo.Quotes");
            DropIndex("dbo.Votes", new[] { "QuoteId" });
            DropIndex("dbo.Quotes", new[] { "UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.Votes");
            DropTable("dbo.Quotes");
        }
    }
}
