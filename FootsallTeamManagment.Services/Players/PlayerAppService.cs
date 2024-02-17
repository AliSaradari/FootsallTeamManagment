using FootsallTeamManagment.Contracts;
using FootsallTeamManagment.Services.Players.Contracts;
using FootsallTeamManagment.Services.Players.Contracts.Dtos;
using FootsallTeamManagment.Services.Teams.Contracts;

namespace FootsallTeamManagment.Services.Players
{
    public class PlayerAppService : PlayerService
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly PlayerRepository _repository;
        public PlayerAppService(UnitOfWork unitOfWork
            ,PlayerRepository repository)
        {
            _unitOfWork = unitOfWork;
            this._repository = repository;
        }
        public Task Add(AddPlayerDto dto)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<GetPlayerDto> Get(string? name, int? MinimumAge, int? MaximumAge)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, UpdatePlayerDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
