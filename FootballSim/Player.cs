using System;
using System.Collections.Generic;
using FootballSim.Teams;
using FootballSim.Utils;

namespace FootballSim.Players;

public class Player
{
    public string Name { get; private set; }
    public DateTime Birthday { get; private set; }
    public Nationalities Nation { get; private set; }
    public Team CurrentTeam { get; set; }
    public int OverallRating { get; set; }
    public Dictionary<PlayerPosition, int> Positions { get; set; }

    public Player(string name, DateTime birthday, Nationalities nation, Team currentTeam, int overallRating, Dictionary<PlayerPosition, int> positions){

        Name = name;
        Birthday = birthday;
        Nation = nation;
        CurrentTeam = currentTeam;
        OverallRating = overallRating;
        Positions = positions;
    }

    public int GetAge(DateTime now){

        int age = now.Year - Birthday.Year;
        if (new DateTime(now.Year, Birthday.Month, Birthday.Day) < now)
        {
            age--;
        }

        return age;
    }
    
}
