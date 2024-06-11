using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APBD_KOLO.Models;
[Table("backpacks")]
[PrimaryKey(nameof(CharacterId), nameof(ItemId))]
public class backpacks
{
    public int CharacterId { get; set; }
    public int ItemId { get; set; } 
    public int Amount { get; set; }
    
    [ForeignKey(nameof(CharacterId))]
    public characters Characters { get; set; } = null!;
    [ForeignKey(nameof(ItemId))]
    public items Items { get; set; } = null!;

}