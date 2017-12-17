namespace VideotheekApp.LIB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class videotheek6 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Release_Date", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Release_Date", c => c.DateTime(nullable: false));
        }
    }
}
