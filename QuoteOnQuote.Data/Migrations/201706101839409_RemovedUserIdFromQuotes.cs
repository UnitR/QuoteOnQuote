namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedUserIdFromQuotes : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Quotes", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Quotes", "UserId", c => c.Int(nullable: false));
        }
    }
}
