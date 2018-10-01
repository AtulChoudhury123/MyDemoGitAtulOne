using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BookMyRide.EntityLayer;

namespace BookMyRide.DataAccessLayer.BookMyRideContextModel
{
    class BookMyRideDbContext : DbContext
    {
        public BookMyRideDbContext() : base("name=BookMyRideConnectionString") {
        }

        public virtual DbSet<User> DbUserModel { get; set; }
        public virtual DbSet<UserRating> DbUserRatingModel { get; set; }
        public virtual DbSet<RidersLog> DbRidersLogModel { get; set; }
        public virtual DbSet<RideLog> DbRideLogModel { get; set; }
        public virtual DbSet<Location> DbLocationModel { get; set; }
        public virtual DbSet<VechileLog> DbVechileLogModel { get; set; }
    }
}
