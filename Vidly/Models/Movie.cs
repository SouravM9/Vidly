using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public Genre Genre { get; set; }
        public byte GenreId { get; set; } //Foreign Key

        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        public byte NoOfStocks { get; set; }
    }
}
