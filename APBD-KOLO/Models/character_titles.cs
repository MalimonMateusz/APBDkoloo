using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APBD_KOLO.Models;

[Table("Order_Pastry")]
[PrimaryKey(nameof(CharacterId), nameof(TitleId))]
public class character_titles
{
    public int CharacterId { get; set; }
    public int TitleId { get; set; }
    public DateTime AcquiredAt { get; set; }
    [ForeignKey(nameof(CharacterId))]
    public characters Characters { get; set; } = null!;
    [ForeignKey(nameof(TitleId))]
    public titles Titles { get; set; } = null!;
}