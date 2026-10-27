using System;
using Godot;


// Throughout the backend, 'Player' refers to this class
public partial class Player
{

    // Sets variables for each Player, when ready to make one, call 'new Player()' and pass stats into parenthetical
    public string Name { get; set; }
    public int Health { get; set; }
    public int Strength { get; set; }
    // The Player is alive if health is above zero
    public bool IsAlive => Health > 0; 

    public Player(string name, int health, int strength)
    {
        Name = name;
        Health = health;
        Strength = strength;
    }
}