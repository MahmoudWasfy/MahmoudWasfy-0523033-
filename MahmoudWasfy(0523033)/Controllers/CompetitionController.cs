using MahmoudWasfy_0523033_.Models;
using MahmoudWasfy_0523033_.Reposetories.Generics;
using MahmoudWasfy_0523033_.Reposetories.NormalRepos.CompetitionsRepos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MahmoudWasfy_0523033_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetitionController : ControllerBase
    {
        private readonly ICompetitionRepo _repo;


        public CompetitionController(ICompetitionRepo competition)
        {
            _repo = competition;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAuthor(int id)
        {
            var comp = await _repo.GetByIdAsync(id);
            if (comp == null)
                return NotFound();

            _repo.DeleteAsync(comp);
            await _repo.SaveChangesAsynco();

            return NoContent();
        }


        [HttpGet]


        public async Task<IActionResult> getcompsbycount()
        {
            var comps = await _repo.GetAllTeams();


            var res = new Competition
            (



            );

            return Ok();
        }

    }






}
