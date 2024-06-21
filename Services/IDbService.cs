

using Test2.DTOs;
using Test2.Models;

namespace Task10.Services;

public interface IDbService
{
    Task<ICollection<Characters>> GetCharacterById(int characterId);
}