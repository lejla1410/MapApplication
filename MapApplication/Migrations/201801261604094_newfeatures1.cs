namespace MapApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newfeatures1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AtractionDB", "Latitude", c => c.Double(nullable: false));
            AlterColumn("dbo.AtractionDB", "Longitude", c => c.Double(nullable: false));
            AlterColumn("dbo.Cities", "CityLatitude", c => c.Double(nullable: false));
            AlterColumn("dbo.Cities", "CityLongitude", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cities", "CityLongitude", c => c.String());
            AlterColumn("dbo.Cities", "CityLatitude", c => c.String());
            AlterColumn("dbo.AtractionDB", "Longitude", c => c.String());
            AlterColumn("dbo.AtractionDB", "Latitude", c => c.String());
        }
    }
}
