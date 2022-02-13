using Microsoft.EntityFrameworkCore;
using ShopListApi.Models;
using ShopListApi.Interfaces;

namespace ShopListApi.Data
{
    public class ShopListDBContext : DbContext, IDataContext
    {
        public ShopListDBContext(DbContextOptions<ShopListDBContext> options) : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Member> Member { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<QuantitieType> QuantitieType { get; set; }
    }
}