using MahmoudWasfy_0523033_.AppDbContextFolder;
using MahmoudWasfy_0523033_.Models;
using MahmoudWasfy_0523033_.Reposetories.Generics;
using Microsoft.EntityFrameworkCore;

namespace MahmoudWasfy_0523033_.Reposetories.NormalRepos.CoachRepos
{
    public class CoachRepo : GenericRepo<Coach>, ICoachRepo
    {
        public CoachRepo(AppDbContext context, DbSet<Coach> dbset) : base(context, dbset)
        {
        }

        public async Task<IEnumerable<Coach>> GetAllCoaches()
        {

            return await _Context.coaches.Include(x=> x.Team).ToListAsync();
        }



    }
}
