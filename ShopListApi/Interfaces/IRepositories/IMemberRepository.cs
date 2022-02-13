using System.Collections.Generic;
using ShopListApi.Models;
using System.Threading.Tasks;

namespace ShopListApi.Interfaces
{
    public interface IMemberRepository
    {
        Task<IEnumerable<Member>> GetAsync();
        Task<Member> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task AddAsync(Member member);
        Task UpdateAsync(Member member);
    }
}