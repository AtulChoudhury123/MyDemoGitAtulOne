using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyRide.EntityLayer
{
    [Table("TblVechileLog")]
    public class VechileLog
    {
       
        private int id;
        private int userId;
        private string vechileImage;
        private string vechileRegNumber;
        private string company;
        private string model;
        private int isAc;
        private int seatCapacity;

        [Key]
        public int Id { get => id; set => id = value; }
        public int UserId { get => userId; set => userId = value; }
        public string VechileImage { get => vechileImage; set => vechileImage = value; }
        public string VechileRegNumber { get => vechileRegNumber; set => vechileRegNumber = value; }
        public string Company { get => company; set => company = value; }
        public string Model { get => model; set => model = value; }
        public int IsAc { get => isAc; set => isAc = value; }
        public int SeatCapacity { get => seatCapacity; set => seatCapacity = value; }
    }
}
