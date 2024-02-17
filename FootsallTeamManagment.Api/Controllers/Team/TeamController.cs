using FootsallTeamManagment.Entities;
using FootsallTeamManagment.Services.Teams.Contracts;
using FootsallTeamManagment.Services.Teams.Contracts.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FootsallTeamManagment.Api.Controllers.Team
{
    [Route("api/teams")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly TeamService _service;
        public TeamController(TeamService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task Add([FromBody] AddTeamDto dto)
        {
           await _service.Add(dto);
        }
        [HttpPatch("{id}")]
        public async Task Update([FromRoute]int id, [FromBody]UpdateTeamDto dto)
        {
            await _service.Update(id, dto);
        }
        [HttpDelete("{id}")]
        public async Task Delete([FromRoute]int id)
        {
            await _service.Delete(id);
        }
        [HttpGet]
        public List<GetTeamDto> GetTeams([FromQuery]string? name, [FromQuery]KitColor? primaryKitColor, [FromQuery]KitColor? SecondaryKitColor)
        {
            return _service.Get(name, primaryKitColor, SecondaryKitColor);
        }
    }
}
