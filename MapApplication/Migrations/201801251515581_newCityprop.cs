namespace MapApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newCityprop : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cities", "CityLatitude", c => c.Double(nullable: false));
            AddColumn("dbo.Cities", "CityLongitude", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cities", "CityLongitude");
            DropColumn("dbo.Cities", "CityLatitude");
        }
    }
}
