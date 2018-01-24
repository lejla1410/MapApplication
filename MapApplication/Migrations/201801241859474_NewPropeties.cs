namespace MapApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewPropeties : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MapsDB",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AtractionName = c.String(maxLength: 50, unicode: false),
                        Latitude = c.Double(nullable: false),
                        Longitude = c.Double(nullable: false),
                        City = c.String(maxLength: 50, unicode: false),
                        MyImagesFile = c.String(),
                        CityData_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cities", t => t.CityData_Id)
                .Index(t => t.CityData_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MapsDB", "CityData_Id", "dbo.Cities");
            DropIndex("dbo.MapsDB", new[] { "CityData_Id" });
            DropTable("dbo.MapsDB");
            DropTable("dbo.Cities");
        }
    }
}
