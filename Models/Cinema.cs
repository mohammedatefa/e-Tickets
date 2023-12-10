using System.ComponentModel.DataAnnotations;

namespace e_Tickets.Models
{
    public class Cinema
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Logo { get; set; }
        [Required]
        public string? Description { get; set; }



        //the relation between the cinema and the movies is one-->many as the cinema has many movies 
        public List<Movies> Movies { get; set; } = new List<Movies>();
      
    }
}
