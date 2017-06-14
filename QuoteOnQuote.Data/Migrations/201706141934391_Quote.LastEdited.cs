namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QuoteLastEdited : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Quotes", "DateEdited", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Quotes", "DateEdited");
        }
    }
}
