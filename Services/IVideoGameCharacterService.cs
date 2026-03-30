using VideoGameCharactersApi.Dtos;
using VideoGameCharactersApi.Models;

namespace VideoGameCharactersApi.Services;

public interface IVideoGameCharacterService
{
    Task<List<CharacterResponse>> GetAllCharactersAsync();
    Task<CharacterResponse?> GetCharacterByIdAsync(int id);
    Task<CharacterResponse> CreateCharacterAsync(Character character);
    Task<bool> UpdateCharacterAsync(int id, Character character);
    Task<bool> DeleteCharacterAsync(int id);
}