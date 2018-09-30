using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using LocationAllocation.Entity;

namespace LocationAllocation.DataAccessLayer.DbContextModel
{
    public class LocationDboneEntities: DbContext
    {
        public LocationDboneEntities() : base("name=LocationConnection")
        {

        }
        public virtual DbSet<UserLocation> DbUserLocation { get; set; }
        public virtual DbSet<Locations> DbLocations { get; set; }
    }
}
