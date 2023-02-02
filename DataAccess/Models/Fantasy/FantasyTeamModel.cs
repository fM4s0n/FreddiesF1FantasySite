using System.Reflection.Metadata.Ecma335;

namespace DataAccess.Models.Fantasy;


//only store ids in the table. user tha id to then read a different table in the db to get the rest of the info to populate the object


/// <summary>
/// Model for a user's fantasy team
/// </summary>
public class FantasyTeamModel
{
    public string TeamId { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    //UserId of who owns the Team
    public string OwnerId { get; set; } = string.Empty;

    //LeagueId of the league a team is associated with - can be null incase they get kicked from a league
    public string LeagueId { get; set; } = string.Empty;

    public List<ConstructorTeamMembershipModel> Constructors { get; set; } = new();    

    public List<DriverTeamMembershipModel> Drivers { get; set; } = new();

    //Can get
    public string BoostedDriverId { get; set; } = string.Empty;

    //Need to store
    public double BudgetRemaining { get; set; } = 100.0;

    //Vaalue of the team based on current values
    public double CurrentTeamValue
    {
        get
        {
            double val = 0;
            foreach(ConstructorTeamMembershipModel ctm in Constructors)            
                val += ctm.CurrentValue;
            
            foreach(DriverTeamMembershipModel dtm in Drivers)            
                val += dtm.CurrentValue;            

            return val;
        }
    }

    //Value of the team based on their purchased values
    public double PurchasedTeamValue 
    {
        get
        {
            double val =0;
            foreach(ConstructorTeamMembershipModel ctm in Constructors)            
                val += ctm.PurchasedValue;
            
            foreach(DriverTeamMembershipModel dtm in Drivers)
                val += dtm.CurrentValue;

            return val;
        }
    }

    //Can calculate from driverTeamMembersip
    public double TotalPoints { get; set; }

    public DateTime CreatedDate { get; set; }

    public int TeamChangesCompleted { get; set; }
}
