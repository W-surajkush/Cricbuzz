namespace Cricbuzz.Models
{
    public class CardModel
    {
        public string? Team1 { get; set; }
        public string? Team2 { get; set; }
        public string? Venue { get; set; }
        public string? MatchType { get; set; }
        public int? Team1Score { get; set; }
        public int? Team2Score { get; set; }
        public int? Team1Wickets { get; set; }
        public int? Team2Wickets { get; set; }
        public double? Team1Overs { get; set; }
        public double? Team2Overs { get; set; }
        public bool? Team1Playing { get; set; }
        public string? EventName { get; set; }
    }

}
