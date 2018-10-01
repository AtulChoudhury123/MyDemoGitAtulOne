using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyRide.EntityLayer
{
    [Table("TblRidersLog")]
    public class RidersLog
    {
        [Key]
        private int id;
        private int riderId;
        private int rideLogId;
        private String status;
        private String remark;
        private int rating;

        public int Id { get => id; set => id = value; }
        public int RiderId { get => riderId; set => riderId = value; }
        public int RideLogId { get => rideLogId; set => rideLogId = value; }
        public string Status { get => status; set => status = value; }
        public string Remark { get => remark; set => remark = value; }
        public int Rating { get => rating; set => rating = value; }
    }
}
