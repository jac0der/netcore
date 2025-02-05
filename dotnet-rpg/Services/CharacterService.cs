

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
        
        public async Task<ServiceResponse<Character>> GetDefaultCharacter()
        {
            return new ServiceResponse<Character>{ Data = knigth};
        }

        public async Task<ServiceResponse<Character>> GetFirstCharacter()
        {
            return new ServiceResponse<Character>{ Data = characters[0]};
        }

        public async Task<ServiceResponse<List<Character>>> GetAllCharacters()
        {
            return new ServiceResponse<List<Character>>{ Data = characters };
        }    

        public async Task<ServiceResponse<Character>> GetCharacterById(int id)
        {
            var serviceResponse = new ServiceResponse<Character>();
            serviceResponse.Data = characters.FirstOrDefault(c => c.Id == id);
            return serviceResponse;
        }         

        public async Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter)
        {
            var serviceResponse = new ServiceResponse<List<Character>>();
            characters.Add(newCharacter);
            serviceResponse.Data = characters;
            return serviceResponse;
        }
    }
}