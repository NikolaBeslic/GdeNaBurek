namespace GdeNaBurek.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prodaja : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Prodaja",
                c => new
                    {
                        ProdajaId = c.Int(nullable: false, identity: true),
                        Cena = c.Double(nullable: false),
                        Kolicina = c.Double(nullable: false),
                        Burek_Id = c.Int(),
                        Pekara_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ProdajaId)
                .ForeignKey("dbo.Burek", t => t.Burek_Id)
                .ForeignKey("dbo.Pekara", t => t.Pekara_Id)
                .Index(t => t.Burek_Id)
                .Index(t => t.Pekara_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Prodaja", "Pekara_Id", "dbo.Pekara");
            DropForeignKey("dbo.Prodaja", "Burek_Id", "dbo.Burek");
            DropIndex("dbo.Prodaja", new[] { "Pekara_Id" });
            DropIndex("dbo.Prodaja", new[] { "Burek_Id" });
            DropTable("dbo.Prodaja");
        }
    }
}
