using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuoteOnQuote.Models
{
    class User
    {

        public int UserId { get; set; }

        public string Password { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        [ForeignKey("QuoteId")]
        public virtual ICollection<Quote> Quotes { get; set; }
            
    }
}
