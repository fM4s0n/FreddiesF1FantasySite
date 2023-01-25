﻿using DataAccess.Dictionaries;

namespace DataAccess.Models;

public class UserModel
{
    public int UserID { get; set; }
    public string Username { get; set; } = "";
    public string Password { get; set; } = "";
    public string FullName { get; set; } = "";
    public string FavouriteDriverName { get; set; } = "";
    public string FavouriteDriverId { get; set; } = "";
    public string FavouriteConstructorName { get; set; } = "";
    public string FavouriteConstructorId { get; set; } = "";

    //public List<FantasyF1LeagueMembership> FantasyLeagueMemberships { get; set; }
}