namespace LocationAllocation.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class atulone : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblLocations",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        LocNames = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.tblUserLocation",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Mid = c.Int(nullable: false),
                        Location1 = c.String(),
                        Location2 = c.String(),
                        Location3 = c.String(),
                        Track = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblUserLocation");
            DropTable("dbo.tblLocations");
        }
    }
}
