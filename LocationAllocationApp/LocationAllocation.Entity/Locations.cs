using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocationAllocation.Entity
{
    [Table("tblLocations")]
    public class Locations
    {
        [Key]
        public int id { get; set; }
        public string LocNames { get; set; }

    }
}
