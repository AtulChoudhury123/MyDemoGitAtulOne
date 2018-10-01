namespace BookMyRide.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V002 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TblLocation",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Pincode = c.String(),
                        Area = c.String(),
                        Town = c.String(),
                        District = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TblRideLog",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RideHostId = c.Int(nullable: false),
                        StartTime = c.String(),
                        EndTime = c.String(),
                        StartDate = c.String(),
                        EndDate = c.String(),
                        StartPointLocationId = c.Int(nullable: false),
                        EndPointLocationId = c.Int(nullable: false),
                        PriceForRide = c.Double(nullable: false),
                        TotalSeatAvailable = c.Int(nullable: false),
                        VacantSeats = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TblRidersLog",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RiderId = c.Int(nullable: false),
                        RideLogId = c.Int(nullable: false),
                        Status = c.String(),
                        Remark = c.String(),
                        Rating = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TblUser",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fname = c.String(),
                        Lname = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        Mobile = c.String(),
                        Address = c.String(),
                        Pincode = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Country = c.String(),
                        IsVerified = c.Int(nullable: false),
                        Dob = c.String(),
                        Gender = c.String(),
                        Profile_pic = c.String(),
                        Id_proof = c.String(),
                        Rating = c.Int(nullable: false),
                        Role = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TblUserRating",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GiverUserId = c.Int(nullable: false),
                        ReciverUserId = c.Int(nullable: false),
                        Rating = c.Int(nullable: false),
                        Review = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TblVechileLog",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        VechileImage = c.String(),
                        VechileRegNumber = c.String(),
                        Company = c.String(),
                        Model = c.String(),
                        IsAc = c.Int(nullable: false),
                        SeatCapacity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TblVechileLog");
            DropTable("dbo.TblUserRating");
            DropTable("dbo.TblUser");
            DropTable("dbo.TblRidersLog");
            DropTable("dbo.TblRideLog");
            DropTable("dbo.TblLocation");
        }
    }
}
