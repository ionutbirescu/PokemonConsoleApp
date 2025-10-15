namespace PokemonConsoleApp;

public class PastAbilities
{
    public Abilities abilities_type { get; set; }
    public Link generation { get; set; }

    public override string ToString()
    {
        return $"Type: {abilities_type.ToString()}, Generation: {generation.ToString()}";
    }
}