using System.ComponentModel.DataAnnotations;

namespace APBD_KOLO.Models;

public class characters
{
    [Key]
    public int Id { get; set; }  
    [MaxLength(50)]
    public string FirstName { get; set; } = string.Empty;
    [MaxLength(120)]
    public string LastName { get; set; } = string.Empty;
    public int CurrentWei { get; set; }
    public int MaxWeight { get; set; }
    
    public ICollection<backpacks> Backpacks { get; set; } = new HashSet<backpacks>();
    public ICollection<character_titles> Character_titles { get; set; } = new HashSet<character_titles>();
}