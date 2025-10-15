namespace PokemonConsoleApp;

public class GameIndices
{
    public uint game_index { get; set; }
    public Link version_type {get;set;}

    public override string ToString()
    {
        return $"Game Index: {game_index}\n Version Type: {version_type}" ;
    }
}