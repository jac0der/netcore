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
                Id = 1,
                Name = "Sam",
                HitPoints = 150
                },
            new Character{
                Id = 2,
                Name = "Todi",
                HitPoints = 400
                }
        };

        [HttpGet]
        public ActionResult<Character> Get()
        {
            return Ok(knigth);
        }

        [HttpGet]
        [Route("getall")]
        public ActionResult<List<Character>> GetAll()
        {
            return Ok(characters);
        }

        [HttpGet("getfirst")]
        public ActionResult<Character> GetFirstCharacter()
        {
            return Ok(characters[0]);
        }

        [HttpGet]
        [Route("getsingle/{id}")]
        public ActionResult<Character> GetSingle(int id)
        {
            return Ok(characters.FirstOrDefault(c => c.Id == id));
        }

        [HttpPost]
        public ActionResult<List<Character>> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return Ok(characters);
        }
    }
}