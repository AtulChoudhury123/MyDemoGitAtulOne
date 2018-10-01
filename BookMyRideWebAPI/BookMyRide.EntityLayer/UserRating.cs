using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyRide.EntityLayer
{
    [Table("TblUserRating")]
    public class UserRating
    {
        
        private int id;
        private int giverUserId;
        private int reciverUserId;
        private int rating;
        private String review;

        [Key]
        public int Id { get => id; set => id = value; }
        public int GiverUserId { get => giverUserId; set => giverUserId = value; }
        public int ReciverUserId { get => reciverUserId; set => reciverUserId = value; }
        public int Rating { get => rating; set => rating = value; }
        public string Review { get => review; set => review = value; }
    }
}
