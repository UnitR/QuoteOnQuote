using System.Data.Entity;

namespace QuoteOnQuote.Data.Data
{
    public class QuoteOnQuoteDbContext : DbContext
    {
        public QuoteOnQuoteDbContext()
            : base("DefaultConnection")
        {
            
        }

        public QuoteOnQuoteDbContext Create()
        {
            return new QuoteOnQuoteDbContext();
        }
    }
}