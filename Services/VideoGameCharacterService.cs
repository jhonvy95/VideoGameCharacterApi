using Microsoft.EntityFrameworkCore;
using VideoGameCharactersApi.Data;
using VideoGameCharactersApi.Dtos;
using VideoGameCharactersApi.Models;

namespace VideoGameCharactersApi.Services;

public class VideoGameCharacterService(AppDbContext context) : IVideoGameCharacterService
{
    
    public async Task<List<CharacterResponse>> GetAllCharactersAsync()
    {
        return await context.Characters.Select(c => new CharacterResponse
        {
            Name = c.Name,
            Game = c.Game,
            Role = c.Role
        }).ToListAsync();
    }

    public async Task<CharacterResponse> GetCharacterByIdAsync(int id)
    {
        return await context.Characters.Where(c => c.Id == id).Select(c => new CharacterResponse
        {
            Name = c.Name,
            Game = c.Game,
            Role = c.Role
        }).FirstOrDefaultAsync();
    }

    public Task<CharacterResponse> CreateCharacterAsync(Character character)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateCharacterAsync(int id, Character character)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteCharacterAsync(int id)
    {
        throw new NotImplementedException();
    }
}