namespace PokemonConsoleApp;

public class Types
{
    public uint slot;
    public Link type { get; set; }

    public override string ToString()
    {
        return $"slot: {slot} Type: {type}";
    }
}