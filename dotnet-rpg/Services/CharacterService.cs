

namespace dotnet_rpg.Services
{
    public class CharacterService : ICharacterService
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
        
        public async Task<Character> GetDefaultCharacter()
        {
            return knigth;
        }

        public async Task<Character> GetFirstCharacter()
        {
            return characters[0];
        }

        public async Task<List<Character>> GetAllCharacters()
        {
            return characters;
        }    

        public async Task<Character> GetCharacterById(int id)
        {
            return characters.FirstOrDefault(c => c.Id == id);
        }         

        public async Task<List<Character>> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return characters;
        }
    }
}