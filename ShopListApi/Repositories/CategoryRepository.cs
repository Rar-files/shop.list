using ShopListApi.Models;
using ShopListApi.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ShopListApi.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public readonly IDataContext _context;
        public CategoryRepository(IDataContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Category category)
        {
            await _context.Category.AddAsync(category);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var ToDelete = await GetByIdAsync(id);
            if(ToDelete == null)
                throw new NullReferenceException();

            _context.Category.Remove(ToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Category>> GetAsync() => await _context.Category.ToListAsync();
        public async Task<Category> GetByIdAsync(int id) => await _context.Category.FindAsync(id);

        public async Task UpdateAsync(Category category)
        {
            var ToUpdate = await GetByIdAsync(category.Id);
            if(ToUpdate == null)
                throw new NullReferenceException();

            _context.Category.Update(category);
            await _context.SaveChangesAsync();
        }
    }
}