namespace GdeNaBurek.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ocena : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Bureks", newName: "Burek");
            RenameTable(name: "dbo.Grads", newName: "Grad");
            RenameTable(name: "dbo.Pekaras", newName: "Pekara");
            CreateTable(
                "dbo.Ocena",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OcenaVrednost = c.Int(nullable: false),
                        Burek_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Burek", t => t.Burek_Id)
                .Index(t => t.Burek_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ocena", "Burek_Id", "dbo.Burek");
            DropIndex("dbo.Ocena", new[] { "Burek_Id" });
            DropTable("dbo.Ocena");
            RenameTable(name: "dbo.Pekara", newName: "Pekaras");
            RenameTable(name: "dbo.Grad", newName: "Grads");
            RenameTable(name: "dbo.Burek", newName: "Bureks");
        }
    }
}
