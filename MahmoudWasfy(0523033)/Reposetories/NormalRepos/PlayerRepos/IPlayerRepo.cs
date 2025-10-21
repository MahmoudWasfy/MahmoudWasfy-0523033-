using MahmoudWasfy_0523033_.Models;
using MahmoudWasfy_0523033_.Reposetories.Generics;

namespace MahmoudWasfy_0523033_.Reposetories.NormalRepos.PlayerRepos
{
    public interface IPlayerRepo : IGenericRepo<Player>
    {


        Task<IEnumerable<Player>> GetPlayersAsync();
    }
}
