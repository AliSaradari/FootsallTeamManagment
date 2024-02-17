using FootsallTeamManagment.Entities;
using FootsallTeamManagment.Services.Teams.Contracts.Dtos;

namespace FootsallTeamManagment.Services.Teams.Contracts
{
    public interface TeamRepository
    {
        void Add(Team team);
        void Update(int id, Team team);
        void Delete(int id);
        List<GetTeamDto> Get(string? name, KitColor? primaryKitColor, KitColor? SecondaryKitColor);
        bool IsExistTeamName(string name);

        bool IsExistTeamNameWithId(int id , string name);
        Team GetTeamById(int id);


    }
}
