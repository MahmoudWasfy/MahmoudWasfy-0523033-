namespace MahmoudWasfy_0523033_.Reposetories.Generics
{
    public interface IGenericRepo<T> where T : class
    {

        Task CreateAsync(T entity);

        Task DeleteAsync(T entity);

        Task UpdateAsync(T entity);


        Task<T> GetByIdAsync(int Id);

        Task<ICollection<T>> GetAllAsync();

        Task SaveChangesAsynco();



    }
}
