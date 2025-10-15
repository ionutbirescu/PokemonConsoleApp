using System.Text.Json;

namespace PokemonConsoleApp;


class Program
{
    static void Main(string[] args)
    {
        var pokemonData= PokemonUtils.GetPokemonDataAsync("Pikachu").Result;
        Pokemon myPokemon = JsonSerializer.Deserialize<Pokemon>(pokemonData);
        Console.WriteLine(myPokemon.name+ " ");
        foreach (var statElement in myPokemon.stats)
        {
            Console.WriteLine(statElement);
        }
    }
}
