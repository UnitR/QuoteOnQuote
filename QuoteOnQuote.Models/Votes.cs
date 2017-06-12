namespace Data.Models
{
    public class Votes
    {
        public int VotesId { get; set; }

        //What the user rated the quote. Either 1 or 0. 0 for a negative rating.
        public int Rating { get; set; }

        public int QuoteId { get; set; }

        public string UserId { get; set; }
    }
}
