namespace PokemonConsoleApp;

public class StandardPokemon : BasePokemon
{
    public override void DisplayInfo()
    {
        Console.WriteLine($"ID {id}");
        Console.WriteLine($"Name {name}");
        Console.WriteLine($"Weight {weight}");
        Console.WriteLine($"Species {species.ToString()}");
    }
}