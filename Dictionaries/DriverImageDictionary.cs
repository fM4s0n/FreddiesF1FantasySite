namespace FreddiesF1FantasySite.Dictionaries; 

internal class DriverImageDictionary
{
    private static readonly Dictionary<string, string> DriverImages = new()
    {
        {"albon", "https://cdn-6.motorsport.com/images/mgl/2jXdJPk6/s500/alex-albon-williams-1.webp"},
        {"alonso", "https://cdn-9.motorsport.com/images/mgl/YW7pr5eY/s500/fernando-alonso-aston-martin-1.webp"},
        {"bottas", "https://cdn-2.motorsport.com/images/mgl/YMdyzAV2/s500/valtteri-bottas-alfa-romeo-1.webp"},
        {"gasly", "https://cdn-1.motorsport.com/images/mgl/2eAv57l2/s500/pierre-gasly-alpine-1.webp"},
        {"hamilton", "https://cdn-1.motorsport.com/images/mgl/0mb95oa2/s500/lewis-hamilton-mercedes-1.webp"},
        {"hulkenberg", "https://cdn-5.motorsport.com/images/mgl/6gpAmdm0/s500/nico-hulkenberg-haas-f1-team-1.webp"},
        {"leclerc", "https://cdn-6.motorsport.com/images/mgl/6VRnqmN6/s500/charles-leclerc-ferrari-1.webp"},
        {"kevin_magnussen", "https://cdn-8.motorsport.com/images/mgl/24vOGKX6/s500/kevin-magnussen-haas-f1-team-1.webp"},
        {"norris", "https://cdn-8.motorsport.com/images/mgl/0L1nLWJ2/s500/lando-norris-mclaren-1.webp"},
        {"ocon", "https://cdn-3.motorsport.com/images/mgl/6zQ7ev7Y/s500/esteban-ocon-alpine-1.webp"},
        {"perez", "https://cdn-6.motorsport.com/images/mgl/0a9neZP0/s500/sergio-perez-red-bull-racing-1.webp"},
        {"piastri", "https://cdn-9.motorsport.com/images/mgl/6D1QjZ40/s500/oscar-piastri-mclaren-1.webp"},
        {"russell", "https://cdn-9.motorsport.com/images/mgl/6l9yjoj0/s500/george-russell-mercedes-1.webp"},
        {"sainz", "https://cdn-6.motorsport.com/images/mgl/YXRnk570/s500/carlos-sainz-jr-ferrari-1.webp"},
        {"sargeant", "https://cdn-3.motorsport.com/images/mgl/63vxNmqY/s500/logan-sargeant-williams-racing-1.webp"},
        {"stroll", "https://cdn-4.motorsport.com/images/mgl/0RrnLBB0/s500/lance-stroll-aston-martin-1.webp"},
        {"tsunoda", "https://cdn-1.motorsport.com/images/mgl/YBeA8VB2/s500/yuki-tsunoda-alphatauri-at03-1.webp"},
        {"max_verstappen", "https://cdn-5.motorsport.com/images/mgl/24vA3r46/s500/max-verstappen-red-bull-racing-1.webp"},
        {"de_vries", "https://cdn-6.motorsport.com/images/mgl/254glZl0/s500/nyck-de-vries-scuderia-alphata-1.webp"},
        {"zhou", "https://cdn-1.motorsport.com/images/mgl/YW7prKOY/s500/zhou-guanyu-alfa-romeo-c42-1.webp"}
    };

    public static string ConvertDriverName (string apiName)
    {
        try
        {
            return DriverImages[apiName];
        }
        catch (Exception)
        {
            return "No data";
        }
    }
}
