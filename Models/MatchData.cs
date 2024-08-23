namespace Cricbuzz.Models
{
    public class MatchData
    {
        public string Id { get; set; }
        public DateTime DateTimeGMT { get; set; }
        public string MatchType { get; set; }
        public string Status { get; set; }
        public string Ms { get; set; }
        public string T1 { get; set; }
        public string T2 { get; set; }
        public string T1s { get; set; }
        public string T2s { get; set; }
        public string Series { get; set; }
    }
}
