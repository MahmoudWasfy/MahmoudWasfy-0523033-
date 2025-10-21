using MahmoudWasfy_0523033_.Models;
using MahmoudWasfy_0523033_.Reposetories.Generics;

namespace MahmoudWasfy_0523033_.Reposetories.NormalRepos.CoachRepos
{
    public interface ICoachRepo : IGenericRepo<Coach>
    {

        Task<IEnumerable<Coach>> GetAllCoaches();



    }
}
