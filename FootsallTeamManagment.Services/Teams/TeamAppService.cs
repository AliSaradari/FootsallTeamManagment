using FootsallTeamManagment.Contracts;
using FootsallTeamManagment.Entities;
using FootsallTeamManagment.Services.Teams.Contracts;
using FootsallTeamManagment.Services.Teams.Contracts.Dtos;

namespace FootsallTeamManagment.Services.Teams
{
    public class TeamAppService : TeamService
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly TeamRepository _repository;
        public TeamAppService(UnitOfWork unitOfWork
            , TeamRepository repository)
        {
            _unitOfWork = unitOfWork;
            this._repository = repository;
        }
        public async Task Add(AddTeamDto dto)
        {
            if (_repository.IsExistTeamName(dto.Name))
            {
                throw new Exception("Team name cannot be duplicate");
            }
            if (dto.PrimaryKitColor == dto.SecondaryKitColor)
            {
                throw new Exception("Primary and Secendary kit cannot be the same");
            }
            var team = new Team()
            {
                Name = dto.Name,
                PrimaryKitColor = dto.PrimaryKitColor,
                SecondaryKitColor = dto.SecondaryKitColor,
            };
            _repository.Add(team);
            await _unitOfWork.Complete();
        }

        public async Task Update(int id, UpdateTeamDto dto)
        {

            if (_repository.IsExistTeamNameWithId(id,dto.Name))
            {
                throw new Exception("Team name cannot be duplicate");
            }
            var updatedTeam = _repository.GetTeamById(id);
            updatedTeam.Name = dto.Name;
            updatedTeam.PrimaryKitColor = dto.PrimaryKitColor;  
            updatedTeam.SecondaryKitColor = dto.SecondaryKitColor;                        
            await _unitOfWork.Complete();
        }
        public async Task Delete(int id)
        {
            _repository.Delete(id);
            await _unitOfWork.Complete();
        }

        public List<GetTeamDto> Get(string? name,KitColor? primaryKitColor, KitColor? SecondaryKitColor)
        {
            return _repository.Get(name, primaryKitColor, SecondaryKitColor);
        }
    }
}
