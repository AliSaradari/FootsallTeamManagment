using FootsallTeamManagment.Entities;
using FootsallTeamManagment.Services.Players.Contracts.Dtos;
using FootsallTeamManagment.Services.Teams.Contracts.Dtos;

namespace FootsallTeamManagment.Services.Players.Contracts
{
    public interface PlayerRepository
    {
        void Add(Player player);
        void Update(int id , string? name , DateTime? birthdate);
        void Delete(int id);
        List<GetPlayerDto> Get(string? name, int? MinimumAge, int? MaximumAge);
        bool IsExistTeamName(string name);

    }
}
