using MahmoudWasfy_0523033_.Models;
using MahmoudWasfy_0523033_.Reposetories.Generics;

namespace MahmoudWasfy_0523033_.Reposetories.NormalRepos.TeamRepos
{
    public interface ITeamRepo : IGenericRepo<Team>
    {

        Task<IEnumerable<Team>> GetAllTeamsWithoutComp();

    }
}
