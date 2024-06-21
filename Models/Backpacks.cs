using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test2.Models;

[PrimaryKey(nameof(CharacterID), nameof(ItemID))]
public class Backpacks
{
    public int CharacterID { get; set; }
    public int ItemID { get; set; }
    public int Amount { get; set; }
    [ForeignKey(nameof(CharacterID))]
    public Characters Characters { get; set; } = null!;
    [ForeignKey(nameof(ItemID))]
    public Items Items { get; set; } = null!;
}