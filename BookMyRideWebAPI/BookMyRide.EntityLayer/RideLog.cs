using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyRide.EntityLayer
{
    [Table("TblRideLog")]
    public class RideLog
    {
        [Key]
        private int id;
        private int rideHostId;
        private String startTime;
        private String endTime;
        private String startDate;
        private String endDate;
        private int startPointLocationId;
        private int endPointLocationId;
        private double priceForRide;
        private int totalSeatAvailable;
        private int vacantSeats;

        public int Id { get => id; set => id = value; }
        public int RideHostId { get => rideHostId; set => rideHostId = value; }
        public string StartTime { get => startTime; set => startTime = value; }
        public string EndTime { get => endTime; set => endTime = value; }
        public string StartDate { get => startDate; set => startDate = value; }
        public string EndDate { get => endDate; set => endDate = value; }
        public int StartPointLocationId { get => startPointLocationId; set => startPointLocationId = value; }
        public int EndPointLocationId { get => endPointLocationId; set => endPointLocationId = value; }
        public double PriceForRide { get => priceForRide; set => priceForRide = value; }
        public int TotalSeatAvailable { get => totalSeatAvailable; set => totalSeatAvailable = value; }
        public int VacantSeats { get => vacantSeats; set => vacantSeats = value; }
    }
}
