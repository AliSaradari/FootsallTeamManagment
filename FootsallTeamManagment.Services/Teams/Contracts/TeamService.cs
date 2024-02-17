using FootsallTeamManagment.Entities;
using FootsallTeamManagment.Services.Teams.Contracts.Dtos;
using System.ComponentModel;

namespace FootsallTeamManagment.Services.Teams.Contracts
{
    public interface TeamService
    {
        Task Add(AddTeamDto dto);
        Task Update(int id, UpdateTeamDto dto);
        Task Delete(int id);
        List<GetTeamDto> Get(string? name, KitColor? primaryKitColor, KitColor? SecondaryKitColor);

    }
}
