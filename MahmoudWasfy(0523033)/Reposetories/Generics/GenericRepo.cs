
using MahmoudWasfy_0523033_.AppDbContextFolder;
using Microsoft.EntityFrameworkCore;

namespace MahmoudWasfy_0523033_.Reposetories.Generics
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {

        protected readonly AppDbContext _Context;
        protected readonly DbSet<T> _Dbset;

        public GenericRepo(AppDbContext context, DbSet<T> dbset)
        {
            _Context = context;
            _Dbset = _Context.Set<T>();
        }

        public async Task CreateAsync(T entity)
        {
            await _Dbset.AddAsync(entity);
        }

        public async Task DeleteAsync(T entity)
        {
            _Dbset.Remove(entity);
        }

        public async Task<ICollection<T>> GetAllAsync()
        {
            return await _Dbset.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _Dbset.FindAsync(id);
        }

        public async Task SaveChangesAsynco()
        {
            await _Context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
             _Dbset.Update(entity);
        }
    }
}
