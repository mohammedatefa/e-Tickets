using e_Tickets.Models;
using System.Linq.Expressions;

namespace e_Tickets.Specification
{
    public class BaseSpecification<T> : ISpecification<T> where T : Basemodel
    {
        public Expression<Func<T, bool>> Ceritaria { get; set; }
        public List<Expression<Func<T, object>>> Includes { set; get; } = new List<Expression<Func<T, object>>>();

        public BaseSpecification() { }

        public BaseSpecification(Expression<Func<T, bool>> cr)
        {
            Ceritaria = cr;
        }
        
    }
}
