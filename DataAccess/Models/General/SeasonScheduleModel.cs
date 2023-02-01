using System.Globalization;

namespace DataAccess.Models.General;

public class SeasonScheduleModel
{
    public class Root
    {
        public MRData MRData { get; set; } = new();
    }

    public class MRData
    {
        public string Total { get; set; } = string.Empty;
        public RaceTable RaceTable { get; set; } = new();
    }

    public class RaceTable
    {
        public string Season { get; set; } = string.Empty;
        public List<Race>? Races { get; set; }
    }

    public class Race
    {
        public string Season { get; set; } = string.Empty;
        public string Round { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string RaceName { get; set; } =     string.Empty;
        public Circuit Circuit { get; set; } = new();
        public string Date { get; set; } = string.Empty;
        public string Time { get; set; } = string.Empty;
        public FirstPractice FirstPractice { get; set; } = new();
        public SecondPractice SecondPractice { get; set; } = new();
        public ThirdPractice ThirdPractice { get; set; } = new();
        public Qualifying Qualifying { get; set; } = new();
        public Sprint Sprint { get; set; } = new();
        public string DateEnglishFormat
        {
            get { return DateTime.ParseExact(Date, format: "yyyy-mm-dd", CultureInfo.InvariantCulture).ToString(format: "dd/mm/yy"); }
        }
    }

    public class Circuit
    {
        public string CircuitId { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string CircuitName { get; set; } = string.Empty;
        public Location Location { get; set; } = new();
    }

    public class Location
    {
        public string Lat { get; set; } = string.Empty;
        public string Long { get; set; } = string.Empty;
        public string Locality { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
    }

    public class FirstPractice
    {
        public string Date { get; set; } = string.Empty;
        public string Time { get; set; } = string.Empty;
    }

    public class SecondPractice
    {
        public string Date { get; set; } = string.Empty;
        public string Time { get; set; } = string.Empty;
    }

    public class ThirdPractice
    {
        public string Date { get; set; } = string.Empty;
        public string Time { get; set; } = string.Empty;
    }

    public class Qualifying
    {
        public string Date { get; set; } = string.Empty;
        public string Time { get; set; } = string.Empty;
    }

    public class Sprint
    {
        public string Date { get; set; } = string.Empty;
        public string Time { get; set; } = string.Empty;
    }
}
