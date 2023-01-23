namespace FreddiesF1FantasySite.Models;

/// <summary>
/// Used for driver results for the favourite driver control on homepage
/// </summary>
public class DriverResultsModel
{
    public class Root
    {
        public MRData? MRData { get; set; }
    }

    public class MRData
    {
        public string? Total { get; set; }
        public Standingstable? StandingsTable { get; set; }
    }

    public class Standingstable
    {
        public string? Season { get; set; }
        public string? DriverId { get; set; }
        public List<Standingslist>? StandingsLists { get; set; }
    }

    public class Standingslist
    {
        public string? Season { get; set; }
        public string? Round { get; set; }
        public List<DriverStanding>? DriverStandings { get; set; }
    }

    public class DriverStanding
    {
        public string? Position { get; set; }
        public string? PositionText { get; set; }
        public string? Points { get; set; }
        public string? Wins { get; set; }
        public Driver? Driver { get; set; }
        public List<Constructor>? Constructors { get; set; }
    }

    public class Driver
    {
        public string? DriverId { get; set; }
        public string? PermanentNumber { get; set; }
        public string? Code { get; set; }
        public string? Url { get; set; }
        public string? GivenName { get; set; }
        public string? FamilyName { get; set; }
        public string? DateOfBirth { get; set; }
        public string? Nationality { get; set; }
    }

    public class Constructor
    {
        public string? ConstructorId { get; set; }
        public string? Url { get; set; }
        public string? Name { get; set; }
        public string? Nationality { get; set; }
    }
}
