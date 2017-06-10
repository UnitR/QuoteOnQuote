using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuoteOnQuote.Models;
using QuoteOnQuote.Data;
using Data.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Data.Data
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

        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Votes> Votes { get; set; }
    }
}
