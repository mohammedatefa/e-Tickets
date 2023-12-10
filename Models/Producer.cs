using System.ComponentModel.DataAnnotations;

namespace e_Tickets.Models
{
    public class Producer
    {
        public int Id { get; set; }
        [Required]
        public string? FullName { get; set; }
        [Required]
        public string? ImageUrl { get; set; }
        [Required]
        public string? Bio { get; set; }

        //relation between the moveis and procedure is one-->many as each peocdure has many movies
        public List<Movies>? Movies {  get; set; }=new List<Movies>();

    }
}
