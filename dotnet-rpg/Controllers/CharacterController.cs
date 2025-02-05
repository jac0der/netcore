using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;
        public CharacterController(ICharacterService characterService)
        {
            this._characterService = characterService;
            
        }

        [HttpGet]
        public async Task<ActionResult<Character>> Get()
        {
            return Ok(await _characterService.GetDefaultCharacter());
        }

        [HttpGet]
        [Route("getall")]
        public async Task<ActionResult<List<Character>>> GetAll()
        {
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("getfirst")]
        public async Task<ActionResult<Character>> GetFirstCharacter()
        {
            return Ok(await _characterService.GetFirstCharacter());
        }

        [HttpGet]
        [Route("getsingle/{id}")]
        public async Task<ActionResult<Character>> GetSingle(int id)
        {
            return Ok(await _characterService.GetCharacterById(id));
        }

        [HttpPost]
        public async Task<ActionResult<List<Character>>> AddCharacter([FromBody]Character newCharacter)
        {
            return Ok(await _characterService.AddCharacter(newCharacter));
        }
    }
}