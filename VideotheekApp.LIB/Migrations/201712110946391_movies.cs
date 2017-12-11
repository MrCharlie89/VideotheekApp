namespace VideotheekApp.LIB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class movies : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Movie_Title = c.String(nullable: false, maxLength: 255),
                        Genre = c.String(),
                        Year = c.Int(nullable: false),
                        Release_Date = c.DateTime(nullable: false),
                        Is_Reserved = c.Boolean(nullable: false),
                        Created_At = c.DateTime(nullable: false),
                        Modified_At = c.DateTime(nullable: false),
                        Deleted_At = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Movies");
        }
    }
}
