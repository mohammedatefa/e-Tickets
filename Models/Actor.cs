using System.ComponentModel.DataAnnotations;

namespace e_Tickets.Models
{
    public class Actor:Basemodel
    {
        
        [Required]
        public string? FullName { get; set; }
        [Required]
        public string? ImageUrl { get; set; }
        [Required]
        public string? Bio { get; set; }

        //Relations
        public List<Actors_Movies> Actors_Movies { get; set; } = new List<Actors_Movies>();
    }
}
