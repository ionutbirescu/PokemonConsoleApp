namespace PokemonConsoleApp;

public class Pokemon
{
    public Abilities[] abilities { get; set; }
    public uint base_experience { get; set; }
    public Cries cries { get; set; }
    public Link[] forms { get; set; }
    public GameIndices[] games { get; set; }
    public uint height { get; set; }
    public HeldItems[] held_items { get; set; }
    public uint id { get; set; }
    public bool is_default { get; set; }
    public string location_area_encounters { get; set; }
    public Moves[] moves { get; set; }
    public string name { get; set; }
    public uint order { get; set; }
    public PastAbilities[] past_abilities { get; set; }
    public Types[] past_types { get; set; }
    public Link species { get; set; }
    public object sprites { get; set; }
    public StatElement[] stats { get; set; }
    public Types[] types { get; set; }
    public uint weight { get; set; }
}