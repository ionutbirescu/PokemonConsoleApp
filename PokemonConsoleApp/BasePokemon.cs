namespace PokemonConsoleApp;

public abstract class BasePokemon
{
    public uint id { get; set; }
    public string name { get; set; }
    public uint weight { get; set; }
    public Link species { get; set; }
    
    public abstract void DisplayInfo();

}