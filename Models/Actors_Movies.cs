namespace e_Tickets.Models
{
    public class Actors_Movies
    {
        public int ActorId { get; set; }
        public Actor? Actror { get; set; } = new Actor();
        public int MovieId { get; set; }
        public Movies? Movie { get; set; } = new Movies();
    }
}
