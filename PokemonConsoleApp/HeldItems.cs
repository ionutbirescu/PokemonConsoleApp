namespace PokemonConsoleApp;

public class HeldItems
{
    public Link item{get;set;}
    public VersionDetails[] version_details{get;set;}

    public override string ToString()
    {
        return $"Item: {item} Version: {version_details}";
    }
}