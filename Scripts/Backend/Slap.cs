using System;
using Godot;

public partial class Player
{
    public virtual void Slap(Player opponent)
    {
        // Strength directly affects health
        opponent.Health -= Strength; 
    }
}