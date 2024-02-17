using FootsallTeamManagment.Entities;
using FootsallTeamManagment.Services.Teams.Contracts;
using FootsallTeamManagment.Services.Teams.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootsallTeamManagment.Persistence.EF.Teams
{
    public class EfTeamRepository : TeamRepository
    {
        private readonly EFDataContext _context;
        public EfTeamRepository(EFDataContext context)
        {
            _context = context;
        }
        public void Add(Team team)
        {
            _context.Add(team);

        }

        public void Delete(int id)
        {
            var team = _context._teams.FirstOrDefault(_ => _.Id == id);
            _context._teams.Remove(team);

        }

        public List<GetTeamDto> Get(string? name, KitColor? primaryKitColor, KitColor? SecondaryKitColor)
        {
            var result = _context._teams.Select(t => new GetTeamDto
            {
                Id = t.Id,
                Name = t.Name,
                PrimaryKitColor = t.PrimaryKitColor,
                SecondaryKitColor = t.SecondaryKitColor
            });

            if(name != null )
            {
                result = result.Where(t => t.Name == name);
            }
            if(primaryKitColor != null )
            {
                result = result.Where(t => t.PrimaryKitColor == primaryKitColor);
            }
            if (SecondaryKitColor != null)
            {
                result = result.Where(t => t.SecondaryKitColor == SecondaryKitColor);
            }
            return result.ToList();
        }

        public bool IsExistTeamName(string name)
        {
            return _context._teams.Any(_ => _.Name == name);
        }
        public bool IsExistTeamNameWithId(int id, string name)
        {
            return _context._teams.Any(_ => _.Name == name && _.Id != id);
        }
        public Team GetTeamById(int id)
        {
            return _context._teams.FirstOrDefault(_ => _.Id == id);
        }

        public void Update(int id, Team team)
        {
            throw new NotImplementedException();
        }

    }
}
