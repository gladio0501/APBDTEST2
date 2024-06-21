using System.ComponentModel.DataAnnotations;

namespace Test2.Models;

public class Titles
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public ICollection<CharacterTitles> CharacterTitles { get; set; } = new HashSet<CharacterTitles>();
}