using Microsoft.EntityFrameworkCore;
using Test2.Models;

namespace Test2.Data;

public class ApplicationContext : DbContext
{
    protected ApplicationContext()
    {
    }

    public ApplicationContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<Models.CharacterTitles> CharacterTitles { get; set; }
    public DbSet<Models.Characters> Characters { get; set; }
    public DbSet<Models.Items> Items { get; set; }
    public DbSet<Models.Titles> Titles { get; set; }
    public DbSet<Models.Backpacks> Backpacks { get; set; }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Items>().HasData(new List<Items>
        {
             new Items
             {
                 Id = 1,
                    Name = "Sword",
                    Weight = 3
             },
             
             new Items
             {
                 Id = 2,
                    Name = "Shield",
                    Weight = 5
             }
        });
        modelBuilder.Entity<Titles>().HasData(new List<Titles>
        {
             new Titles
             {
                 Id = 1,
                    Name = "Knight"
             },
             
             new Titles
             {
                 Id = 2,
                    Name = "Barbarian"
             }
        });
        modelBuilder.Entity<Characters>().HasData(new List<Characters>
        {
             new Characters
             {
                 Id = 1,
                    FirstName = "John",
                    LastName = "Kowalski",
                    CurrentWeight = 1,
                    MaxWeight = 2
             },
             
             new Characters
             {
                 Id = 2,
                 FirstName = "Johnio",
                 LastName = "Kowalskievich",
                 CurrentWeight = 4,
                 MaxWeight = 5
             }
        });
        
        modelBuilder.Entity<CharacterTitles>().HasData(new List<CharacterTitles>
        {
             new CharacterTitles
             {
                 CharacterID = 1,
                    TitleId = 1,
                    AcquiredAt = DateTime.Now
             },
             
             new CharacterTitles
             {
                 CharacterID = 2,
                    TitleId = 2,
                    AcquiredAt = DateTime.Today
             }
        });
        
        modelBuilder.Entity<Backpacks>().HasData(new List<Backpacks>
        {
             new Backpacks
             {
                 CharacterID = 1,
                 ItemID = 1,
                 Amount = 5
             },
             
             new Backpacks
             {
                 CharacterID = 2,
                 ItemID = 2,
                 Amount = 4
             }
        });
    }
}