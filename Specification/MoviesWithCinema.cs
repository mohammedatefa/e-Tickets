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

        //using search specification 
        public MoviesWithCinema(string movieName) : base(m=>(string.IsNullOrEmpty(movieName))||m.Name.ToLower().Contains(movieName))
        {
            Includes.Add(m => m.Cenima);
            Includes.Add(m => m.Producer);
        }
        
    }
}
