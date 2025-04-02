using System;
using System.Collections.Generic;
using FootballSim.Teams;
using FootballSim.Utils;

namespace FootballSim.Leagues;

public class League
{
    public string Name {get; set;}
    public DateTime SeasonStart { get; private set; }
    public DateTime SeasonEnd { get; private set; }
    public int TeamAmount {get; set;}
    public Nationalities Nation {get; set;}
    public Continents Continent {get; set;}
    public List<Team> Teams {get; set;}

    public League(string name, DateTime seasonStart, DateTime seasonEnd, int teamAmount, Nationalities nation, Continents continent, List<Team> teams){

        Name = name;
        SeasonStart = seasonStart;
        SeasonEnd = seasonEnd;
        TeamAmount = teamAmount;
        Nation = nation;
        Continent = continent;
        Teams = teams;

    }
}