using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace e_Tickets.Models
{
    public class Producer:Basemodel
    {
        [Required]
        [DisplayName("Producer Name")]
        public string? FullName { get; set; }
        [Required]
        [DisplayName("profile picture")]
        public string? ImageUrl { get; set; }
        [Required]
        [DisplayName("Biography")]
        public string? Bio { get; set; }

        //relation between the moveis and procedure is one-->many as each peocdure has many movies
        public List<Movies>? Movies {  get; set; }=new List<Movies>();

    }
}
