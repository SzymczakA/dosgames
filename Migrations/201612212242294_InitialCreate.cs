namespace MvcApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        FullName = c.String(),
                        CategoryID = c.Int(nullable: false),
                        Size = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Descript = c.String(),
                        Image = c.String(),
                        Year = c.Int(nullable: false),
                        Link = c.String(),
                        Popularity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryEN = c.String(),
                        CategoryPL = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Games", new[] { "CategoryID" });
            DropForeignKey("dbo.Games", "CategoryID", "dbo.Categories");
            DropTable("dbo.Categories");
            DropTable("dbo.Games");
        }
    }
}
