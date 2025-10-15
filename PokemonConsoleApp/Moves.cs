namespace PokemonConsoleApp;

public class Moves
{
    public Link single_move { get; set; }
    public VersionGroupDetails version_group { get; set; }

    public override string ToString()
    {
        return $"Single Move: {single_move} \n Group: {version_group}";
    }
}