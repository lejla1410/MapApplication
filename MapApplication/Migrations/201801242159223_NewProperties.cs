namespace MapApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewProperties : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AtractionDB",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AtractionName = c.String(maxLength: 50),
                        Latitude = c.Double(nullable: false),
                        Longitude = c.Double(nullable: false),
                        City = c.String(maxLength: 50),
                        Decription = c.String(maxLength: 150),
                        MyImagesFile = c.String(),
                        CityData_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cities", t => t.CityData_Id)
                .Index(t => t.CityData_Id);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AtractionDB", "CityData_Id", "dbo.Cities");
            DropIndex("dbo.AtractionDB", new[] { "CityData_Id" });
            DropTable("dbo.Cities");
            DropTable("dbo.AtractionDB");
        }
    }
}
