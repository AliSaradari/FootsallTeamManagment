using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootsallTeamManagment.Entities
{
    public class TeamPlayer
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public Player player { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}
