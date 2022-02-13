using System.Collections.Generic;
using ShopListApi.Models;
using System.Threading.Tasks;

namespace ShopListApi.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAsync();
        Task<Category> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task AddAsync(Category category);
        Task UpdateAsync(Category category);
        
    }
}