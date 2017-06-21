using ListingDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PropertyListingAPI.Controllers
{
    [RoutePrefix("AgentListings")]
    public class AgentListingsController : ApiController
    {
        // GET: AgentListings/Listing
        /// <summary>
        /// gets agent listings 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Listings")]
        public IHttpActionResult Listings()
        {
            using (var context = new testEntities())
            {
                var listings = (from l in context.Listings 
                               join agl in context.AgentListings on l.Listing_Id equals agl.LisitngId into ps
                                from agl in ps.DefaultIfEmpty()
                                join ag in context.Agents on agl.AgentId equals ag.AgentId 
                                select new { l.Listing_Id,l.ListingCode,l.ListingName,l.ListingAddress,ag.AgentName } ).ToList();
                return Json(listings);
            }
        }
    }
}
