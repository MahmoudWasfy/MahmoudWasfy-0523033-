using MahmoudWasfy_0523033_.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace MahmoudWasfy_0523033_.Dtos.TeamDto
{
    public class CreateTeamDto
    {
        public string Name { get; set; }
        public int Coachid { get; set; }

    }
}
