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
    }
}
