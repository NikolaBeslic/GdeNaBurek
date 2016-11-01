namespace GdeNaBurek.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class burek : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bureks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NazivBureka = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Bureks");
        }
    }
}
