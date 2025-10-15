namespace PokemonConsoleApp;

public class VersionGroupDetails
{
    public uint levelLearnedAt { get; set; }
    public Link MoveLearnMethod { get; set; }
    public object order;
    public Link VersionGroup { get; set; }

    public override string ToString()
    {
        return $"Level: {levelLearnedAt}, Move: {MoveLearnMethod}, Order: {order}, VersionGroup: {VersionGroup}";
    }
}