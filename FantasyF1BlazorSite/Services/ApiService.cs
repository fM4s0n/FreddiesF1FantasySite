namespace FreddiesF1FantasySite.Services;

public class ApiService
{
    /// <summary>
    /// Gets current driver standings as of most recent race
    /// </summary>
    ///  <returns>Json file or error message</returns>
    public async Task<string> GetDriverStandingsAsync (string year)
    {
        string result;
        try
        {
            using HttpClient client = new();
            result = await client.GetStringAsync($"http://ergast.com/api/f1/{year}/driverStandings.json?limit=90");
            return result;
        }
        catch (Exception)
        {
            return "0";
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="year"></param>
    /// <returns></returns>
    public async Task<string> GetConstructorStandingsAsync (string year)
    {
        string result;

        try
        {
            using HttpClient client = new();
            {
                result = await client.GetStringAsync($"http://ergast.com/api/f1/{year}/constructorStandings.json?limit=20");
                return result;
            }
        }
        catch (Exception)
        {
            return "0";
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="year"></param>
    /// <returns></returns>
    public async Task<string> GetSeasonScheduleAsync (string year)
    {
        string result;

        try
        {
            using HttpClient client = new();
            {
                result = await client.GetStringAsync($"http://ergast.com/api/f1/{year}.json");
                return result;
            }
        }
        catch (Exception)
        {
            return "0";
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="season"></param>
    /// <param name="driverId"></param>
    /// <returns></returns>
    public async Task<string> GetDriverResultsAsync (int season, string driverId)
    {
        string result;
        string currentMonth = DateTime.Now.Month.ToString();

        if (currentMonth == "1" || currentMonth == "2")
            season -= 1;

        try
        {
            using HttpClient client = new();
            {
                result = await client.GetStringAsync($"https://ergast.com/api/f1/{season}/drivers/{driverId}/driverstandings.json");
                return result;
            }
        }
        catch (Exception)
        {
            return "0";
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="season"></param>
    /// <param name="constructorId"></param>
    /// <returns></returns>
    public async Task<string> GetConstructorResultsAsync (int season, string constructorId)
    {
        string result;
        string currentMonth = DateTime.Now.Month.ToString();

        if (currentMonth == "1" || currentMonth == "2")
            season -= 1;

        try
        {
            using HttpClient client = new();
            {
                result = await client.GetStringAsync($"https://ergast.com/api/f1/{season}/constructors/{constructorId}/constructorstandings.json");
                return result;
            }
        }
        catch (Exception)
        {
            return "0";
        }
    }
}
