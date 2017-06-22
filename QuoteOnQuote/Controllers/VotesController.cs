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
        public JsonResult voteCheck(string id, int vote)
        {
            //A list of quotes and Votes to keep the db entries in
            List<Quote> dbQuotes = new List<Quote>();
            List<Votes> dbVotes = new List<Votes>();

            //an object to hold the current quote in
            Quote currentQuote = new Quote();




            dbQuotes = db.Quotes.ToList();

            foreach (var item in dbQuotes)
            {
                if (id == item.QuoteId.ToString())
                {
                    currentQuote = item;
                    break;

                }
            }


            dbVotes = db.Votes.ToList();

            foreach (var item in dbVotes)
            {


                if(id == item.QuoteId.ToString())
                {
                    switch (vote)
                    {
                        case 1:
                            {
                                if(item.Rating == 1)
                                {
                                    currentQuote.Score--;
                                }
                                else if(item.Rating == -1)
                                {
                                    currentQuote.Score = currentQuote.Score + 2;
                                }else
                                {
                                    currentQuote.Score++;
                                }
                                break;
                            }
                        case -1:
                            {
                                if (item.Rating == -1)
                                {
                                    currentQuote.Score++;
                                }
                                else if (item.Rating == 1)
                                {
                                    currentQuote.Score = currentQuote.Score - 2;
                                }
                                else
                                {
                                    currentQuote.Score--;
                                }
                                break;
                            }
                    }
                    
                }

            }

            return Json(currentQuote.Score, JsonRequestBehavior.AllowGet);
        }
    }
}