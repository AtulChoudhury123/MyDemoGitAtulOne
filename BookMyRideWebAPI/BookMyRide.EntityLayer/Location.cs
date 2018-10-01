using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyRide.EntityLayer
{
    [Table("TblLocation")]
    public class Location
    {
        [Key]
        private int id;
        private String pincode;
        private String area;
        private String town;
        private String district;

        public int Id { get => id; set => id = value; }
        public string Pincode { get => pincode; set => pincode = value; }
        public string Area { get => area; set => area = value; }
        public string Town { get => town; set => town = value; }
        public string District { get => district; set => district = value; }
    }
}
