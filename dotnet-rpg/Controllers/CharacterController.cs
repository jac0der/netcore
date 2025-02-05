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
        public ActionResult<Character> Get()
        {
            return Ok(_characterService.GetDefaultCharacter());
        }

        [HttpGet]
        [Route("getall")]
        public ActionResult<List<Character>> GetAll()
        {
            return Ok(_characterService.GetAllCharacters());
        }

        [HttpGet("getfirst")]
        public ActionResult<Character> GetFirstCharacter()
        {
            return Ok(_characterService.GetFirstCharacter());
        }

        [HttpGet]
        [Route("getsingle/{id}")]
        public ActionResult<Character> GetSingle(int id)
        {
            return Ok(_characterService.GetCharacterById(id));
        }

        [HttpPost]
        public ActionResult<List<Character>> AddCharacter([FromBody]Character newCharacter)
        {
            return Ok(_characterService.AddCharacter(newCharacter));
        }
    }
}