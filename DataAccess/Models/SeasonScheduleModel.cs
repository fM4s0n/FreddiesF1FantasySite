using System.Globalization;

namespace DataAccess.Models;

public class SeasonScheduleModel
{
    public class Root
    {
        public MRData? MRData { get; set; }
    }

    public class MRData
    {
        public string? Total { get; set; }
        public RaceTable? RaceTable { get; set; }
    }

    public class RaceTable
    {
        public string? Season { get; set; }
        public List<Race>? Races { get; set; }
    }

    public class Race
    {
        public string? Season { get; set; }
        public string? Round { get; set; }
        public string? Url { get; set; }
        public string? RaceName { get; set; }
        public Circuit? Circuit { get; set; }
        public string Date { get; set; } = "";
        public string? Time { get; set; }
        public FirstPractice? FirstPractice { get; set; }
        public SecondPractice? SecondPractice { get; set; }
        public ThirdPractice? ThirdPractice { get; set; }
        public Qualifying? Qualifying { get; set; }
        public Sprint? Sprint { get; set; }
        public string? DateEnglishFormat
        {
            get { return DateTime.ParseExact(Date, format: "yyyy-mm-dd", CultureInfo.InvariantCulture).ToString(format: "dd/mm/yy"); }
        }
    }

    public class Circuit
    {
        public string? CircuitId { get; set; }
        public string? Url { get; set; }
        public string? CircuitName { get; set; }
        public Location? Location { get; set; }
    }

    public class Location
    {
        public string? Lat { get; set; }
        public string? Long { get; set; }
        public string? Locality { get; set; }
        public string? Country { get; set; }
    }

    public class FirstPractice
    {
        public string? Date { get; set; }
        public string? Time { get; set; }
    }

    public class SecondPractice
    {
        public string? Date { get; set; }
        public string? Time { get; set; }
    }

    public class ThirdPractice
    {
        public string? Date { get; set; }
        public string? Time { get; set; }
    }

    public class Qualifying
    {
        public string? Date { get; set; }
        public string? Time { get; set; }
    }

    public class Sprint
    {
        public string? Date { get; set; }
        public string? Time { get; set; }
    }
}
