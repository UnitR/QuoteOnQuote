namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
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
                    })
                .PrimaryKey(t => t.QuoteId);
            
            CreateTable(
                "dbo.Votes",
                c => new
                    {
                        VotesId = c.Int(nullable: false, identity: true),
                        Rating = c.Boolean(nullable: false),
                        QuoteId = c.Int(nullable: false),
                        ApplicationUser_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VotesId)
                .ForeignKey("dbo.Quotes", t => t.QuoteId, cascadeDelete: true)
                .Index(t => t.QuoteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Votes", "QuoteId", "dbo.Quotes");
            DropIndex("dbo.Votes", new[] { "QuoteId" });
            DropTable("dbo.Votes");
            DropTable("dbo.Quotes");
        }
    }
}
