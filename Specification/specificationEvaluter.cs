using e_Tickets.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace e_Tickets.Specification
{
    public class specificationEvaluter<T> where T : Basemodel
    {
        public static IQueryable<T> GetQuery(IQueryable<T> InputQuery, ISpecification<T> spec)
        {
            var query = InputQuery;

            //where Query
            if (spec.Ceritaria is not null)
            {
                query = query.Where(spec.Ceritaria);
            }
            //Include Query
            query = spec.Includes.Aggregate(query, (current, includeexpression) => current.Include(includeexpression));

            return query;
        }
    }
}
