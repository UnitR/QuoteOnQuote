namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedDisplayName : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "DisplayName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "DisplayName", c => c.String());
        }
    }
}
