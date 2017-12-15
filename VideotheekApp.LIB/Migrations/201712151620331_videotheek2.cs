namespace VideotheekApp.LIB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class videotheek2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "PEGI", c => c.Int(nullable: false));
            AlterColumn("dbo.Movies", "amount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "amount", c => c.Int());
            AlterColumn("dbo.Movies", "PEGI", c => c.Int());
        }
    }
}
