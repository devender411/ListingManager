using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ListingDatabase;
using System.Web.Http.Results;

namespace PropertyListingAPI.Controllers
{
    [RoutePrefix("Listings")]
    public class ListingsController : ApiController
    {
        // GET: Listings/Listings
        [HttpGet]
        [Route("Listings")]
        public IHttpActionResult Listings()
        {
            using (var context = new testEntities())
            {
                var listings = context.Listings.ToList();
                return Json(listings);
            }
        }

        // GET: Listings/Listings/5
        [HttpGet]
        [Route("Listings/{Id}")]
        public IHttpActionResult Listings(int id)
        {
            using (var context = new testEntities())
            {
                var listings = context.Listings.Where(x=>x.Listing_Id==id).FirstOrDefault();
                return Json(listings);
            }

        }
        // GET: Listings/DeleteListings/5
        [HttpGet]
        [Route("DeleteListings/{Id}")]
        public void DeleteListings(int id)
        {
            var context = new testEntities();
            var Agentcontext = new testEntities();
           

            var report = (from d in context.Listings
                          where d.Listing_Id == id
                          select d).Single();

            context.Listings.Remove(report);
            context.SaveChanges();
        }
    }
}
