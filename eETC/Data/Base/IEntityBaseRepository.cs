using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eETC.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class ,IEntityBase , new()
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task AddAsync (T entity);
        Task UpdateAsync (int id,T entity);

        Task<T> GetByIdAsync(int id);

        Task DeleteAsync(int id);

    }
}
