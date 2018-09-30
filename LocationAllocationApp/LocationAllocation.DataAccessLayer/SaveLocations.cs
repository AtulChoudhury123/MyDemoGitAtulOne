using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocationAllocation.Entity;

namespace LocationAllocation.DataAccessLayer
{
    
    public class SaveLocations
    {
       public readonly DbContextModel.LocationDboneEntities dbmodels= new DbContextModel.LocationDboneEntities();

        public void saveLocationDataAccess(Locations l)
        {
            dbmodels.DbLocations.Add(l);
            this.dbmodels.SaveChanges();
        }

        public List<Locations> getLocationsAccess()
        {
            List<Locations> listloc = new List<Locations>();
            listloc = (from n in dbmodels.DbLocations select n).ToList<Locations>();
            return listloc;
        }

        public void saveUserDataAccess(UserLocation ul)
        {
            dbmodels.DbUserLocation.Add(ul);
            this.dbmodels.SaveChanges();
        }

        public List<List<string>> getuserAccess()
        {
            List<List<string>> data = new List<List<string>>();
            var list1 = dbmodels.DbUserLocation.ToList();
            foreach (var i in list1) {
                List<string> temp = new List<string>();
                
                temp.Add((i.Mid).ToString());
                int l1 = Convert.ToInt32(i.Location1);
                int l2 = Convert.ToInt32(i.Location2);
                int l3 = Convert.ToInt32(i.Location3);
                var temp_list1 = dbmodels.DbLocations.Where(x => x.id == l1).FirstOrDefault();
                var temp_list2 = dbmodels.DbLocations.Where(x => x.id == l2).FirstOrDefault();
                var temp_list3 = dbmodels.DbLocations.Where(x => x.id == l3).FirstOrDefault();
                temp.Add(temp_list1.LocNames);
                temp.Add(temp_list2.LocNames);
                temp.Add(temp_list3.LocNames);
                temp.Add(i.Track);
                data.Add(temp);
            }
            return data;
        }
        
    }
}
