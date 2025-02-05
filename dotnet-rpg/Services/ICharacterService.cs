namespace dotnet_rpg.Services
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<Character>>> GetAllCharacters();
        Task<ServiceResponse<Character>> GetCharacterById(int id);
        Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter);
        Task<ServiceResponse<Character>> GetDefaultCharacter();
        Task<ServiceResponse<Character>> GetFirstCharacter();
    }
}