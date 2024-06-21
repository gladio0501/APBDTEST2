using System.ComponentModel.DataAnnotations;

namespace Test2.Models;

public class Characters
{
    [Key]
    public int Id{ get; set; }
    [MaxLength(100)]
    public string FirstName { get; set; }
    [MaxLength(100)]
    public string LastName { get; set; }
    public int CurrentWeight { get; set; }
    public int MaxWeight { get; set; }
    public ICollection<CharacterTitles> CharacterTitles { get; set; } = new HashSet<CharacterTitles>();
    public ICollection<Backpacks> BackPacks { get; set; } = new HashSet<Backpacks>();
}