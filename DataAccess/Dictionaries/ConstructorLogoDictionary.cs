﻿namespace DataAccess.Dictionaries;

public class ConstructorLogoDictionary
{
    private static readonly Dictionary<string, string> ConstructorURLs = new()
    {
        {"alfa", "https://cdn-7.motorsport.com/images/mgl/6xEeP710/s500/neuer-FullName-alfa-romeo-sauber--2-2.webp"},
        {"alphatauri", "https://cdn-5.motorsport.com/images/mgl/Y99JQR8Y/s500/scuderia-alphatauri-f1-logo-1.webp"},
        {"alpine", "https://cdn-3.motorsport.com/images/mgl/2y39NBX6/s500/alpine-f1-team-logo-1.webp"},
        {"aston_martin", "https://cdn-9.motorsport.com/images/mgl/YW745JBY/s500/aston-martin-cognizant-f1-team-1.webp"},
        {"ferrari", "https://cdn-7.motorsport.com/images/mgl/6D1a9D90/s500/scuderia-ferrari-logo-1.webp"},
        {"haas", "https://cdn-4.motorsport.com/images/mgl/0ZRgKzM0/s500/haas-logo-1.webp"},
        {"mclaren", "https://cdn-3.motorsport.com/images/mgl/YEQJgyLY/s500/mclaren-f1-team-logo-1.webp"},
        {"mercedes", "https://cdn-8.motorsport.com/images/mgl/0RrzmDo0/s500/mercedes-f1-logo-1.webp"},
        {"red_bull", "https://cdn-2.motorsport.com/images/mgl/Y99JQRbY/s500/red-bull-racing-logo-1.webp"},
        {"williams", "https://cdn-2.motorsport.com/images/mgl/2y39NBy6/s500/williams-racing-logo-1.webp"}
    };

    public static string GetLogoURL (string apiConstructorName)
    {
        try
        {
            return ConstructorURLs[apiConstructorName];
        }
        catch (KeyNotFoundException)
        {
            return "No data";
        }
    }
}
