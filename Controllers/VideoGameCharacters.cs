using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VideoGameCharactersApi.Models;
using VideoGameCharactersApi.Services;

namespace VideoGameCharactersApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameCharacters(IVideoGameCharacterService service) : ControllerBase
    {
        
        [HttpGet]
        public async Task<ActionResult<List<Character>>> GetCharacters()
        {
            return  Ok( await service.GetAllCharactersAsync());
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Character>> GetCharacterById(int id)
        {
            var character = await service.GetCharacterByIdAsync(id);
            
            if (character == null)
            {
                return NotFound();
            }
            
            return Ok(character);
        }
    }
}
