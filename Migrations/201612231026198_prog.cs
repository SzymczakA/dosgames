namespace MvcApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prog : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Programs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Size = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Descript = c.String(),
                        Image = c.String(),
                        Link = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Programs");
        }
    }
}
