namespace VideotheekApp.LIB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class videotheek3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Movie_Title", c => c.String(maxLength: 255));
            AlterColumn("dbo.Movies", "PEGI", c => c.Int());
            AlterColumn("dbo.Movies", "Movie_Description", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Movie_Description", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "PEGI", c => c.Int(nullable: false));
            AlterColumn("dbo.Movies", "Movie_Title", c => c.String(nullable: false, maxLength: 255));
        }
    }
}
