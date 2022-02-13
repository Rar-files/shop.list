using System.Collections.Generic;
using ShopListApi.Models;
using System.Threading.Tasks;

namespace ShopListApi.Interfaces
{
    public interface IQuantitieTypeRepository
    {
        Task<IEnumerable<QuantitieType>> GetAsync();
        Task<QuantitieType> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task AddAsync(QuantitieType quantitie);
        Task UpdateAsync(QuantitieType quantitie);
    }
}