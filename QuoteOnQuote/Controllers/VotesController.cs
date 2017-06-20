using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using QuoteOnQuote.Models;

namespace QuoteOnQuote.Controllers
{
    public class VotesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Votes
        public ActionResult voteCheck(string id ,bool vote)
        {
            List<Quote> dbQuotes = new List<Quote>();
            List<Votes> quoteVotes = new List<Votes>();
            

            

            dbQuotes = db.Quotes.ToList();

            foreach (var item in dbQuotes)
            {
                if(id == item.QuoteId.ToString())
                {
                    
                }
            }

            return View();
        }
    }
}