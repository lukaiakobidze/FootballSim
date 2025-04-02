using System.Collections.Generic;
using FootballSim.Leagues;
using FootballSim.Players;

namespace FootballSim.Teams;

public class Team
{
    public string Name { get; set; }
    public string NameShort { get; set; }
    public League League { get; set; }
    public string Stadium { get; set; }
    public int Budget { get; set; }
    public List<Player> Players { get; set; }

    public Team(string name, string nameShort, League league, string stadium, int budget, List<Player> players){
        Name = name;
        NameShort = nameShort;
        League = league;
        Stadium = stadium;
        Budget = budget;
        Players = players;
    }
}