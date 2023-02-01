using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using DataAccess.API;
using DataAccess.Database;
using DataAccess.Services;
using DataAccess.Dictionaries;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddSingleton<ApiService>();
builder.Services.AddSingleton<AppStateService>();
builder.Services.AddSingleton<DriverIdDictionary>();
builder.Services.AddSingleton<ConstructorIdDictionary>();

builder.Services.AddTransient<ISqlDataAccess, SqlDataAccess>();
builder.Services.AddTransient<IUserData, UserData>();
builder.Services.AddTransient<ILeagueData, LeagueData>();
builder.Services.AddTransient<ITeamData, TeamData>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
