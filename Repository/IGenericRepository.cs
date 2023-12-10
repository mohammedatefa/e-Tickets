using e_Tickets.Models;

namespace e_Tickets.Repository
{
    public interface IGenericRepository<T> where T:Basemodel
    {
        public Task<T> GetById(int id);
        public Task<ICollection<T>> Getall();
    }

   
}
