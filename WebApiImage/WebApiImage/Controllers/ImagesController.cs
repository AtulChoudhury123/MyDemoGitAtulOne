using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Hosting;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiImage.Models;

namespace WebApiImage.Controllers
{
    [RoutePrefix("api/Images")]
    public class ImagesController : ApiController
    {
        private DbContextModel db = new DbContextModel();
        [Route("pictures")]
        // GET: api/Images
        public HttpResponseMessage Getimgmodel()
        {
            //var x="";
           // x = (from n in db.imgmodel where n.id == 12 select n.ImageName).FirstOrDefault();

            string []x;
            x = (from n in db.imgmodel select n.ImageName).ToArray<string>();
            var res = new HttpResponseMessage(HttpStatusCode.OK);
            string[] filepath=new string[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                filepath[i] = HostingEnvironment.MapPath("~/Image/" + x[i]);
            }

            FileStream []fileStream=new FileStream[x.Length];
            Image[] image = new Image[x.Length];
            MemoryStream[] memoryStream = new MemoryStream[x.Length];

            for (int i = 0; i < x.Length; i++)
            {
                using (fileStream[i] = new FileStream(filepath[i], FileMode.Open))
                {

                     image[i] = Image.FromStream(fileStream[i]);
                    image[i].Save(memoryStream[i], ImageFormat.Jpeg);
                    res.Content = new ByteArrayContent(memoryStream[i].ToArray());
                    res.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/jpeg");
                }
            }
            return res;

        }

        // GET: api/Images/5
        /* [ResponseType(typeof(ImageEntity))]
         public IHttpActionResult GetImageEntity(int id)
         {
             ImageEntity imageEntity = db.imgmodel.Find(id);
             if (imageEntity == null)
             {
                 return NotFound();
             }

             return Ok(imageEntity);
         }

         // PUT: api/Images/5
         [ResponseType(typeof(void))]
         public IHttpActionResult PutImageEntity(int id, ImageEntity imageEntity)
         {
             if (!ModelState.IsValid)
             {
                 return BadRequest(ModelState);
             }

             if (id != imageEntity.id)
             {
                 return BadRequest();
             }

             db.Entry(imageEntity).State = EntityState.Modified;

             try
             {
                 db.SaveChanges();
             }
             catch (DbUpdateConcurrencyException)
             {
                 if (!ImageEntityExists(id))
                 {
                     return NotFound();
                 }
                 else
                 {
                     throw;
                 }
             }

             return StatusCode(HttpStatusCode.NoContent);
         }*/

        // POST: api/Images
        [ResponseType(typeof(ImageEntity))]
        public HttpResponseMessage PostImageEntity()
        {
            string imageName = null;
            var httpRequest = HttpContext.Current.Request;
            var postedFile = httpRequest.Files["Image"];
            imageName = new String(Path.GetFileNameWithoutExtension(postedFile.FileName).ToArray());
            imageName = imageName + DateTime.Now.ToString("yymmssfff") + Path.GetExtension(postedFile.FileName);
            var filepath = HttpContext.Current.Server.MapPath("~/Image/" + imageName);
            postedFile.SaveAs(filepath);

            ImageEntity imageEntity = new ImageEntity()
            {
                ImageName = imageName
            };

            db.imgmodel.Add(imageEntity);
            db.SaveChanges();

            //return CreatedAtRoute("DefaultApi", new { id = imageEntity.id }, imageEntity);
            return Request.CreateResponse(HttpStatusCode.Created);
        }

        // DELETE: api/Images/5
      /*  [ResponseType(typeof(ImageEntity))]
        public IHttpActionResult DeleteImageEntity(int id)
        {
            ImageEntity imageEntity = db.imgmodel.Find(id);
            if (imageEntity == null)
            {
                return NotFound();
            }

            db.imgmodel.Remove(imageEntity);
            db.SaveChanges();

            return Ok(imageEntity);
        }*/

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ImageEntityExists(int id)
        {
            return db.imgmodel.Count(e => e.id == id) > 0;
        }
    }
}