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

        #region Getting Entity Without Specification
        public async Task<ICollection<T>> Getall()
        {
            return await context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await context.Set<T>().FindAsync(id);
        } 
        #endregion

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

        #region crud operations Add,Update And delete
        public async Task Add(T entity)
        {
            if (entity is not null)
            {
                try
                {
                    await context.Set<T>().AddAsync(entity);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("there is some thing wron during add new item to database", ex);

                }
            }
        }
        public async Task Update(int id, T entity)
        {
            var found = await context.Set<T>().FindAsync(id);
            if (found != null)
            {
                try
                {
                    // Update the properties of the found entity with the properties of the provided entity
                    context.Entry(found).CurrentValues.SetValues(entity);
                    await context.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    throw new Exception("there is some thing wron during update item in database", ex);

                }
            }
            else
            {
                throw new Exception("the item that you want to update is not found");
            }
        }

        public async Task Delete(int id)
        {
            var found = await GetById(id);
            if (found != null)
            {
                try
                {
                    context.Set<T>().Remove(found);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("there is some thing wron during remove item from database", ex);

                }
            }
            else
            {
                throw new Exception("the item that you want to remove is not found");
            }
        } 
        #endregion
    }
}
