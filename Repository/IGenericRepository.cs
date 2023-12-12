using e_Tickets.Models;
using e_Tickets.Specification;

namespace e_Tickets.Repository
{
    public interface IGenericRepository<T> where T:Basemodel
    {
        public Task<T> GetById(int id);
        public Task<ICollection<T>> Getall();

        //get model useing the specification class instead of using the normal way to include any property 
        public Task<IReadOnlyList<T>> GetAllWithSpec(ISpecification<T> spec);
        public Task<T> GetByIdWithSpec(ISpecification<T> spec);
    }

   
}
