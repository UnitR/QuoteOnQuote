using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using QuoteOnQuote.Models;

namespace QuoteOnQuote.Data.Data
{
    class QuoteOnQuoteDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Votes> Votes { get; set; }

        public QuoteOnQuoteDbContext()
            : base("DefaultConnection")
        {
        }

        public QuoteOnQuoteDbContext Create()
        {
            return new QuoteOnQuoteDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
