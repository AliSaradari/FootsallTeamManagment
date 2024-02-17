using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootsallTeamManagment.Services.Players.Contracts.Dtos
{
    public class GetPlayerDto
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
