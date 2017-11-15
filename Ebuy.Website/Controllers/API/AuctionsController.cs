using Ebuy.Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Wet.Http;
//using System.Web;
//using System.Web.Mvc;
//using System.Data.Entity;


namespace Ebuy.Website.Api
{
    public class AuctionsDataController : ApiController
    {
        // GET api/Auctions
        public IEnumerable<String> Get ()
        {
            return new String[] { "Value1", "Value2" };
        }

        // GET api/Auctions/5
        public String Get(int id)
        {
            return "Value";
        }


        // POST: api/Auctions
        public void Post (string value)
        {
        }


        // PUT: api/Auctions/5
        public void Put (int id, string value)
        {
        }

        // DELETE: api/Auctions/5
        public void Delete(int id)
        {
        }
    }
}
