namespace WebForm1App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Prodottoes",
                c => new
                    {
                        IdProdotto = c.Int(nullable: false, identity: true),
                        Titolo = c.String(),
                        Prezzo = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.IdProdotto);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Prodottoes");
        }
    }
}
