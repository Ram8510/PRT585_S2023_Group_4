namespace WebApplication_API.Models
{
    public class Book
    {
        public Guid ID { get; set; }
        public string Title { get; set; }

        public string Author { get; set; }  

        public string Publisher { get; set; }

        public string Genre { get; set; }

        public string Author_Email { get; set; }

        public long Published_Year { get; set; }

        public long Edition { get; set; }
        
        public string Language { get; set;}

        public long Price { get; set; } 
    }
}
