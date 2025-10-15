namespace PokemonConsoleApp;

public class StatElement
{
    public uint base_stat { get; set; }
    public uint effort { get; set; }
    public Link stat { get; set; }

    public override string ToString()
    {
        return $" baseStat: {base_stat} effort: {effort}" +
               $" stat: {stat}";
    }
}