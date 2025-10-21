using MahmoudWasfy_0523033_.Dtos.TeamDto;
using MahmoudWasfy_0523033_.Models;
using MahmoudWasfy_0523033_.Reposetories.Generics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MahmoudWasfy_0523033_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {

        private readonly IGenericRepo<Team> _TeamRepo;

        public TeamController(IGenericRepo<Team> teamRepo)
        {
            _TeamRepo = teamRepo;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAuthor(CreateTeamDto dto)
        {


            var team = new Team
            {
                Name = dto.Name,
                Coachid = dto.Coachid


            };

            await _TeamRepo.CreateAsync(team);
            await _TeamRepo.SaveChangesAsynco();

            return Created();
        }





    }
}
