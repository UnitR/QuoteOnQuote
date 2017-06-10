namespace QuoteOnQuote.Models
{
    class Votes
    {
        //What the user rated the quote. Either 1 or 0. 0 for a negative rating.
        public bool Rating { get; set; } 

        public int QuoteId { get; set; }

        public int UserId { get; set; }
    }
}
