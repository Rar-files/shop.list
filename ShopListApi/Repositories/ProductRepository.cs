using ShopListApi.Models;
using ShopListApi.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ShopListApi.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public readonly IDataContext _context;
        public ProductRepository(IDataContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Product product)
        {
            await _context.Product.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var ToDelete = await GetByIdAsync(id);
            if(ToDelete == null)
                throw new NullReferenceException();

            _context.Product.Remove(ToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetAsync() => await _context.Product.ToListAsync();
        public async Task<Product> GetByIdAsync(int id) => await _context.Product.FindAsync(id);

        public async Task UpdateAsync(Product product)
        {
            var ToUpdate = await GetByIdAsync(product.ID);
            if(ToUpdate == null)
                throw new NullReferenceException();

            _context.Product.Update(product);
            await _context.SaveChangesAsync();
        }
    }
}