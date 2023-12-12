using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace e_Tickets.Models
{
    public class Actor:Basemodel
    {
        
        [Required]
        [DisplayName("Actor Name")]
        public string? FullName { get; set; }
        [Required]
        [DisplayName("Profile Picture")]
        public string? ImageUrl { get; set; }
        [Required]
        [DisplayName("Biography")]
        public string? Bio { get; set; }

        //Relations
        public List<Actors_Movies> Actors_Movies { get; set; } = new List<Actors_Movies>();
    }
}
