using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class Quote
    {
        public int QuoteId { get; set; }

        public string Text { get; set; }

        public string Origin { get; set; }

        public DateTime DatePosted { get; set; }

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }

        // No clue what to set as a ForeignKey here
        public virtual ICollection<Votes> Votes { get; set; }
    }
}
