namespace PokemonConsoleApp;

public class Link
{
    public string name { get; set; }
    public string url { get; set; }
    
    public override string ToString()
    {
        return "Name: " + name + ", Url: " + url;
    }
}