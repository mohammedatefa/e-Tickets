using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace e_Tickets.Models
{
    public class Producer:Basemodel
    {
        [Required(ErrorMessage ="The Name Of Producer is required")]
        [DisplayName("Producer Name")]
        public string? FullName { get; set; }
        [Required(ErrorMessage = "The Logo Url Of Producer is required")]
        [DisplayName("profile picture")]
        [Url(ErrorMessage ="You Should Enter Valid Url")]
        public string? ImageUrl { get; set; }
        [Required(ErrorMessage = "The Biography Of Producer is required")]
        [DisplayName("Biography")]
        [StringLength(500,MinimumLength =10,ErrorMessage ="the bio must be less than 500 and more than 10")]
        public string? Bio { get; set; }

        //relation between the moveis and procedure is one-->many as each peocdure has many movies
        public List<Movies>? Movies {  get; set; }=new List<Movies>();

    }
}
