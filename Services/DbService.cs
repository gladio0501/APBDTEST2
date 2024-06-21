
using Microsoft.EntityFrameworkCore;
using Test2.Data;
using Test2.DTOs;
using Test2.Models;

namespace Task10.Services;

public class DbService : IDbService
{
    private readonly ApplicationContext _context;

    public DbService(ApplicationContext context)
    {
        _context = context;
    }


    public async Task<ICollection<Characters>> GetCharacterById(int characterId)
    {
        return await _context.Characters
            .Include(c => c.BackPacks)
            .ThenInclude(c => c.Items)
            .Include(c => c.CharacterTitles)
            .ThenInclude(c => c.Titles)
            .Where(c => c.Id == characterId)
            .ToListAsync();
    }
    
}