using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class Votes
    {
        public int VotesId { get; set; }

        //What the user rated the quote. Either 1 or 0. 0 for a negative rating.
        public bool Rating { get; set; }

        public int QuoteId { get; set; }

        public int UserId { get; set; }
    }
}
