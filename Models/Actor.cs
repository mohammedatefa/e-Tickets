using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace e_Tickets.Models
{
    public class Actor:Basemodel
    {

        [Required(ErrorMessage = "Please enter the actor's full name.")]
        [DisplayName("Actor Name")]
        public string? FullName { get; set; }

        [Required(ErrorMessage = "Please provide the actor's profile picture URL.")]
        [DisplayName("Profile Picture")]
        [Url(ErrorMessage = "Please enter a valid URL.")]
        public string? ImageUrl { get; set; }

        [Required(ErrorMessage = "Please enter the actor's biography.")]
        [DisplayName("Biography")]
        [StringLength(500, MinimumLength = 10, ErrorMessage = "Bio length must be between 10 and 500 characters.")]
        public string? Bio { get; set; }

        //Relations
        public List<Actors_Movies> Actors_Movies { get; set; } = new List<Actors_Movies>();
    }
}
