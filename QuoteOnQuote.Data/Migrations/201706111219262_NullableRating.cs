namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NullableRating : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Votes", "Rating", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Votes", "Rating", c => c.Int(nullable: false));
        }
    }
}
