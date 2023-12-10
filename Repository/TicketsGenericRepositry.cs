using e_Tickets.Context;
using e_Tickets.Models;
using Microsoft.EntityFrameworkCore;

namespace e_Tickets.Repository
{
    public class TicketsGenericRepositry<T> : IGenericRepository<T> where T:Basemodel
    {
        private readonly ETicketsDbContext context;

        public TicketsGenericRepositry(ETicketsDbContext _context)
        {
            context = _context;
        }

        public async Task<ICollection<T>> Getall()
        {
            return await context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await context.Set<T>().FindAsync(id);
        }
    }
}
