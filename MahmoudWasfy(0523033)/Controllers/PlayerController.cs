using MahmoudWasfy_0523033_.Dtos.PlayerDtos;
using MahmoudWasfy_0523033_.Models;
using MahmoudWasfy_0523033_.Reposetories.Generics;
using MahmoudWasfy_0523033_.Reposetories.NormalRepos.CoachRepos;
using MahmoudWasfy_0523033_.Reposetories.NormalRepos.PlayerRepos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MahmoudWasfy_0523033_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {

        private readonly IPlayerRepo _PlayerRepo;


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePlayer(int id, PlayerPosUpd dto)
        {
            var player = await _PlayerRepo.GetByIdAsync(id);
            if (player == null)
                return BadRequest("player not found");

            player.Position = dto.Position;

            _PlayerRepo.UpdateAsync(player);
            await _PlayerRepo.SaveChangesAsynco();

            return Ok("Successful Update");
        }



        //[HttpGet]

        //public async Task<IActionResult> GetYoungestPlayer()
        //{

        //    var players = _PlayerRepo.GetPlayersAsync();

        //    if (players == null)
        //    {
        //        return BadRequest();
        //    }

        //    var resault = new Player()
        //    {

        //    };








        //}


    } 
}
