using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LocationAllocation.Entity;
using LocationAllocation.BussinessLayer;

namespace LocationAllocationApp.Controllers
{
    public class LocationCntrlsController : Controller
    {
        public readonly ManageLocations mngloc = new ManageLocations();
        // GET: LocationCntrls
        public ActionResult Create()
        {
            List<Locations> mainlist = new List<Locations>();
            mainlist = mngloc.getLocationManage();
            ViewBag.disploc = mainlist;
            return View();
        }
        [HttpPost]
        public ActionResult Create([Bind(Include ="Mid, Location1,Location2,Location3,Track")] UserLocation ul)
        {
            if (ul.Location1 == ul.Location2 || ul.Location1 == ul.Location3 || ul.Location2 == ul.Location3)
            {
                return RedirectToAction("displayuser", "LocationCntrls");
            }
            else
            {
                mngloc.manageUser(ul);
                return View("displayuser");
           }
        }

        public ActionResult displayuser()
        {
            List<List<string>> udisp = new List<List<string>>();
            udisp = mngloc.getUserManage();
            ViewBag.dispuser = udisp;

            return View();
        }

        public ActionResult OurLocations()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult OurLocations([Bind(Include = "LocNames")] Locations l)
        {
            mngloc.manageLocation(l);
            return View();
        }

    }
}