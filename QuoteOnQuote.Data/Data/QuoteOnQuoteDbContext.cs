using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuoteOnQuote.Models;
using QuoteOnQuote.Data;

namespace QuoteOnQuote.Data.Data
{
    class QuoteOnQuoteDbContext : DbContext
    {
        public QuoteOnQuoteDbContext()
            : base("DefaultConnection")
        {
        }

        public QuoteOnQuoteDbContext Create()
        {
            return new QuoteOnQuoteDbContext();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Votes> Votes { get; set; }
    }
}
