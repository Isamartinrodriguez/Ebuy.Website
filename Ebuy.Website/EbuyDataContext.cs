using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Ebuy.Website.Models;

namespace Ebuy.Website
{
    public class EbuyDataContext : DbContext 
    {
       public DbSet<Auction> Auctions { get; set; }

     
    }
    
}