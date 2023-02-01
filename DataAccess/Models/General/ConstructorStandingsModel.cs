namespace DataAccess.Models.General;

public class ConstructorStandingsModel
{
    public class Root
    {
        public MRData MRData { get; set; } = new();
    }

    public class MRData
    {
        public string Total { get; set; } = string.Empty;
        public StandingsTable StandingsTable { get; set; } = new();
    }

    public class StandingsTable
    {
        public string Season { get; set; } = string.Empty;
        public List<StandingsList> StandingsLists { get; set; } = new();
    }

    public class StandingsList
    {
        public string Season { get; set; } = string.Empty;
        public string Round { get; set; } = string.Empty;
        public List<ConstructorStanding> ConstructorStandings { get; set; } = new();
    }

    public class ConstructorStanding
    {
        public string Position { get; set; } = string.Empty;
        public string PositionText { get; set; } = string.Empty;
        public string Points { get; set; } = string.Empty;
        public string Wins { get; set; } = string.Empty;
        public Constructor Constructor { get; set; } = new();
    }

    public class Constructor
    {
        public string ConstructorId { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Nationality { get; set; } = string.Empty;
    }
}
