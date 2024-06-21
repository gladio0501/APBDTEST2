using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test2.Models;
[Table("Character_Titles")]
[PrimaryKey(nameof(CharacterID), nameof(TitleId))]
public class CharacterTitles
{
    public int CharacterID { get; set; }
    public int TitleId { get; set; }
    public DateTime AcquiredAt { get; set; }
    
    [ForeignKey(nameof(CharacterID))]
    public Characters Characters { get; set; } = null!;
    [ForeignKey(nameof(TitleId))]
    public Titles Titles { get; set; } = null!;
}