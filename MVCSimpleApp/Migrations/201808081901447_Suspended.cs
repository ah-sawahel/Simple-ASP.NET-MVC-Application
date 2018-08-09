namespace MVCSimpleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Suspended : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Suspended", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Suspended");
        }
    }
}
