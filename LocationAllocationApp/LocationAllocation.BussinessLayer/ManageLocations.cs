using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocationAllocation.DataAccessLayer;
using LocationAllocation.Entity;

namespace LocationAllocation.BussinessLayer
{
    public class ManageLocations
    {
        public readonly SaveLocations savelocaccess = new SaveLocations();

        public void manageLocation(Locations l)
        {
            savelocaccess.saveLocationDataAccess(l);
        }

        public List<Locations> getLocationManage()
        {
            return savelocaccess.getLocationsAccess();
        }

        public void manageUser(UserLocation ul)
        {
          
            savelocaccess.saveUserDataAccess(ul);
        }

        public List<List<string>> getUserManage()
        {
            return savelocaccess.getuserAccess();
        }
    }
}
