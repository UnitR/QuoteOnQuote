using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
