using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuoteOnQuote.Models
{
    public class Quote
    {
        public int QuoteId { get; set; }

        public string Text { get; set; }

        public string Origin { get; set; }

        public int UserId { get; set; }
        
        // No clue what to set as a ForeignKey here
        public virtual ICollection<Votes> Votes { get; set; }
    }
}
