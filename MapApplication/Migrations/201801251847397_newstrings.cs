namespace MapApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newstrings : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AtractionDB", "Latitude", c => c.String());
            AddColumn("dbo.AtractionDB", "Longitude", c => c.String());
            AddColumn("dbo.Cities", "CityLatitude", c => c.String());
            AddColumn("dbo.Cities", "CityLongitude", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cities", "CityLongitude");
            DropColumn("dbo.Cities", "CityLatitude");
            DropColumn("dbo.AtractionDB", "Longitude");
            DropColumn("dbo.AtractionDB", "Latitude");
        }
    }
}
