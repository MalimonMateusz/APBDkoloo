namespace APBD_KOLO.DTOs;

public class GetCharactersDTO
{
public string firstName { get; set; }
public string lastName { get; set; }
public int currentWeight { get; set; }
public int maxWeight { get; set; }
public ICollection<GetBackPackItemsDTO> Items { get; set; } = null!;
public ICollection<GetTitles> Titles { get; set; } = null!;
}
public class GetTitles
{
    public string title { get; set; } = null!;
    public DateTime aquiredAt { get; set; }
}



public class GetBackPackItemsDTO
{
    public string itemName { get; set; } = null!;
    public int itemWeight { get; set; }
    public int Amount { get; set; }
}