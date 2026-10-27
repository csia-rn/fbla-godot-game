using Godot;

public partial class Quit : Button
{
    public override void _Ready()
    {
        Pressed += OnExitPressed;
    }

    private void OnExitPressed()
    {
        GetTree().Quit();
    }
}