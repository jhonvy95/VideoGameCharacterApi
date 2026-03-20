using VideoGameCharactersApi.Models;

namespace VideoGameCharactersApi.Services;

public interface IVideoGameCharacterService
{
    Task<List<Character>> GetAllCharactersAsync();
    Task<Character> GetCharacterByIdAsync(int id);
    Task<Character> CreateCharacterAsync(Character character);
    Task<bool> UpdateCharacterAsync(int id, Character character);
    Task<bool> DeleteCharacterAsync(int id);
}