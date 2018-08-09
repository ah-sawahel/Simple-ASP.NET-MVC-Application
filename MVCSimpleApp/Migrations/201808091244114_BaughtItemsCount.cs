namespace MVCSimpleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BaughtItemsCount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "BaughtItemsCount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "BaughtItemsCount");
        }
    }
}
