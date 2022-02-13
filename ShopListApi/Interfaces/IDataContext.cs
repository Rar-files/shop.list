using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShopListApi.Models;

namespace ShopListApi.Interfaces
{
    public interface IDataContext
    {
        DbSet<Category> Category { get; set; }
        DbSet<Member> Member { get; set; }
        DbSet<Product> Product { get; set; }
        DbSet<QuantitieType> QuantitieType { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}