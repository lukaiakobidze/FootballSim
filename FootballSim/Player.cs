namespace FootballSim.Players;

public class Player
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Nationality { get; set; }
    public Teams.Team CurrentTeam { get; set; }
}