namespace Example1.Models
{
    public class Country
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ShortName { get; set; }

        public virtual List<Hotels> Hotels { get; set; }


    }
}
