namespace VideotheekApp.LIB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class videotheek : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "PEGI", c => c.Int());
            AddColumn("dbo.Movies", "Duration", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "reserved_Amount", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "available_Amount", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "Movie_Description", c => c.String(nullable: false));
            DropColumn("dbo.Movies", "Year");
            DropColumn("dbo.Movies", "Is_Reserved");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Is_Reserved", c => c.Boolean(nullable: false));
            AddColumn("dbo.Movies", "Year", c => c.Int(nullable: false));
            DropColumn("dbo.Movies", "Movie_Description");
            DropColumn("dbo.Movies", "available_Amount");
            DropColumn("dbo.Movies", "reserved_Amount");
            DropColumn("dbo.Movies", "Duration");
            DropColumn("dbo.Movies", "PEGI");
        }
    }
}
