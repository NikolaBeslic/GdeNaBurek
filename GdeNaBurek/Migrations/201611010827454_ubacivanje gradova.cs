namespace GdeNaBurek.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class ubacivanjegradova : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Grad (NazivGrada) VALUES ('Beograd')");
            Sql("Insert Into Grad (NazivGrada) VALUES ('Novi Sad')");
        }

        public override void Down()
        {
            Sql("DELETE FROM Grad Where Id IN (1,2)");
        }
    }
}
