using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace WebApiImage.Models
{
    public class DbContextModel:DbContext
    {
        public DbContextModel() : base("name=Imagestring")
        {

        }
        public virtual DbSet<ImageEntity> imgmodel { get; set; }
    }
}