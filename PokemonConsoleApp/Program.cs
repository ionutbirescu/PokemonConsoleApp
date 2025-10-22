using System.Text.Json;

namespace PokemonConsoleApp;


class Program
{
    static void Main(string[] args)
    {
        var pokemonData= PokemonUtils.GetPokemonDataAsync("Pikachu").Result;
        Pokemon pikachu = JsonSerializer.Deserialize<Pokemon>(pokemonData);
        pokemonData= PokemonUtils.GetPokemonDataAsync("Bulbasaur").Result;
        Pokemon bulbasaur = JsonSerializer.Deserialize<Pokemon>(pokemonData);
        var battleSimulator = new BattleSimulator();
        if (battleSimulator.TryFindStrongestStat(pikachu, out string strongestStat, out int value))
        {
            Console.WriteLine($"Strongest Stat: {strongestStat} value: {value}");
        }
        foreach (var statElement in pikachu.stats)
        {
            if (statElement.stat.name.Equals("attack"))
            {
                Console.WriteLine($"Pikachu Attack Stat: {statElement.base_stat}");
            }
        }
        foreach (var statElement in bulbasaur.stats)
        {
            if (statElement.stat.name.Equals("attack"))
            {
                Console.WriteLine($"Bulbasaur Attack Stat: {statElement.base_stat}");
            }
        }
        battleSimulator.SimulateAttack(ref pikachu, ref bulbasaur);
        double average = battleSimulator.CalculateAverageStat("attack", pikachu, bulbasaur);
        Console.WriteLine($"Average Stat: {average}");
        
        List<BasePokemon> pokedex = new List<BasePokemon>();
        string[] names = { "pikachu", "bulbasaur", "mewtwo", "eevee" };
        
        foreach (var name in names)
        {
            pokemonData = PokemonUtils.GetPokemonDataAsync(name).Result;
            Pokemon pokemon = JsonSerializer.Deserialize<Pokemon>(pokemonData);
            var speciesData = PokemonSpeciesHelper.GetSpeciesDataAsync(pokemon.species.url).Result;
            BasePokemon basePokemon;
            if (speciesData.IsLegendary || speciesData.IsMythical)
            {
                basePokemon = new LegendaryPokemon
                {
                    id = pokemon.id,
                    name = pokemon.name,
                    weight = pokemon.weight,
                    species = pokemon.species,
                    SpecialType = speciesData.IsMythical ? "Mythical" : "Legendary"
                };
            }
            else
            {
                basePokemon = new StandardPokemon
                {
                    id = pokemon.id,
                    name = pokemon.name,
                    weight = pokemon.weight,
                    species = pokemon.species,
                };
            }
            pokedex.Add(basePokemon);
        }

        foreach (var pokemon in pokedex)
        {
            pokemon.DisplayInfo();
        }
        
    }
}
