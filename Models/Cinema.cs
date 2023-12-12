using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace e_Tickets.Models
{
    public class Cinema:Basemodel
    {
        
        [Required]
        [DisplayName("Name")]
        public string? Name { get; set; }
        [Required]
        [DisplayName("logo")]
        public string? Logo { get; set; }
        [Required]
        [DisplayName("Description")]
        public string? Description { get; set; }



        //the relation between the cinema and the movies is one-->many as the cinema has many movies 
        public List<Movies> Movies { get; set; } = new List<Movies>();
      
    }
}
