namespace MapApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class required : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AtractionDB", "Decription", c => c.String(nullable: false, maxLength: 450));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AtractionDB", "Decription", c => c.String(maxLength: 450));
        }
    }
}
