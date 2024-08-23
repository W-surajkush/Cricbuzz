namespace Cricbuzz.Models
{
    public class Matches
    {
        public string Apikey { get; set; }
        public List<MatchData> Data { get; set; }
        public string Status { get; set; }
        public Info Info { get; set; }
    }
}
