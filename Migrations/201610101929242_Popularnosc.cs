namespace MvcApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Popularnosc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "Popularity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "Popularity");
        }
    }
}
