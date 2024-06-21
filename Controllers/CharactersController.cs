
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Task10.Services;
using Test2.DTOs;

namespace Test2.Controllers;



[ApiController]
[Route("[controller]")]
public class CharactersController : ControllerBase
{
    private readonly IDbService _dbService;
    public CharactersController(IDbService dbService)
    {
        _dbService = dbService;
    }

    [HttpGet("{characterId}")]
    public async Task<IActionResult> GetCharacterAsync(int characterId)
    {
        var character = await _dbService.GetCharacterById(characterId);
        return Ok(character.Select(c => new GetCharacterDTO()
        {
            FirstName = c.FirstName,
            LastName = c.LastName,
            CurrentWeight = c.CurrentWeight,
            MaxWeight = c.MaxWeight,
            backpackItems = c.BackPacks.Select(b =>new ItemDTO()
            {
                Name = b.Items.Name,
                Weight = b.Items.Weight,
                Amount = b.Amount   
            }).ToList().ToList(),
            Titles = c.CharacterTitles.Select(t => new TitleDTO()
            {
                Name = t.Titles.Name,
                AcquiredAt = t.AcquiredAt
            }).ToList()
                
        }));
    }

}