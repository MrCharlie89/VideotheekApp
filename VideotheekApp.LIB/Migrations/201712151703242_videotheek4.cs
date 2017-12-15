namespace VideotheekApp.LIB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class videotheek4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Movie_Title", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Movies", "Genre", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "PEGI", c => c.Int(nullable: false));
            AlterColumn("dbo.Movies", "Movie_Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Movie_Description", c => c.String());
            AlterColumn("dbo.Movies", "PEGI", c => c.Int());
            AlterColumn("dbo.Movies", "Genre", c => c.String());
            AlterColumn("dbo.Movies", "Movie_Title", c => c.String(maxLength: 255));
        }
    }
}
