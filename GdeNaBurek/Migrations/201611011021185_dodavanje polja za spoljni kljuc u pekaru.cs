namespace GdeNaBurek.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dodavanjepoljazaspoljnikljucupekaru : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Pekara", "Grad_Id", "dbo.Grad");
            DropIndex("dbo.Pekara", new[] { "Grad_Id" });
            RenameColumn(table: "dbo.Pekara", name: "Grad_Id", newName: "GradId");
            AlterColumn("dbo.Pekara", "GradId", c => c.Int(nullable: false));
            CreateIndex("dbo.Pekara", "GradId");
            AddForeignKey("dbo.Pekara", "GradId", "dbo.Grad", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pekara", "GradId", "dbo.Grad");
            DropIndex("dbo.Pekara", new[] { "GradId" });
            AlterColumn("dbo.Pekara", "GradId", c => c.Int());
            RenameColumn(table: "dbo.Pekara", name: "GradId", newName: "Grad_Id");
            CreateIndex("dbo.Pekara", "Grad_Id");
            AddForeignKey("dbo.Pekara", "Grad_Id", "dbo.Grad", "Id");
        }
    }
}
