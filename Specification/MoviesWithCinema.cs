using e_Tickets.Models;

namespace e_Tickets.Specification
{
    public class MoviesWithCinema:BaseSpecification<Movies>
    {
        public MoviesWithCinema()
        {
            Includes.Add(m => m.Cenima);
        }
        public MoviesWithCinema(int id):base(m=>m.Id==id)
        {
            Includes.Add(m => m.Cenima);
            Includes.Add(m => m.Producer);
        }
    }
}
