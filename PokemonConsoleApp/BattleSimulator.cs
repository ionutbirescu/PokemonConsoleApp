namespace PokemonConsoleApp;

public class BattleSimulator : IBattleSimulator
{
    public bool TryFindStrongestStat(Pokemon pokemon, out string statName, out int statValue)
    {
        statValue = -1;
        statName = null;
        foreach (var varStatElement in pokemon.stats)
        {
            if (varStatElement.base_stat > statValue)
            {
                statValue = varStatElement.base_stat;
                statName = varStatElement.stat.name;
            }
        }
        return statValue > -1;
    }

    // Uses 'ref' to directly modify the state of the battling Pokémon.
    public void SimulateAttack(ref Pokemon attacker, ref Pokemon defender)
    {
        var attackerStatValue = -1;
        var defenderStatValue = -1;
        foreach (var attackerStatElement in attacker.stats)
        {
            if (attackerStatElement.stat.name.Equals("attack"))
            {
                attackerStatValue = attackerStatElement.base_stat;
            }
        }

        foreach (var defenderStatElement in defender.stats)
        {
            if (defenderStatElement.stat.name.Equals("defense"))
            {
                defenderStatValue = defenderStatElement.base_stat;
            }
        }
        var damage = attackerStatValue - defenderStatValue;
        foreach (var statElement in defender.stats)
        {
            if (statElement.stat.name.Equals("hp"))
            {
                Console.WriteLine($"HP Before: {statElement.base_stat} ");
                statElement.base_stat = statElement.base_stat - damage;
                Console.WriteLine($"HP After: {statElement.base_stat} ");
            }
        }
        
    }
    
    // Uses 'params' to accept a variable number of Pokémon for analysis.
    public double CalculateAverageStat(string statName, params Pokemon[] pokemonTeam)
    {
        double total = 0;
        int count = 0;

        foreach (var pokemon in pokemonTeam)
        {
            foreach (var statElement in pokemon.stats)
            {
                if (statElement.stat.name.Equals(statName))
                {
                    total += statElement.base_stat;
                    count++;
                }
            }
        }
        
        return total / count;
    }
}