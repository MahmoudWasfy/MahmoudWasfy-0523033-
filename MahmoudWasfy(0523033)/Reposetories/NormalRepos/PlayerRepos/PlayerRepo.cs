using MahmoudWasfy_0523033_.AppDbContextFolder;
using MahmoudWasfy_0523033_.Models;
using MahmoudWasfy_0523033_.Reposetories.Generics;
using Microsoft.EntityFrameworkCore;

namespace MahmoudWasfy_0523033_.Reposetories.NormalRepos.PlayerRepos
{
    public class PlayerRepo : GenericRepo<Player>, IPlayerRepo
    {
        public PlayerRepo(AppDbContext context, DbSet<Player> dbset) : base(context, dbset)
        {
        }

        public async Task<IEnumerable<Player>> GetPlayersAsync()
        {
            return await _Context.players.Include(x=> x.Team).ToListAsync();

        }
    }
}
