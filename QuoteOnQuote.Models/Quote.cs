using System.Collections.Generic;

namespace QuoteOnQuote.Models
{
    class Quote
    {
        public string Text { get; set; }

        public string Origin { get; set; }

        public int UserId { get; set; }
        
        public List<Votes> Votes { get; set; }
    }
}
