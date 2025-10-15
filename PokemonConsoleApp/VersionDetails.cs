namespace PokemonConsoleApp;

public class VersionDetails
{
    public uint rarity {get; set; }
    public Link version { get; set; }

    public override string ToString()
    {
        return "rarity: " + rarity + ", version: " + version.ToString();
    }
}