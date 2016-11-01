namespace GdeNaBurek.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dodavanjeklasagradipekara : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Grads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NazivGrada = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pekaras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NazivPekare = c.String(),
                        Adresa = c.String(),
                        Grad_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Grads", t => t.Grad_Id)
                .Index(t => t.Grad_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pekaras", "Grad_Id", "dbo.Grads");
            DropIndex("dbo.Pekaras", new[] { "Grad_Id" });
            DropTable("dbo.Pekaras");
            DropTable("dbo.Grads");
        }
    }
}
