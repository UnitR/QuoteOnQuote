using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuoteOnQuote.Models
{
    class Quote
    {
        public string Text { get; set; }

        public string Origin { get; set; }


        public virtual int UserId { get; set; }
        
        [ForeignKey("")]
        public virtual ICollection<Votes> Votes { get; set; }
    }
}
