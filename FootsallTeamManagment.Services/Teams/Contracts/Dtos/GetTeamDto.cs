using FootsallTeamManagment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootsallTeamManagment.Services.Teams.Contracts.Dtos
{
    public class GetTeamDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public KitColor PrimaryKitColor { get; set; }
        public KitColor SecondaryKitColor { get; set; }
    }
}
