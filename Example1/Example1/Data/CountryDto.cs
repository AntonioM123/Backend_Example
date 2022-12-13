using System.ComponentModel.DataAnnotations;

namespace Example1.Data
{
    public class CountryDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ShortName { get; set; }

        public IList<HotelDto> Hotel { get; set; }

    }
}
