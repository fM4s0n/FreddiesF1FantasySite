namespace FreddiesF1FantasySite.Models;

public class ConstructorStandingsModel
{
    public class Root
    {
        public MRData? MRData { get; set; }
    }

    public class MRData
    {
        public string? Total { get; set; }
        public StandingsTable? StandingsTable { get; set; }
    }

    public class StandingsTable
    {
        public string? Season { get; set; }
        public List<StandingsList>? StandingsLists { get; set; }
    }

    public class StandingsList
    {
        public string? Season { get; set; }
        public string? Round { get; set; }
        public List<ConstructorStanding>? ConstructorStandings { get; set; }
    }

    public class ConstructorStanding
    {
        public string? Position { get; set; }
        public string? PositionText { get; set; }
        public string? Points { get; set; }
        public string? Wins { get; set; }
        public Constructor? Constructor { get; set; }
    }

    public class Constructor
    {
        public string? ConstructorId { get; set; }
        public string? Url { get; set; }
        public string? Name { get; set; }
        public string? Nationality { get; set; }
    }
}
