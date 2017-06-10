namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedVotesEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Votes", "ApplicationUser_Id", c => c.Int(nullable: false));
            DropColumn("dbo.Votes", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Votes", "UserId", c => c.Int(nullable: false));
            DropColumn("dbo.Votes", "ApplicationUser_Id");
        }
    }
}
