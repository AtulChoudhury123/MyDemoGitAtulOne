namespace WebApiImage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class makedb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ImageEntities",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ImageName = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ImageEntities");
        }
    }
}
