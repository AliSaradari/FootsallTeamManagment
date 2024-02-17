using FootsallTeamManagment.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootsallTeamManagment.Services.Teams.Contracts.Dtos
{
    public class UpdateTeamDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public KitColor PrimaryKitColor { get; set; }
        [Required]
        public KitColor SecondaryKitColor { get; set; }
    }
}
