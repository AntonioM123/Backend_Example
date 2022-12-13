using System.ComponentModel.DataAnnotations;

namespace Example1.Data
{
    public class HotelDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public double Rating { get; set; }
        [Required]
        public int CountryId { get; set; }
    }
}
