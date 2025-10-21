using MahmoudWasfy_0523033_.Models;
using MahmoudWasfy_0523033_.Reposetories.Generics;

namespace MahmoudWasfy_0523033_.Reposetories.NormalRepos.CompetitionsRepos
{
    public interface ICompetitionRepo : IGenericRepo<Competition>
    {


        Task<IEnumerable<Competition>> GetAllTeams();
    }
}
