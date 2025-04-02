using System;
using FootballSim.Leagues;
using FootballSim.Teams;

namespace FootballSim.Save;

public class Save{

    public DateTime Now { get; private set; }
    public Team MyTeam {get; set;}
    public League MyLeague {get; set;}
    public Save(DateTime now, Team myTeam){
        Now = now;
        MyTeam = myTeam;

    }
}