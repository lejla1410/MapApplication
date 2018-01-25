namespace MapApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class news : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AtractionDB", "Latitude");
            DropColumn("dbo.AtractionDB", "Longitude");
            DropColumn("dbo.Cities", "CityLatitude");
            DropColumn("dbo.Cities", "CityLongitude");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cities", "CityLongitude", c => c.Double(nullable: false));
            AddColumn("dbo.Cities", "CityLatitude", c => c.Double(nullable: false));
            AddColumn("dbo.AtractionDB", "Longitude", c => c.Double(nullable: false));
            AddColumn("dbo.AtractionDB", "Latitude", c => c.Double(nullable: false));
        }
    }
}
