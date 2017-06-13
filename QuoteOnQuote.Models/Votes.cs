namespace Data.Models
{
    public class Votes
    {
        public int VotesId { get; set; }

        //What the user rated the quote. -1 for negative, 1 for positive
        public int? Rating { get; set; }

        public int QuoteId { get; set; }

        public string UserId { get; set; }
    }
}
