using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static Character knigth = new Character();
        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character{
                Name = "Sam",
                HitPoints = 150
                }
        };

        [HttpGet]
        public ActionResult<Character> Get()
        {
            return Ok(knigth);
        }

        [HttpGet]
        [Route("GetallCharacters")]
        public ActionResult<List<Character>> GetAll()
        {
            return Ok(characters);
        }

        [HttpGet("getfirst")]
        public ActionResult<Character> GetFirstCharacter()
        {
            return characters[0];
        }
    }
}