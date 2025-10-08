namespace PokemonConsoleApp;

public class Cries
{
    public string legacy { get; set; }
    public string latest { get; set; }

    public override string ToString()
    {
        return "\nLegacy: "+legacy+ "\n" + "Latest: "+ latest;
    }
}