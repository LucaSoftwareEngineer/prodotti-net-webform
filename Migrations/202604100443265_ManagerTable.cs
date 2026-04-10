namespace WebForm1App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ManagerTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.managers",
                c => new
                    {
                        man_id = c.Int(nullable: false, identity: true),
                        man_username = c.String(),
                        man_password = c.String(),
                    })
                .PrimaryKey(t => t.man_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.managers");
        }
    }
}
