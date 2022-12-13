using System.ComponentModel.DataAnnotations.Schema;

namespace Example1.Models
{
    public class Hotels
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Adress { get; set; }

        public double Rating { get; set; }

        public int CountryId { get; set; }

        [ForeignKey(nameof(CountryId))]
        public virtual Country? Country { get; set; }
    }
}
