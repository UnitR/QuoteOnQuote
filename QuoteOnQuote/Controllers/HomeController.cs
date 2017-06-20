using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data.Models;

namespace QuoteOnQuote.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

       
        public ActionResult Index()
        {
           

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Dashboard()
        {
            List<Quote> dashQuotes = new List<Quote>();

            List<Quote> dbQuotes = new List<Quote>();
            dbQuotes = db.Quotes.ToList(); //temporary


            for (int i = 0; i < 12; i++)
            {
                try
                {
                    dashQuotes[i].Origin = dbQuotes[i].Origin;
                }
                catch (Exception ex) when (ex is NullReferenceException || ex is ArgumentOutOfRangeException) //!!!! Make them try catches with exceptions ot null and out of index
                {
                    dashQuotes.Insert(i, new Quote());
                    dashQuotes[i].Origin = "------";
                    dashQuotes[i].Text = "------";
                }

                try
                {
                    dashQuotes[i].Text = dbQuotes[i].Text;
                }
                catch (Exception ex) when (ex is NullReferenceException || ex is ArgumentOutOfRangeException)
                {
                    dashQuotes.Insert(i, new Quote());
                    dashQuotes[i].Origin = "------";
                    dashQuotes[i].Text = "------";
                }

                //if (dbQuotes[i].Votes == null)
                //{
                //    //!!!!!!!!!!!!
                //    dashQuotes[i].Votes;
                //}
                //else
                //{
                //    dashQuotes[i].Votes = dbQuotes[i].Votes;
                //}
            }

            return View(dashQuotes);
        }
    }
}