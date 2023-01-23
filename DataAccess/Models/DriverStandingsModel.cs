namespace DataAccess.Models;

public class DriverStandingsModel
{
    public class MRData
    {
        public StandingsTable? StandingsTable { get; set; }
        public RaceTable? RaceTable { get; set; }
        public int? Total { get; set; }
    }

    public class RaceTable
    {
        public int? Round { get; set; }
    }

    public class StandingsTable
    {
        public List<StandingsList>? StandingsLists { get; set; }
    }

    public class StandingsList
    {
        public List<DriverStandings>? DriverStandings { get; set; }
    }

    public class DriverStandings
    {
        public int Position { get; set; }
        public double Points { get; set; }
        public int Wins { get; set; }
        public Driver? Driver { get; set; }
        public List<Constructors>? Constructors { get; set; }
    }

    public class Driver
    {
        public string? DriverId { get; set; }
        public int? PermanentNumber { get; set; }
        public string? Code { get; set; }
        public string? Url { get; set; }
        public string? GivenName { get; set; }
        public string? FamilyName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Nationality { get; set; }
        public string? FullName
        {
            get { return $"{GivenName} {FamilyName}"; }
        }
    }

    public class Constructors
    {
        public string ConstructorId { get; set; } = "";
        public string Url { set; get; } = "";
        public string Name { get; set; } = "";
        public string Nationality { get; set; } = "";
    }

    public class Root
    {
        public MRData? MRData { get; set; }
    }
}
