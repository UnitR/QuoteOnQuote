using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuoteOnQuote.Models
{
    class Votes
    {
        public int Score { get; set; }

        public int QuoteId { get; set; }

        public int UserId { get; set; }
    }
}
