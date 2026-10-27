using System;
using System.Security;
using Godot;

public class Team
{
    // Sets teams display name
    public string Name { get; set; }

    // All Players on this team
    public List<Player> Fighters { get; } = new();
    public Team(string name) => Name = name;

    // Only Players with health remaining remain on the team, Players with zero health don't participate.
    public IEnumerable<Player> Alive => Fighters.Where(f => f.IsAlive);

    // False while the team has more than zero living fighters
    public bool IsOut => !Alive.Any();

 }