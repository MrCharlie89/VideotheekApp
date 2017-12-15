namespace VideotheekApp.LIB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class videotheek1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "amount", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "amount");
        }
    }
}
