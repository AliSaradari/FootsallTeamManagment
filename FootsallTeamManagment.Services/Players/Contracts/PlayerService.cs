using FootsallTeamManagment.Services.Players.Contracts.Dtos;
using FootsallTeamManagment.Services.Teams.Contracts.Dtos;

namespace FootsallTeamManagment.Services.Players.Contracts
{
    public interface PlayerService
    {        
        Task Add(AddPlayerDto dto);
        Task Update(int id, UpdatePlayerDto dto);
        Task Delete(int id);
        List<GetPlayerDto> Get(string? name, int? MinimumAge, int? MaximumAge);

    }
}
