using Microsoft.AspNetCore.Mvc;
using StarWarsCharacters.Response;

namespace StarWarsCharacters.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharactersController : ControllerBase
    {
        private readonly SwapiService _swapiService;
        public CharactersController(SwapiService service)
        {
            _swapiService = service;
        }

        [HttpGet("characters")]
        public async Task<IActionResult> GetCharacters()
        {
            var result = await _swapiService.GetPeopleAsync();
            var response = result.Select(r => new BaseCharacterInfo
            {
                BirthYear = r.BirthYear, Gender = r.Gender, Name = r.Name
            });
            return Ok(response);
        }

        [HttpGet("characters/{id}")]
        public async Task<IActionResult> GetCharactersById([FromRoute] string id)
        {
            var result = await _swapiService.GetPeopleByIdAsync(id);
            if (result is null)
            {
                return NotFound($"Character with id: {id} not found");
            }
            return Ok(result);
        }

        [HttpPost("informations")]
        public async Task<IActionResult> GetAdditionalInfo()
        {
            //var result = await _swapiService
        }
    }
}
