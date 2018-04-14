using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using WebAPIAndAngular.Models;
namespace WebAPIAndAngular.Controllers
{
    public class SubscriberController : ApiController
    {
        // GET: api/Subscriber
        private SibeeshPassionEntities myEntity = new SibeeshPassionEntities();
        public IEnumerable<tbl_Subscribers> Get()
        {
            return myEntity.tbl_Subscribers.AsEnumerable();
        }

        // POST: api/Subscriber
        public void Post(tbl_Subscribers sub)
        {
            if (ModelState.IsValid)
            {
                myEntity.tbl_Subscribers.Add(sub);
                myEntity.SaveChanges();
            }
        }

        // PUT: api/Subscriber/5
        public void Put(tbl_Subscribers sub)
        {
            if (ModelState.IsValid)
            {
                myEntity.Entry(sub).State = EntityState.Modified;
                try
                {
                    myEntity.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        // DELETE: api/Subscriber/5
        public void Delete(int id)
        {
            tbl_Subscribers dlt = myEntity.tbl_Subscribers.Find(id);
            if (dlt != null)
            {
                try
                {
                    myEntity.tbl_Subscribers.Remove(dlt);
                    myEntity.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
