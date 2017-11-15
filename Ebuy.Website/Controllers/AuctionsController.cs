using Ebuy.Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;


namespace Ebuy.Website.Controllers
{
    public class AuctionsController : Controller
    {
        // GET: Auctions
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        // GET: Auctions/Details/5
        [HttpGet]
        public ActionResult Details(long id= 0)
        {
            /*Auction misubasta = new Auction();
              misubasta.Id = id;
              misubasta.Title = "";*/
              
            var auction = new Ebuy.Website.Models.Auction
            {
                Id = id,
                Title = "Brand new Widget 2.0",
                Description = "This is a brand new version 2.0 Widget!",
                StartPrice = 1.00m,
                CurrentPrice = 13.40m,
                StartTime = DateTime.Now,
                EndTime = DateTime.Now,          
            };
            return View(auction);
        }

        // GET: Auctions/Create

        [HttpGet]
        public ActionResult Create()
        {
                  
            return View();
        }

        // POST: Auctions/Create
        [HttpPost]
        public ActionResult Create(Auction auction)
        {
            /* try
             {
                 // TODO: Add insert logic here
                 return RedirectToAction("Index");
             }
             catch
             {
                 return View(auction);
             }*/

            auction.StartTime = DateTime.Now;
            auction.EndTime = DateTime.Now.AddDays(4);
              

            /*if (auction.EndTime <= DateTime.Now.AddDays(2))
            {
               ModelState.AddModelError(
                   "EndTime", 
                   "por lo menos espera un día");
            }*/


            if (ModelState.IsValid)
            {
                var db = new EbuyDataContext();
                auction.StartTime = DateTime.Now;
               // auction.EndTime = DateTime.Now;
                db.Auctions.Add(auction);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            /*else
            {
                // Codigo normal
                return View();
            }*/
            return View (auction);
        }

        [HttpPost]
        public ActionResult Auction (long id)
        {
            var db= new EbuyDataContext();
            var auction = db.Auctions.Find(id);
            return View ("Auction", auction);
        }

        [HttpPost]
         public ActionResult PartialAuction (long id)
        {
            var db= new EbuyDataContext();
            var auction = db.Auctions.Find(id);
            return PartialView ("Auction", auction);
        }
     

        // GET: Auctions/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Auctions/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Auctions/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Auctions/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
