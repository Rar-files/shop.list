using ShopListApi.Models;
using ShopListApi.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ShopListApi.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        public readonly IDataContext _context;
        public MemberRepository(IDataContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Member member)
        {
            await _context.Member.AddAsync(member);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var ToDelete = await GetByIdAsync(id);
            if(ToDelete == null)
                throw new NullReferenceException();

            _context.Member.Remove(ToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Member>> GetAsync() => await _context.Member.ToListAsync();
        public async Task<Member> GetByIdAsync(int id) => await _context.Member.FindAsync(id);

        public async Task UpdateAsync(Member member)
        {
            var ToUpdate = await GetByIdAsync(member.Id);
            if(ToUpdate == null)
                throw new NullReferenceException();

            _context.Member.Update(member);
            await _context.SaveChangesAsync();
        }
    }
}