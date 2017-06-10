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


        public virtual Quote QuoteId { get; set; }

        public virtual User UserId { get; set; }
    }
}
