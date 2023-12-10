using e_Tickets.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_Tickets.Models
{
    public class Movies:Basemodel
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? ImageUrl { get; set; }
        public decimal Price { get; set; }
        [Required]
        public string? Description { get; set; }
        public DateTime StartDate  { get; set; }
        public DateTime EndDate  { get; set; }
        public MovieCategory Category { get; set; } = new MovieCategory();

        //Relations with cinema,Actor and Procedure 
        //Relations
        public List<Actors_Movies> Actors_Movies { get; set; } = new List<Actors_Movies>();
        //cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema? Cenima { get; set; }

        //Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer? Producer { get; set; }


    }
}
