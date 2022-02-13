using ShopListApi.Models;
using ShopListApi.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ShopListApi.Repositories
{
    public class QuantitieTypeRepository : IQuantitieTypeRepository
    {
        public readonly IDataContext _context;
        public QuantitieTypeRepository(IDataContext context)
        {
            _context = context;
        }

        public async Task AddAsync(QuantitieType quantitieType)
        {
            await _context.QuantitieType.AddAsync(quantitieType);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var ToDelete = await GetByIdAsync(id);
            if(ToDelete == null)
                throw new NullReferenceException();

            _context.QuantitieType.Remove(ToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<QuantitieType>> GetAsync() => await _context.QuantitieType.ToListAsync();
        public async Task<QuantitieType> GetByIdAsync(int id) => await _context.QuantitieType.FindAsync(id);

        public async Task UpdateAsync(QuantitieType quantitieType)
        {
            var ToUpdate = await GetByIdAsync(quantitieType.Id);
            if(ToUpdate == null)
                throw new NullReferenceException();

            _context.QuantitieType.Update(quantitieType);
            await _context.SaveChangesAsync();
        }
    }
}