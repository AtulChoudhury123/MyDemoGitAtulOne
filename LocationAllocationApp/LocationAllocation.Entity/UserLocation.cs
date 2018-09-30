using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LocationAllocation.Entity
{
    [Table("tblUserLocation")]
    public class UserLocation
    {
        [Key]
        public int Id { get; set; }
        public int Mid { get; set; }
        public string Location1 { get; set; }
        public string Location2 { get; set; }
        public string Location3 { get; set; }
        public string Track { get; set; }

    }
}
