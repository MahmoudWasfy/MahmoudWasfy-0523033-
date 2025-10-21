using MahmoudWasfy_0523033_.Dtos.CoachDtos;
using MahmoudWasfy_0523033_.Models;
using MahmoudWasfy_0523033_.Reposetories.Generics;
using MahmoudWasfy_0523033_.Reposetories.NormalRepos.CoachRepos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MahmoudWasfy_0523033_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoachController : ControllerBase
    {

        private readonly IGenericRepo<Team> _TeamRepo;
        private readonly ICoachRepo _CoachRepo;

        public CoachController(IGenericRepo<Team> teamRepo, ICoachRepo coachRepo)
        {
            _TeamRepo = teamRepo;
            _CoachRepo = coachRepo;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllCoachs()
        {
            var coachs = await _CoachRepo.GetAllCoaches();

            var result = coachs
            .Select(a => new CoachReadDto
            {
                Id = a.Id,
                ExpierneceYears = a.ExpierneceYears,
                Specialization = a.Specialization,
                Name = a.Name,
                Team = a.Team

            }).GroupBy(a => a.Specialization).ToList();

            return Ok(result);
        }


       












    } 
}
