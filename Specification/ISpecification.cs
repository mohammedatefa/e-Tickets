using e_Tickets.Models;
using System.Linq.Expressions;

namespace e_Tickets.Specification
{
    public interface ISpecification<T> where T:Basemodel
    {
        public Expression<Func<T, bool>> Ceritaria { get; set; }
        public List<Expression<Func<T, object>>> Includes { get; set; }

    }
}
