using System.Collections.Generic;
using ShopListApi.Models;
using System.Threading.Tasks;

namespace ShopListApi.Interfaces
{
    public interface IProductRepository
    {
        
        Task<IEnumerable<Product>> GetAsync();
        Task<Product> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
    }
}