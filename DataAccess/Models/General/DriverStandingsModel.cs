namespace DataAccess.Models.General;

public class DriverStandingsModel
{
    public class MRData
    {
        public StandingsTable StandingsTable { get; set; } = new();
        public RaceTable RaceTable { get; set; } = new();
        public int Total { get; set; }
    }

    public class RaceTable
    {
        public int Round { get; set; }
    }

    public class StandingsTable
    {
        public List<StandingsList> StandingsLists { get; set; } = new();
    }

    public class StandingsList
    {
        public List<DriverStandings> DriverStandings { get; set; } = new();
    }

    public class DriverStandings
    {
        public int Position { get; set; }
        public double Points { get; set; }
        public int Wins { get; set; }
        public Driver Driver { get; set; } = new();
        public List<Constructors> Constructors { get; set; } = new();
    }

    public class Driver
    {
        public string DriverId { get; set; } = string.Empty;
        public int PermanentNumber { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string GivenName { get; set; } = string.Empty;
        public string FamilyName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string Nationality { get; set; } = string.Empty;
        public string FullName
        {
            get { return $"{GivenName} {FamilyName}"; }
        }
    }

    public class Constructors
    {
        public string ConstructorId { get; set; } = string.Empty;
        public string Url { set; get; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Nationality { get; set; } = string.Empty;
    }

    public class Root
    {
        public MRData MRData { get; set; } = new();
    }
}
