using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuoteOnQuote.Models
{
    class Votes
    {
        //What the user rated the quote. Either 1 or 0. 0 for a negative rating.
        public bool Rating { get; set; }

        [ForeignKey("QuoteId")]
        public virtual Quote Quote { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
