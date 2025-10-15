namespace PokemonConsoleApp;

public class Abilities
{
    public Link abilityType {get; set;}
    public bool is_hidden { get; set; }
    public uint slot;
    
    public override string ToString()
    {
        return abilityType.ToString() + 
               "\nis_hidden: " + is_hidden.ToString() +
               "\nslot: " + slot.ToString();
    }
}