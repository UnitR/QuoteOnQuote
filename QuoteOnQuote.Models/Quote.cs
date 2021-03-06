﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuoteOnQuote.Models
{
    public class Quote
    {
        public Quote()
        {
            Votes = new HashSet<Votes>();
        }
        public int QuoteId { get; set; }

        [DataType(DataType.MultilineText)]
        public string Text { get; set; }

        public string Origin { get; set; }

        [Display(Name = "Time Posted")]
        public DateTime DatePosted { get; set; }

        [Display(Name = "Last Edited")]
        public DateTime? DateEdited { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        
        public virtual ApplicationUser User { get; set; }

        [NotMapped]
        public int Score { get; set; }

        [Display(Name = "Total Votes")]
        public virtual ICollection<Votes> Votes { get; set; }
    }
}
