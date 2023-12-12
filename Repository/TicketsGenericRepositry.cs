using e_Tickets.Context;
using e_Tickets.Models;
using e_Tickets.Specification;
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
        #region getBy Using Specification
        public async Task<IReadOnlyList<T>> GetAllWithSpec(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).ToListAsync();
        }

        public async Task<T> GetByIdWithSpec(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).FirstOrDefaultAsync();
        }
        private IQueryable<T> ApplySpecification(ISpecification<T> specification)
        {
            return specificationEvaluter<T>.GetQuery(context.Set<T>(), specification);
        }
        #endregion
    }
}
