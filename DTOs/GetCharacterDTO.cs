namespace Test2.DTOs;

public class GetCharacterDTO
{
    public String FirstName { get; set; }
    public String LastName { get; set; }
    public int CurrentWeight { get; set; }
    public int MaxWeight { get; set; }
    public ICollection<ItemDTO> backpackItems { get; set; }
    public ICollection<TitleDTO> Titles { get; set; }
    
    
}
public class ItemDTO
{
    public string Name { get; set; }
    public int Weight { get; set; }
    public int Amount { get; set; }
}
public class BackpackDTO
{
    public int Id { get; set; }
    public int CharacterId { get; set; }
    public ICollection<ItemDTO> Items { get; set; }
}

public class TitleDTO
{
    public string Name { get; set; }
    public DateTime AcquiredAt { get; set; }
}