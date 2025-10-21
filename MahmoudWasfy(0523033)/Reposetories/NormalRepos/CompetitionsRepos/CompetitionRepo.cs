using MahmoudWasfy_0523033_.AppDbContextFolder;
using MahmoudWasfy_0523033_.Models;
using MahmoudWasfy_0523033_.Reposetories.Generics;
using Microsoft.EntityFrameworkCore;

namespace MahmoudWasfy_0523033_.Reposetories.NormalRepos.CompetitionsRepos
{
    public class CompetitionRepo : GenericRepo<Competition>, ICompetitionRepo
    {
        public CompetitionRepo(AppDbContext context, DbSet<Competition> dbset) : base(context, dbset)
        {
        }

        public async Task<IEnumerable<Competition>> GetAllTeams()
        {
            return await _Context.competitions.Include(x => x.Location).ToListAsync();
        }
    }
}
