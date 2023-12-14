using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace e_Tickets.Models
{
    public class Cinema:Basemodel
    {
        
        [Required(ErrorMessage ="the name of cinema is required ")]
        [DisplayName("Name")]
        public string? Name { get; set; }
        [Required(ErrorMessage ="The Logo Url Is Required")]
        [DisplayName("logo")]
        [Url(ErrorMessage ="You Should Use Valid Url..")]
        public string? Logo { get; set; }
        [Required(ErrorMessage ="the description of the cenima is required ")]
        [DisplayName("Description")]
        [StringLength(500,MinimumLength =10,ErrorMessage ="the description must be more than 10 and less than 500 ")]
        public string? Description { get; set; }



        //the relation between the cinema and the movies is one-->many as the cinema has many movies 
        public List<Movies> Movies { get; set; } = new List<Movies>();
      
    }
}
