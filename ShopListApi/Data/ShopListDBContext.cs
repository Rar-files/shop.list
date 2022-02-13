using Microsoft.EntityFrameworkCore;

namespace ShopListApi.Data
{
    public class ShopListDBContext : DbContext
    {
        public ShopListDBContext(DbContextOptions<ShopListDBContext> options) : base(options)
        {
            
        }
    }
}