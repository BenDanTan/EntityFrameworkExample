namespace EntityFrameworkExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Barrel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Barrels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        radius = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.Spoons");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Spoons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        length = c.Double(nullable: false),
                        owner = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.Barrels");
        }
    }
}
