namespace PokemonConsoleApp;

public class LegendaryPokemon : BasePokemon
{
    public string SpecialType { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine($"***Name {name.ToUpper()}***");
        Console.WriteLine($"ID {id}");
        Console.WriteLine($"Weight {weight}");
        Console.WriteLine($"Species {species.ToString()}");
        Console.WriteLine($"Special Type {SpecialType}");
    }
}