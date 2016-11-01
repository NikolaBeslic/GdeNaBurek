namespace GdeNaBurek.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class promenapolja : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Grad", "NazivGrada", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Pekara", "NazivPekare", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pekara", "NazivPekare", c => c.String());
            AlterColumn("dbo.Grad", "NazivGrada", c => c.String());
        }
    }
}
